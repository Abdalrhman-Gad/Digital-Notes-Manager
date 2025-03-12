namespace Digital_Notes_Manager.Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newBtn = new ToolStripMenuItem();
            openBtn = new ToolStripMenuItem();
            saveBtn = new ToolStripMenuItem();
            exitBtn = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutBtn = new ToolStripMenuItem();
            copyBtn = new ToolStripMenuItem();
            pasteBtn = new ToolStripMenuItem();
            formatBtn = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            notesListBtn = new ToolStripMenuItem();
            cascadeBtn = new ToolStripMenuItem();
            tileBtn = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutBtn = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            notesDataGridView = new DataGridView();
            appBar = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel3 = new ToolStripLabel();
            searchTxt = new ToolStripTextBox();
            searchBtn = new ToolStripButton();
            filterSearch = new ToolStripSplitButton();
            titleBtn = new ToolStripMenuItem();
            contentBtn = new ToolStripMenuItem();
            categoryBtn = new ToolStripMenuItem();
            descinding = new ToolStripButton();
            assending = new ToolStripButton();
            logoutBtn = new ToolStripButton();
            usernameLbl = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notesDataGridView).BeginInit();
            appBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBtn, openBtn, saveBtn, exitBtn });
            fileToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // newBtn
            // 
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(139, 28);
            newBtn.Text = "New";
            newBtn.Click += newBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(139, 28);
            openBtn.Text = "Open";
            // 
            // saveBtn
            // 
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(139, 28);
            saveBtn.Text = "Save";
            // 
            // exitBtn
            // 
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(139, 28);
            exitBtn.Text = "Exit";
            exitBtn.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutBtn, copyBtn, pasteBtn, formatBtn });
            editToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(56, 27);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutBtn
            // 
            cutBtn.Name = "cutBtn";
            cutBtn.Size = new Size(154, 28);
            cutBtn.Text = "Cut";
            // 
            // copyBtn
            // 
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(154, 28);
            copyBtn.Text = "Copy";
            // 
            // pasteBtn
            // 
            pasteBtn.Name = "pasteBtn";
            pasteBtn.Size = new Size(154, 28);
            pasteBtn.Text = "Paste";
            // 
            // formatBtn
            // 
            formatBtn.Name = "formatBtn";
            formatBtn.Size = new Size(154, 28);
            formatBtn.Text = "Format";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notesListBtn, cascadeBtn, tileBtn });
            formatToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold);
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(65, 27);
            formatToolStripMenuItem.Text = "View";
            // 
            // notesListBtn
            // 
            notesListBtn.Name = "notesListBtn";
            notesListBtn.Size = new Size(224, 28);
            notesListBtn.Text = "Notes List";
            // 
            // cascadeBtn
            // 
            cascadeBtn.Name = "cascadeBtn";
            cascadeBtn.Size = new Size(224, 28);
            cascadeBtn.Text = "Cascade";
            cascadeBtn.Click += cascadeBtn_Click;
            // 
            // tileBtn
            // 
            tileBtn.Name = "tileBtn";
            tileBtn.Size = new Size(224, 28);
            tileBtn.Text = "Tile";
            tileBtn.Click += tileBtn_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutBtn });
            helpToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(64, 27);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutBtn
            // 
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(147, 28);
            aboutBtn.Text = "About";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 50, 56);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 36);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(notesDataGridView);
            panel2.Controls.Add(appBar);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 475);
            panel2.TabIndex = 4;
            // 
            // notesDataGridView
            // 
            notesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notesDataGridView.Location = new Point(3, 40);
            notesDataGridView.Name = "notesDataGridView";
            notesDataGridView.RowHeadersWidth = 51;
            notesDataGridView.Size = new Size(978, 432);
            notesDataGridView.TabIndex = 3;
            // 
            // appBar
            // 
            appBar.ImageScalingSize = new Size(20, 20);
            appBar.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripSeparator2, toolStripLabel3, searchTxt, searchBtn, filterSearch, descinding, assending, logoutBtn, usernameLbl });
            appBar.Location = new Point(0, 0);
            appBar.Name = "appBar";
            appBar.Padding = new Padding(5);
            appBar.Size = new Size(984, 37);
            appBar.TabIndex = 2;
            appBar.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(160, 24);
            toolStripLabel2.Text = "Digital Notes Manager";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(53, 24);
            toolStripLabel3.Text = "Search";
            // 
            // searchTxt
            // 
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(170, 27);
            // 
            // searchBtn
            // 
            searchBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageTransparentColor = Color.Magenta;
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(29, 24);
            searchBtn.Text = "Search";
            searchBtn.Click += searchBtn_Click;
            // 
            // filterSearch
            // 
            filterSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            filterSearch.DropDownItems.AddRange(new ToolStripItem[] { titleBtn, contentBtn, categoryBtn });
            filterSearch.Image = (Image)resources.GetObject("filterSearch.Image");
            filterSearch.ImageTransparentColor = Color.Magenta;
            filterSearch.Name = "filterSearch";
            filterSearch.Size = new Size(39, 24);
            filterSearch.Text = "Filter";
            // 
            // titleBtn
            // 
            titleBtn.Name = "titleBtn";
            titleBtn.Size = new Size(152, 26);
            titleBtn.Text = "Title";
            // 
            // contentBtn
            // 
            contentBtn.Name = "contentBtn";
            contentBtn.Size = new Size(152, 26);
            contentBtn.Text = "Content";
            // 
            // categoryBtn
            // 
            categoryBtn.Name = "categoryBtn";
            categoryBtn.Size = new Size(152, 26);
            categoryBtn.Text = "Category";
            // 
            // descinding
            // 
            descinding.DisplayStyle = ToolStripItemDisplayStyle.Image;
            descinding.Image = (Image)resources.GetObject("descinding.Image");
            descinding.ImageTransparentColor = Color.Magenta;
            descinding.Name = "descinding";
            descinding.Size = new Size(29, 24);
            descinding.Text = "Descinding";
            // 
            // assending
            // 
            assending.DisplayStyle = ToolStripItemDisplayStyle.Image;
            assending.Image = (Image)resources.GetObject("assending.Image");
            assending.ImageTransparentColor = Color.Magenta;
            assending.Name = "assending";
            assending.Size = new Size(29, 24);
            assending.Text = "Assending";
            assending.Visible = false;
            // 
            // logoutBtn
            // 
            logoutBtn.Alignment = ToolStripItemAlignment.Right;
            logoutBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageTransparentColor = Color.Magenta;
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(29, 24);
            logoutBtn.Text = "Logout";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // usernameLbl
            // 
            usernameLbl.Alignment = ToolStripItemAlignment.Right;
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(73, 24);
            usernameLbl.Text = "username";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            TransparencyKey = Color.White;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)notesDataGridView).EndInit();
            appBar.ResumeLayout(false);
            appBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newBtn;
        private ToolStripMenuItem openBtn;
        private ToolStripMenuItem saveBtn;
        private ToolStripMenuItem exitBtn;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem cutBtn;
        private ToolStripMenuItem copyBtn;
        private ToolStripMenuItem pasteBtn;
        private ToolStripMenuItem formatBtn;
        private ToolStripMenuItem notesListBtn;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutBtn;
        private Panel panel1;
        private ToolStripMenuItem cascadeBtn;
        private ToolStripMenuItem tileBtn;
        private Panel panel2;
        private ToolStrip appBar;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox searchTxt;
        private ToolStripButton searchBtn;
        private ToolStripSplitButton filterSearch;
        private ToolStripMenuItem contentBtn;
        private ToolStripMenuItem titleBtn;
        private ToolStripButton descinding;
        private ToolStripButton assending;
        private ToolStripButton logoutBtn;
        private ToolStripLabel usernameLbl;
        private ToolStripMenuItem categoryBtn;
        private DataGridView notesDataGridView;
    }
}