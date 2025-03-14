using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Events;
using Digital_Notes_Manager.Application.Services;
using Digital_Notes_Manager.Domain.Enums;
using Digital_Notes_Manager.Presentation.CustomControlls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace Digital_Notes_Manager.Presentation
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;

        private readonly NoteService _noteService;

        private readonly IServiceProvider _serviceProvider;

        private SearchBy searchBy = SearchBy.Title;

        private readonly CategorySelector categorySelector;

        private ToolStripControlHost comboBoxHost;

        private List<NoteDto> notes;

        public MainForm(NoteService noteService, UserService userService, IServiceProvider serviceProvider)
        {
            this.IsMdiContainer = true;

            _userService = userService;
            _serviceProvider = serviceProvider;
            _noteService = noteService;

            categorySelector = new();

            notes = [];

            _noteService.NoteChanged += OnNoteChanged;
            _noteService.ReminderTrigged += ShowReminderNotification;

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = _userService.GetLoggedInUser()!.Username;

            comboBoxHost = new ToolStripControlHost(categorySelector);

            appBar.Items.Insert(4, comboBoxHost);

            comboBoxHost.Visible = false;

            notes = await _noteService.GetAllNotes();

            ShowNotes(notes);
        }

        private void ShowReminderNotification(object? sender, ReminderEventArgs e)
        {
            ShowToastNotification("Reminder for not", e.Title);
        }

        private async void OnNoteChanged(object? sender, EventArgs e)
        {
            try
            {
                notes = await _noteService.GetAllNotes();

                ShowNotes(notes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowNotes(List<NoteDto> notes)
        {
            notesDataGridView.DataSource = notes;

            CustomizeDataGridView();
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            List<NoteDto> filteredNotes = [];

            switch (searchBy)
            {
                case SearchBy.Content:
                    if (!string.IsNullOrEmpty(searchTxt.Text))
                    {
                        filteredNotes = await _noteService.SearchByContent(searchTxt.Text);
                    }
                    break;

                case SearchBy.Category:
                    if (categorySelector.categoriesComboBox.SelectedItem is Category selectedCategory)
                    {
                        filteredNotes = await _noteService.SearchByCategory(selectedCategory.ToString());
                    }
                    break;

                default:
                    if (!string.IsNullOrEmpty(searchTxt.Text))
                    {
                        filteredNotes = await _noteService.SearchByTitle(searchTxt.Text);
                    }
                    break;
            }

            if (filteredNotes.Any())
                ShowNotes(filteredNotes);
            else
                MessageBox.Show("No matching tasks found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _userService.UserLogout();
                this.Hide();
                var login = _serviceProvider.GetRequiredService<LogIn>();
                login.Show();
            }
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notesDataGridView.Visible = false;

                foreach (Form child in this.MdiChildren)
                {
                    if (child is NoteEditorForm)
                    {
                        child.Activate();
                        return;
                    }
                }

                NoteEditorForm noteEditorForm = _serviceProvider.GetRequiredService<NoteEditorForm>();
                noteEditorForm.MdiParent = this;
                noteEditorForm.WindowState = FormWindowState.Normal;
                noteEditorForm.Show();

                this.LayoutMdi(MdiLayout.TileHorizontal);
                noteEditorForm.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening child form: {ex.Message}");
            }
        }

        private void cascadeBtn_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileBtn_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CustomizeDataGridView()
        {
            // Enable double buffering for smoother scrolling
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, notesDataGridView, new object[] { true });

            // Header styling
            notesDataGridView.EnableHeadersVisualStyles = false;
            notesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            notesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            notesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            notesDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align header text

            // Row styling (cell alignment and colors)
            notesDataGridView.DefaultCellStyle.BackColor = Color.White;
            notesDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            notesDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            notesDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align cell text
            notesDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
            notesDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid styling
            notesDataGridView.GridColor = Color.LightGray;
            notesDataGridView.BorderStyle = BorderStyle.Fixed3D;
            notesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            notesDataGridView.RowHeadersVisible = false;

            // Alternating row colors
            notesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Auto size columns
            notesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set row height
            notesDataGridView.RowTemplate.Height = 60;

            foreach (DataGridViewRow row in notesDataGridView.Rows)
            {
                row.Height = 60; // Or any specific condition
            }
        }

        private void notesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                notesDataGridView.Visible = false;

                var selectedNote = (NoteDto)notesDataGridView.Rows[e.RowIndex].DataBoundItem;

                var noteDetailsForm = _serviceProvider.GetRequiredService<NoteDetailsForm>();

                noteDetailsForm.Note = selectedNote;

                noteDetailsForm.MdiParent = this;

                noteDetailsForm.Show();

                noteDetailsForm.BringToFront();
            }
        }

        private void titleBtn_Click(object sender, EventArgs e)
        {
            searchBy = SearchBy.Title;

            searchTxt.Visible = true;
            comboBoxHost.Visible = false;
        }

        private void contentBtn_Click(object sender, EventArgs e)
        {
            searchBy = SearchBy.Content;

            searchTxt.Visible = true;
            comboBoxHost.Visible = false;
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            searchBy = SearchBy.Category;

            searchTxt.Visible = false;
            comboBoxHost.Visible = true;
        }

        private void descinding_Click(object sender, EventArgs e)
        {
            var sortedNotes = notes.OrderBy(n => n.CreationDate).ToList();

            ShowNotes(sortedNotes);

            assending.Visible = true;
            descinding.Visible = false;
        }

        private void assending_Click(object sender, EventArgs e)
        {
            var sortedNotes = notes.OrderByDescending(n => n.CreationDate).ToList();

            ShowNotes(sortedNotes);

            assending.Visible = false;
            descinding.Visible = true;
        }

        private void ShowToastNotification(string title, string message)
        {
            // Create toast content
            var content = new ToastContentBuilder()
                .AddText(title)
                .AddText(message)
                .GetToastContent();

            // Convert to XML format
            XmlDocument xmlDoc = new();
            xmlDoc.LoadXml(content.GetContent());

            // Create the toast notification
            ToastNotification toast = new(xmlDoc);

            // Show the toast notification using ToastNotificationManager
            ToastNotificationManager.CreateToastNotifier("DigitalNotesManager").Show(toast);
        }

        private void notesListBtn_Click(object sender, EventArgs e)
        {
            notesDataGridView.Visible = true;
        }
    }
}