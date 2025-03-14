namespace Digital_Notes_Manager.Presentation
{
    partial class NoteDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteDetailsForm));
            contentTxt = new RichTextBox();
            categoryLbl = new Label();
            pictureBox1 = new PictureBox();
            reminderDateLbl = new Label();
            creationDateLbl = new Label();
            updateBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contentTxt
            // 
            contentTxt.BackColor = Color.White;
            contentTxt.Location = new Point(12, 46);
            contentTxt.Name = "contentTxt";
            contentTxt.ReadOnly = true;
            contentTxt.Size = new Size(417, 286);
            contentTxt.TabIndex = 0;
            contentTxt.Text = "";
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.Location = new Point(217, 9);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(69, 20);
            categoryLbl.TabIndex = 1;
            categoryLbl.Text = "Category";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // reminderDateLbl
            // 
            reminderDateLbl.AutoSize = true;
            reminderDateLbl.ForeColor = Color.DimGray;
            reminderDateLbl.Location = new Point(316, 9);
            reminderDateLbl.Name = "reminderDateLbl";
            reminderDateLbl.Size = new Size(101, 20);
            reminderDateLbl.TabIndex = 3;
            reminderDateLbl.Text = "DD-MM-YYYY";
            // 
            // creationDateLbl
            // 
            creationDateLbl.AutoSize = true;
            creationDateLbl.ForeColor = Color.DimGray;
            creationDateLbl.Location = new Point(44, 9);
            creationDateLbl.Name = "creationDateLbl";
            creationDateLbl.Size = new Size(101, 20);
            creationDateLbl.TabIndex = 5;
            creationDateLbl.Text = "DD-MM-YYYY";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.White;
            updateBtn.BackgroundImageLayout = ImageLayout.Zoom;
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.FromArgb(38, 50, 56);
            updateBtn.Image = (Image)resources.GetObject("updateBtn.Image");
            updateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            updateBtn.Location = new Point(12, 338);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 44);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(38, 50, 56);
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(268, 338);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(161, 44);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // NoteDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(445, 401);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(creationDateLbl);
            Controls.Add(pictureBox1);
            Controls.Add(reminderDateLbl);
            Controls.Add(categoryLbl);
            Controls.Add(contentTxt);
            MaximizeBox = false;
            MaximumSize = new Size(463, 448);
            MinimumSize = new Size(463, 448);
            Name = "NoteDetailsForm";
            Text = "Title";
            Load += NoteDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox contentTxt;
        private Label categoryLbl;
        private PictureBox pictureBox1;
        private Label reminderDateLbl;
        private Label creationDateLbl;
        private Button updateBtn;
        private Button deleteBtn;
    }
}