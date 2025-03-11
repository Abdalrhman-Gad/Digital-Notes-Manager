using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Services;
using Digital_Notes_Manager.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
    public partial class Register : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly UserService _userService;

        public Register(IServiceProvider serviceProvider, UserService userService)
        {
            _serviceProvider = serviceProvider;
            _userService = userService;

            InitializeComponent();
        }

        private void Registerpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogInlkl_LinkClicked(object sender, EventArgs e)
        {
            var login = _serviceProvider.GetRequiredService<LogIn>();
            this.Hide();
            login.Show();
        }

        private async void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (InputsIsValid())
            {
                try
                {
                    UserAuthDTO user = new UserAuthDTO
                    {
                        Username = UserNametxt.Text,
                        Password = Passwordtxt.Text,
                    };

                    var result = await _userService.RegisterUserAsync(user);

                    if (result.Succeeded)
                    {
                        var login = _serviceProvider.GetRequiredService<LogIn>();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("wrong username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool InputsIsValid()
        {
            usernameErrorLbl.Visible = false;
            passwordErrorLbl.Visible = false;
            confirmPassErrorLbl.Visible = false;

            bool isUsernameValid = !string.IsNullOrWhiteSpace(UserNametxt.Text);
            bool isPasswordValid = !string.IsNullOrWhiteSpace(Passwordtxt.Text) && Passwordtxt.TextLength >= 4;
            bool isConfirmPasswordValid = !string.IsNullOrWhiteSpace(ConfirmPasswordtxt.Text) && ConfirmPasswordtxt.Text == Passwordtxt.Text;

            if (!isUsernameValid)
                usernameErrorLbl.Visible = true;

            if (!isPasswordValid)
                passwordErrorLbl.Visible = true;

            if (!isConfirmPasswordValid)
                confirmPassErrorLbl.Visible = true;

            return isUsernameValid && isPasswordValid && isConfirmPasswordValid;
        }
    }
}
