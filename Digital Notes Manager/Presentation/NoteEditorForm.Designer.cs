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
            loadBtn = new PictureBox();
            saveBtn = new PictureBox();
            categorySelector = new CustomControlls.CategorySelector();
            addBtn = new Button();
            ReminderDatelbl = new Label();
            reminderDate = new DateTimePicker();
            contentTxt = new RichTextBox();
            titleTxt = new TextBox();
            Titlelbl = new Label();
            Categorylbl = new Label();
            FontStylegb = new GroupBox();
            btnBold = new CheckBox();
            btnItalic = new CheckBox();
            btnUnderline = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            NoteEditorpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loadBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saveBtn).BeginInit();
            FontStylegb.SuspendLayout();
            SuspendLayout();
            // 
            // NoteEditorpn
            // 
            NoteEditorpn.BackColor = Color.Lavender;
            NoteEditorpn.Controls.Add(loadBtn);
            NoteEditorpn.Controls.Add(saveBtn);
            NoteEditorpn.Controls.Add(categorySelector);
            NoteEditorpn.Controls.Add(addBtn);
            NoteEditorpn.Controls.Add(ReminderDatelbl);
            NoteEditorpn.Controls.Add(reminderDate);
            NoteEditorpn.Controls.Add(contentTxt);
            NoteEditorpn.Controls.Add(titleTxt);
            NoteEditorpn.Controls.Add(Titlelbl);
            NoteEditorpn.Controls.Add(Categorylbl);
            NoteEditorpn.Controls.Add(FontStylegb);
            NoteEditorpn.Dock = DockStyle.Fill;
            NoteEditorpn.Location = new Point(0, 0);
            NoteEditorpn.Name = "NoteEditorpn";
            NoteEditorpn.Size = new Size(538, 691);
            NoteEditorpn.TabIndex = 0;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.Azure;
            loadBtn.BackgroundImageLayout = ImageLayout.Center;
            loadBtn.Image = (Image)resources.GetObject("loadBtn.Image");
            loadBtn.Location = new Point(471, 81);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(33, 30);
            loadBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            loadBtn.TabIndex = 10;
            loadBtn.TabStop = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Azure;
            saveBtn.BackgroundImageLayout = ImageLayout.Center;
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.Location = new Point(471, 17);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(33, 30);
            saveBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            saveBtn.TabIndex = 9;
            saveBtn.TabStop = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // categorySelector
            // 
            categorySelector.Location = new Point(159, 12);
            categorySelector.MaximumSize = new Size(153, 28);
            categorySelector.MinimumSize = new Size(153, 28);
            categorySelector.Name = "categorySelector";
            categorySelector.Size = new Size(153, 28);
            categorySelector.TabIndex = 8;
            categorySelector.CategoryChanged += Notification;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(38, 50, 56);
            addBtn.Cursor = Cursors.Hand;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(12, 622);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(492, 43);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // ReminderDatelbl
            // 
            ReminderDatelbl.AutoSize = true;
            ReminderDatelbl.BackColor = Color.Lavender;
            ReminderDatelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReminderDatelbl.ForeColor = SystemColors.ActiveCaptionText;
            ReminderDatelbl.Location = new Point(12, 69);
            ReminderDatelbl.Name = "ReminderDatelbl";
            ReminderDatelbl.Size = new Size(118, 20);
            ReminderDatelbl.TabIndex = 7;
            ReminderDatelbl.Text = "ReminderDate :";
            // 
            // reminderDate
            // 
            reminderDate.Location = new Point(159, 64);
            reminderDate.Name = "reminderDate";
            reminderDate.Size = new Size(203, 27);
            reminderDate.TabIndex = 6;
            // 
            // contentTxt
            // 
            contentTxt.Location = new Point(12, 324);
            contentTxt.Name = "contentTxt";
            contentTxt.Size = new Size(492, 281);
            contentTxt.TabIndex = 5;
            contentTxt.Text = "";
            // 
            // titleTxt
            // 
            titleTxt.Location = new Point(159, 127);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(203, 27);
            titleTxt.TabIndex = 4;
            // 
            // Titlelbl
            // 
            Titlelbl.AutoSize = true;
            Titlelbl.BackColor = Color.Lavender;
            Titlelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titlelbl.ForeColor = SystemColors.ActiveCaptionText;
            Titlelbl.Location = new Point(12, 130);
            Titlelbl.Name = "Titlelbl";
            Titlelbl.Size = new Size(48, 20);
            Titlelbl.TabIndex = 3;
            Titlelbl.Text = "Title :";
            // 
            // Categorylbl
            // 
            Categorylbl.AutoSize = true;
            Categorylbl.BackColor = Color.Lavender;
            Categorylbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Categorylbl.ForeColor = SystemColors.ActiveCaptionText;
            Categorylbl.Location = new Point(12, 17);
            Categorylbl.Name = "Categorylbl";
            Categorylbl.Size = new Size(81, 20);
            Categorylbl.TabIndex = 2;
            Categorylbl.Text = "Category :";
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
            FontStylegb.Size = new Size(492, 117);
            FontStylegb.TabIndex = 1;
            FontStylegb.TabStop = false;
            FontStylegb.Text = "Font Style";
            // 
            // btnBold
            // 
            btnBold.AutoSize = true;
            btnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.Location = new Point(78, 47);
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
            btnItalic.Location = new Point(201, 47);
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
            btnUnderline.Location = new Point(337, 47);
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
            Load += NoteEditorForm_Load;
            NoteEditorpn.ResumeLayout(false);
            NoteEditorpn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loadBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)saveBtn).EndInit();
            FontStylegb.ResumeLayout(false);
            FontStylegb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NoteEditorpn;
        private GroupBox FontStylegb;
        private Label Titlelbl;
        private Label Categorylbl;
        private CheckBox btnBold;
        private CheckBox btnItalic;
        private CheckBox btnUnderline;
        private TextBox titleTxt;
        private Label ReminderDatelbl;
        private DateTimePicker reminderDate;
        private RichTextBox contentTxt;
        private Button addBtn;
        private CustomControlls.CategorySelector categorySelector;
        private PictureBox loadBtn;
        private PictureBox saveBtn;
        private OpenFileDialog openFileDialog1;
    }
    }