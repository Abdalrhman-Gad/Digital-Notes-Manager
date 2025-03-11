namespace Digital_Notes_Manager.Presentation
{
    partial class SaveNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 29);
            button1.Name = "button1";
            button1.Size = new Size(92, 49);
            button1.TabIndex = 0;
            button1.Text = "OPEN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += openbtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 29);
            button2.Name = "button2";
            button2.Size = new Size(94, 49);
            button2.TabIndex = 1;
            button2.Text = "SAVE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += savebtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 103);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 192);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveNotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SaveNotes";
            Text = "SaveNotes";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}