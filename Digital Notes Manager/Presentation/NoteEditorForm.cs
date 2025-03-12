using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Services;
using Digital_Notes_Manager.Domain.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Digital_Notes_Manager.Presentation
{
    public partial class NoteEditorForm : Form
    {
        public NoteDto Note { get; set; }

        private readonly NoteService _noteService;

        public NoteEditorForm(NoteService noteService)
        {
            _noteService = noteService;

            InitializeComponent();

            btnBold.CheckedChanged += new EventHandler(UpdateFontStyle!);
            btnItalic.CheckedChanged += new EventHandler(UpdateFontStyle!);
            btnUnderline.CheckedChanged += new EventHandler(UpdateFontStyle!);
        }

        private void NoteEditorForm_Load(object sender, EventArgs e)
        {
            if (Note != null)
            {
                titleTxt.Text = Note.Title;
                contentTxt.Text = Note.Content;
                reminderDate.Value = Note.ReminderDate ?? DateTime.Now;
                addBtn.Text = "Update";

                if (Enum.TryParse(typeof(Category), Note.Category, out var categoryEnum))
                {
                    categorySelector.categoriesComboBox.SelectedItem = (Category)categoryEnum;
                }
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateFontStyle(object sender, EventArgs e)
        {
            int selectionStart = contentTxt.SelectionStart;
            int selectionLength = contentTxt.SelectionLength;

            Font currentFont = contentTxt.SelectionFont;

            FontStyle newFontStyle = FontStyle.Regular;

            if (btnBold.Checked)
                newFontStyle |= FontStyle.Bold;

            if (btnItalic.Checked)
                newFontStyle |= FontStyle.Italic;

            if (btnUnderline.Checked)
                newFontStyle |= FontStyle.Underline;

            if (currentFont != null)
            {
                contentTxt.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }

            contentTxt.Select(selectionStart, selectionLength);
        }

        private void Notification(object sender, Category category)
        {
            MessageBox.Show($"Category changed to: {category}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private async void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (.txt)|.txt";
            openFileDialog1.Title = "Open Note File";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    string fileContent = await _noteService.LoadNoteContentAsync(filePath);

                    contentTxt.Text = fileContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
