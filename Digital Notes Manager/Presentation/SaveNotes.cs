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
    public partial class SaveNotes: Form
    {
        public SaveNotes()
        {
            InitializeComponent();
        }
        private void openbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (.txt)|.txt|All files (.)|.";
            openFileDialog1.Title = "Open Note File";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    string fileContent = File.ReadAllText(filePath);

                    richTextBox1.Text = fileContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (.txt)|.txt|All files (.)|.";
            saveFileDialog1.Title = "Save Note File";

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    string fileContent = richTextBox1.Text;

                    File.WriteAllText(filePath, fileContent);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
