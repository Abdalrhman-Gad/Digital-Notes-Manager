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
            nToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem1 = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            notesListToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // nToolStripMenuItem
            // 
            nToolStripMenuItem.Name = "nToolStripMenuItem";
            nToolStripMenuItem.Size = new Size(139, 28);
            nToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(139, 28);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(139, 28);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, formatToolStripMenuItem1 });
            editToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(56, 27);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(154, 28);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(154, 28);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(154, 28);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // formatToolStripMenuItem1
            // 
            formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            formatToolStripMenuItem1.Size = new Size(154, 28);
            formatToolStripMenuItem1.Text = "Format";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notesListToolStripMenuItem, cascadeToolStripMenuItem, tileToolStripMenuItem });
            formatToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold);
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(65, 27);
            formatToolStripMenuItem.Text = "View";
            // 
            // notesListToolStripMenuItem
            // 
            notesListToolStripMenuItem.Name = "notesListToolStripMenuItem";
            notesListToolStripMenuItem.Size = new Size(178, 28);
            notesListToolStripMenuItem.Text = "Notes List";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(178, 28);
            cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(178, 28);
            tileToolStripMenuItem.Text = "Tile";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(64, 27);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(147, 28);
            aboutToolStripMenuItem.Text = "About";
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
        private ToolStripMenuItem nToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem1;
        private ToolStripMenuItem notesListToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
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