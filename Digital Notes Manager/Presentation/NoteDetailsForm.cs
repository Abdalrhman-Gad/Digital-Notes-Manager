using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Presentation
{
    public partial class NoteDetailsForm : Form
    {
        public NoteDto Note { get; set; }

        private readonly NoteService _noteService;

        private readonly IServiceProvider _serviceProvider;

        public NoteDetailsForm(IServiceProvider serviceProvider,NoteService noteService)
        {
            _noteService = noteService;
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void NoteDetailsForm_Load(object sender, EventArgs e)
        {
            this.Text = Note.Title;
            creationDateLbl.Text = Note.CreationDate.ToString();
            reminderDateLbl.Text = Note.ReminderDate.ToString();
            categoryLbl.Text = Note.Category;
            contentTxt.Text = Note.Content;
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Text, "Are you sure you want to delete this note?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                await _noteService.DeleteAsync(Note.NoteID);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            NoteEditorForm noteEditorForm = 
                _serviceProvider.GetRequiredService<NoteEditorForm>();

            noteEditorForm.Note = Note;

            noteEditorForm.MdiParent = this.MdiParent;

            noteEditorForm.Show();
        }
    }
}
