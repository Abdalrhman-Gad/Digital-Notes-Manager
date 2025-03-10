using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Presentation
{
    public partial class Register: Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Registerpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LogInlkl_LinkClicked(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }
    }
}
