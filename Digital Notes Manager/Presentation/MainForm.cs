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

        public MainForm(NoteService noteService, UserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            _noteService = noteService;

            categorySelector = new();

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = _userService.GetLoggedInUser()!.Username;

            ToolStripControlHost comboBoxHost = new ToolStripControlHost(categorySelector);

            appBar.Items.Insert(4, comboBoxHost);

            comboBoxHost.Visible = false;

            await ShowDefaultTasksAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Test(object sender, Category category)
        {
            MessageBox.Show($"Category changed to: {category}");
        }

        private void ShowTasks(List<NoteDto> notes)
        {
            notesDataGridView.DataSource = notes;
        }

        private async Task ShowDefaultTasksAsync()
        {
            var tasks = await _noteService.GetAllNotes();
            ShowTasks(tasks);
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            List<NoteDto> tasks = [];

            switch (searchBy)
            {
                case SearchBy.Content:
                    if (!string.IsNullOrEmpty(searchTxt.Text))
                    {
                        tasks = await _noteService.SearchByContent(searchTxt.Text);
                    }
                    break;

                case SearchBy.Category:
                    if (categorySelector.categoriesComboBox.SelectedItem is Category selectedCategory)
                    {
                        tasks = await _noteService.SearchByCategory(selectedCategory.ToString());
                    }
                    break;

                default:
                    if (!string.IsNullOrEmpty(searchTxt.Text))
                    {
                        tasks = await _noteService.SearchByTitle(searchTxt.Text);
                    }
                    break;
            }

            if (tasks.Any())
                ShowTasks(tasks);
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
            NoteEditorForm noteEditorForm = new()
            {
                MdiParent = this
            };
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
    }
}