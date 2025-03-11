using Digital_Notes_Manager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Presentation.CustomControlls
{
    public partial class CategorySelector : UserControl
    {
        public event EventHandler<Category>? CategoryChanged;

        public CategorySelector()
        {
            InitializeComponent();
        }

        private void CategorySelector_Load(object sender, EventArgs e)
        {
            categoriesComboBox.DataSource = Enum.GetValues(typeof(Category));

            categoriesComboBox.SelectedIndexChanged += OnCategoryChanged;
        }

        private void OnCategoryChanged(object? sender, EventArgs e)
        {
            CategoryChanged?.Invoke(this, (Category)categoriesComboBox.SelectedItem!);
        }
    }
}