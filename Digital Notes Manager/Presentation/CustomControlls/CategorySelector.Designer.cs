namespace Digital_Notes_Manager.Presentation.CustomControlls
{
    partial class CategorySelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            categoriesComboBox = new ComboBox();
            SuspendLayout();
            // 
            // categoriesComboBox
            // 
            categoriesComboBox.FormattingEnabled = true;
            categoriesComboBox.Location = new Point(0, 0);
            categoriesComboBox.MaximumSize = new Size(153, 0);
            categoriesComboBox.MinimumSize = new Size(153, 0);
            categoriesComboBox.Name = "categoriesComboBox";
            categoriesComboBox.Size = new Size(153, 28);
            categoriesComboBox.TabIndex = 0;
            // 
            // CategorySelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(categoriesComboBox);
            MaximumSize = new Size(203, 27);
            MinimumSize = new Size(203, 27);
            Name = "CategorySelector";
            Size = new Size(203, 27);
            Load += CategorySelector_Load;
            ResumeLayout(false);
        }

        #endregion

        public ComboBox categoriesComboBox;
    }
}
