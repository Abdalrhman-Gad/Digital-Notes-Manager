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
            updateBtn = new PictureBox();
            deleteBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).BeginInit();
            SuspendLayout();
            // 
            // contentTxt
            // 
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
            updateBtn.BackgroundImageLayout = ImageLayout.Center;
            updateBtn.Image = (Image)resources.GetObject("updateBtn.Image");
            updateBtn.Location = new Point(435, 92);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(33, 30);
            updateBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            updateBtn.TabIndex = 6;
            updateBtn.TabStop = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(435, 46);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(33, 30);
            deleteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteBtn.TabIndex = 7;
            deleteBtn.TabStop = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // NoteDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 342);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(creationDateLbl);
            Controls.Add(pictureBox1);
            Controls.Add(reminderDateLbl);
            Controls.Add(categoryLbl);
            Controls.Add(contentTxt);
            Name = "NoteDetailsForm";
            Text = "Title";
            Load += NoteDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox contentTxt;
        private Label categoryLbl;
        private PictureBox pictureBox1;
        private Label reminderDateLbl;
        private Label creationDateLbl;
        private PictureBox updateBtn;
        private PictureBox deleteBtn;
    }
}