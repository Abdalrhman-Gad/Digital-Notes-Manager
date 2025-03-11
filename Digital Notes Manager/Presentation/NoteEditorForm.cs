using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Digital_Notes_Manager.Presentation
{
    public partial class NoteEditorForm : Form
    {


        public NoteEditorForm()
        {
            InitializeComponent();
            btnBold.CheckedChanged += new EventHandler(UpdateFontStyle);
            btnItalic.CheckedChanged += new EventHandler(UpdateFontStyle);
            btnUnderline.CheckedChanged += new EventHandler(UpdateFontStyle);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateFontStyle(object sender, EventArgs e)
        {
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            Font currentFont = richTextBox1.SelectionFont;

            FontStyle newFontStyle = FontStyle.Regular;

            if (btnBold.Checked)
                newFontStyle |= FontStyle.Bold;

            if (btnItalic.Checked)
                newFontStyle |= FontStyle.Italic;

            if (btnUnderline.Checked)
                newFontStyle |= FontStyle.Underline;

            if (currentFont != null)
            {
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }

            richTextBox1.Select(selectionStart, selectionLength);
        }
    }
}
