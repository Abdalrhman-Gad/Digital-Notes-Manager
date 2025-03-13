using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Services;
using Digital_Notes_Manager.Domain.Enums;
using Digital_Notes_Manager.Presentation.CustomControlls;
using Microsoft.Extensions.DependencyInjection;
namespace Digital_Notes_Manager.Presentation
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;

        private readonly NoteService _noteService;

        private readonly IServiceProvider _serviceProvider;

        private SearchBy searchBy = SearchBy.Title;

        private CategorySelector categorySelector;

        private List<NoteDto> notes;

        public MainForm(NoteService noteService, UserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            _noteService = noteService;

            categorySelector = new();

            notes = [];

            _noteService.NoteChanged += OnNoteChanged;

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = _userService.GetLoggedInUser()!.Username;

            ToolStripControlHost comboBoxHost = new ToolStripControlHost(categorySelector);

            appBar.Items.Insert(4, comboBoxHost);

            comboBoxHost.Visible = false;

            notes = await _noteService.GetAllNotes();

            ShowTasks(notes);
        }

        private async void OnNoteChanged(object? sender, EventArgs e)
        {
            notes = await _noteService.GetAllNotes();

            ShowTasks(notes);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowTasks(List<NoteDto> notes)
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
                ShowTasks(filteredNotes);
            else
                MessageBox.Show("No matching tasks found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            _userService.UserLogout();

            this.Hide();

            var login = _serviceProvider.GetRequiredService<LogIn>();

            login.Show();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            NoteEditorForm noteEditorForm =
                _serviceProvider.GetRequiredService<NoteEditorForm>();

            noteEditorForm.Show();
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
                null, notesDataGridView, [true]);

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
        }

        private void notesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedNote = (NoteDto)notesDataGridView.Rows[e.RowIndex].DataBoundItem;

                var noteDetailsForm = _serviceProvider.GetRequiredService<NoteDetailsForm>();

                noteDetailsForm.Note = selectedNote;

                noteDetailsForm.ShowDialog();
            }
        }
    }
}