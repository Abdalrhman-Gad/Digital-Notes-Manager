using Digital_Notes_Manager.Application.Services;
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
    public partial class MainForm : Form
    {
        private readonly UserService _userService;

        public MainForm(UserService userService)
        {
            _userService = userService;

            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _userService.UserLogout();
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
