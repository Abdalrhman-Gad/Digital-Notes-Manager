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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteEditorForm));
            NoteEditorpn = new Panel();
            addBtn = new Button();
            panel1 = new Panel();
            categorySelector = new CustomControlls.CategorySelector();
            ReminderDatelbl = new Label();
            saveBtn = new Button();
            reminderDate = new DateTimePicker();
            loadBtn = new Button();
            Categorylbl = new Label();
            titleTxt = new TextBox();
            Titlelbl = new Label();
            contentTxt = new RichTextBox();
            FontStylegb = new GroupBox();
            btnBold = new CheckBox();
            btnItalic = new CheckBox();
            btnUnderline = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NoteEditorpn.SuspendLayout();
            panel1.SuspendLayout();
            FontStylegb.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NoteEditorpn
            // 
            NoteEditorpn.BackColor = Color.White;
            NoteEditorpn.Controls.Add(flowLayoutPanel1);
            NoteEditorpn.Controls.Add(panel1);
            NoteEditorpn.Controls.Add(contentTxt);
            NoteEditorpn.Controls.Add(FontStylegb);
            NoteEditorpn.Dock = DockStyle.Fill;
            NoteEditorpn.Location = new Point(0, 0);
            NoteEditorpn.Name = "NoteEditorpn";
            NoteEditorpn.Size = new Size(517, 493);
            NoteEditorpn.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(38, 50, 56);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(3, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(489, 58);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(categorySelector);
            panel1.Controls.Add(ReminderDatelbl);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(reminderDate);
            panel1.Controls.Add(loadBtn);
            panel1.Controls.Add(Categorylbl);
            panel1.Controls.Add(titleTxt);
            panel1.Controls.Add(Titlelbl);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 178);
            panel1.TabIndex = 13;
            // 
            // categorySelector
            // 
            categorySelector.Location = new Point(158, 18);
            categorySelector.MaximumSize = new Size(153, 28);
            categorySelector.MinimumSize = new Size(153, 28);
            categorySelector.Name = "categorySelector";
            categorySelector.Size = new Size(153, 28);
            categorySelector.TabIndex = 14;
            // 
            // ReminderDatelbl
            // 
            ReminderDatelbl.AutoSize = true;
            ReminderDatelbl.BackColor = Color.White;
            ReminderDatelbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReminderDatelbl.ForeColor = Color.Black;
            ReminderDatelbl.Location = new Point(11, 75);
            ReminderDatelbl.Name = "ReminderDatelbl";
            ReminderDatelbl.Size = new Size(136, 23);
            ReminderDatelbl.TabIndex = 13;
            ReminderDatelbl.Text = "ReminderDate :";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.White;
            saveBtn.BackgroundImageLayout = ImageLayout.Zoom;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.FromArgb(38, 50, 56);
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(336, 112);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(135, 43);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // reminderDate
            // 
            reminderDate.Location = new Point(158, 73);
            reminderDate.Name = "reminderDate";
            reminderDate.Size = new Size(153, 27);
            reminderDate.TabIndex = 12;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.White;
            loadBtn.BackgroundImageLayout = ImageLayout.Zoom;
            loadBtn.Cursor = Cursors.Hand;
            loadBtn.FlatStyle = FlatStyle.Popup;
            loadBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadBtn.ForeColor = Color.FromArgb(38, 50, 56);
            loadBtn.Image = (Image)resources.GetObject("loadBtn.Image");
            loadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loadBtn.Location = new Point(336, 18);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(135, 43);
            loadBtn.TabIndex = 11;
            loadBtn.Text = "Open";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // Categorylbl
            // 
            Categorylbl.AutoSize = true;
            Categorylbl.BackColor = Color.White;
            Categorylbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categorylbl.ForeColor = Color.Black;
            Categorylbl.Location = new Point(11, 21);
            Categorylbl.Name = "Categorylbl";
            Categorylbl.Size = new Size(94, 23);
            Categorylbl.TabIndex = 9;
            Categorylbl.Text = "Category :";
            // 
            // titleTxt
            // 
            titleTxt.Location = new Point(158, 127);
            titleTxt.Multiline = true;
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(153, 28);
            titleTxt.TabIndex = 11;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.White;
            Titlelbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titlelbl.ForeColor = Color.Black;
            Titlelbl.Location = new Point(11, 130);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(56, 23);
            Titlelbl.TabIndex = 10;
            Titlelbl.Text = "Title :";
            // 
            // contentTxt
            // 
            contentTxt.Location = new Point(12, 273);
            contentTxt.Name = "contentTxt";
            contentTxt.Size = new Size(489, 145);
            contentTxt.TabIndex = 5;
            contentTxt.Text = "";
            // 
            // FontStylegb
            // 
            FontStylegb.BackColor = Color.White;
            FontStylegb.Controls.Add(btnBold);
            FontStylegb.Controls.Add(btnItalic);
            FontStylegb.Controls.Add(btnUnderline);
            FontStylegb.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FontStylegb.ForeColor = SystemColors.ActiveCaptionText;
            FontStylegb.Location = new Point(12, 190);
            FontStylegb.Name = "FontStylegb";
            FontStylegb.Size = new Size(489, 77);
            FontStylegb.TabIndex = 1;
            FontStylegb.TabStop = false;
            FontStylegb.Text = "Font Style";
            // 
            // btnBold
            // 
            btnBold.AutoSize = true;
            btnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.Location = new Point(79, 28);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(63, 24);
            btnBold.TabIndex = 2;
            btnBold.Text = "Bold";
            btnBold.UseVisualStyleBackColor = true;
            // 
            // btnItalic
            // 
            btnItalic.AutoSize = true;
            btnItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalic.Location = new Point(202, 28);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(63, 24);
            btnItalic.TabIndex = 3;
            btnItalic.Text = "Italic";
            btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            btnUnderline.AutoSize = true;
            btnUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUnderline.Location = new Point(338, 28);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(95, 24);
            btnUnderline.TabIndex = 4;
            btnUnderline.Text = "Underline";
            btnUnderline.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(addBtn);
            flowLayoutPanel1.Location = new Point(10, 424);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(493, 61);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // NoteEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 493);
            Controls.Add(NoteEditorpn);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(535, 738);
            MinimumSize = new Size(535, 540);
            Name = "NoteEditorForm";
            Text = "Note Editor";
            Load += NoteEditorForm_Load;
            NoteEditorpn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            FontStylegb.ResumeLayout(false);
            FontStylegb.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NoteEditorpn;
        private GroupBox FontStylegb;
        private CheckBox btnBold;
        private CheckBox btnItalic;
        private CheckBox btnUnderline;
        private RichTextBox contentTxt;
        private Button addBtn;
        private OpenFileDialog openFileDialog1;
        private Button loadBtn;
        private Button saveBtn;
        private Panel panel1;
        private CustomControlls.CategorySelector categorySelector;
        private Label ReminderDatelbl;
        private DateTimePicker reminderDate;
        private TextBox titleTxt;
        private Label Titlelbl;
        private Label Categorylbl;
        private FlowLayoutPanel flowLayoutPanel1;
    }
    }