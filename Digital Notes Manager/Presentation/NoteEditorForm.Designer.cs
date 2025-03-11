namespace Digital_Notes_Manager.Presentation
{
   
        partial class NoteEditorForm
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
            NoteEditorpn = new Panel();
            Savebtn = new Button();
            ReminderDatelbl = new Label();
            Notedtb = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            Titlelbl = new Label();
            Categorylbl = new Label();
            FontStylegb = new GroupBox();
            btnBold = new CheckBox();
            btnItalic = new CheckBox();
            btnUnderline = new CheckBox();
            comboBox1 = new ComboBox();
            NoteEditorpn.SuspendLayout();
            FontStylegb.SuspendLayout();
            SuspendLayout();
            // 
            // NoteEditorpn
            // 
            NoteEditorpn.BackColor = Color.White;
            NoteEditorpn.Controls.Add(Savebtn);
            NoteEditorpn.Controls.Add(ReminderDatelbl);
            NoteEditorpn.Controls.Add(Notedtb);
            NoteEditorpn.Controls.Add(richTextBox1);
            NoteEditorpn.Controls.Add(textBox1);
            NoteEditorpn.Controls.Add(Titlelbl);
            NoteEditorpn.Controls.Add(Categorylbl);
            NoteEditorpn.Controls.Add(FontStylegb);
            NoteEditorpn.Controls.Add(comboBox1);
            NoteEditorpn.Dock = DockStyle.Fill;
            NoteEditorpn.Location = new Point(0, 0);
            NoteEditorpn.Name = "NoteEditorpn";
            NoteEditorpn.Size = new Size(538, 691);
            NoteEditorpn.TabIndex = 0;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.FromArgb(38, 50, 56);
            Savebtn.Cursor = Cursors.Hand;
            Savebtn.ForeColor = Color.White;
            Savebtn.Location = new Point(12, 622);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(492, 43);
            Savebtn.TabIndex = 1;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            // 
            // ReminderDatelbl
            // 
            ReminderDatelbl.AutoSize = true;
            ReminderDatelbl.BackColor = Color.White;
            ReminderDatelbl.Location = new Point(12, 69);
            ReminderDatelbl.Name = "ReminderDatelbl";
            ReminderDatelbl.Size = new Size(105, 20);
            ReminderDatelbl.TabIndex = 7;
            ReminderDatelbl.Text = "ReminderDate";
            // 
            // Notedtb
            // 
            Notedtb.Location = new Point(159, 62);
            Notedtb.Name = "Notedtb";
            Notedtb.Size = new Size(203, 27);
            Notedtb.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 324);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(492, 281);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 4;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.White;
            Titlelbl.Location = new Point(12, 130);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(38, 20);
            Titlelbl.TabIndex = 3;
            Titlelbl.Text = "Title";
            // 
            // Categorylbl
            // 
            Categorylbl.AutoSize = true;
            Categorylbl.BackColor = Color.White;
            Categorylbl.Location = new Point(12, 12);
            Categorylbl.Name = "Categorylbl";
            Categorylbl.Size = new Size(69, 20);
            Categorylbl.TabIndex = 2;
            Categorylbl.Text = "Category";
            // 
            // FontStylegb
            // 
            FontStylegb.BackColor = Color.White;
            FontStylegb.Controls.Add(btnBold);
            FontStylegb.Controls.Add(btnItalic);
            FontStylegb.Controls.Add(btnUnderline);
            FontStylegb.Location = new Point(12, 190);
            FontStylegb.Name = "FontStylegb";
            FontStylegb.Size = new Size(492, 117);
            FontStylegb.TabIndex = 1;
            FontStylegb.TabStop = false;
            FontStylegb.Text = "Font Style";
            // 
            // btnBold
            // 
            btnBold.AutoSize = true;
            btnBold.Location = new Point(6, 39);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(62, 24);
            btnBold.TabIndex = 2;
            btnBold.Text = "Bold";
            btnBold.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            btnItalic.AutoSize = true;
            btnItalic.Location = new Point(129, 39);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(63, 24);
            btnItalic.TabIndex = 3;
            btnItalic.Text = "Italic";
            btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            btnUnderline.AutoSize = true;
            btnUnderline.Location = new Point(265, 39);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(95, 24);
            btnUnderline.TabIndex = 4;
            btnUnderline.Text = "Underline";
            btnUnderline.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 28);
            comboBox1.TabIndex = 0;
            // 
            // NoteEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 691);
            Controls.Add(NoteEditorpn);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(556, 738);
            MinimumSize = new Size(556, 738);
            Name = "NoteEditorForm";
            Text = "Note Editor";
            NoteEditorpn.ResumeLayout(false);
            NoteEditorpn.PerformLayout();
            FontStylegb.ResumeLayout(false);
            FontStylegb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NoteEditorpn;
        private GroupBox FontStylegb;
        private ComboBox comboBox1;
        private Label Titlelbl;
        private Label Categorylbl;
        private CheckBox btnBold;
        private CheckBox btnItalic;
        private CheckBox btnUnderline;
        private TextBox textBox1;
        private Label ReminderDatelbl;
        private DateTimePicker Notedtb;
        private RichTextBox richTextBox1;
        private Button Savebtn;
    }
    }