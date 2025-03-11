using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Services;
using Digital_Notes_Manager.Domain.Exceptions;
using Digital_Notes_Manager.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace Digital_Notes_Manager.Presentation
{
    public partial class LogIn : Form
    {
        private readonly UserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public LogIn(UserService userService,IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private void LogInpb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            var register = _serviceProvider.GetRequiredService<Register>();
            this.Hide();
            register.Show();
        }

        private async void LogInbtn_Click(object sender, EventArgs e)
        {
            if (InputsIsValid())
            {
                try
                {
                    var user = new UserAuthDTO
                    {
                        Username = UserNametxt.Text,
                        Password = Passwordtxt.Text,
                    };

                    var result = await _userService.LoginUserAsync(user);

                    if (result)
                    {
                        this.Hide();
                        var mainForm = _serviceProvider.GetRequiredService<MainForm>();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (UserNotFoundException)
                {
                    MessageBox.Show("Invalid username or password.", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            bool isUsernameValid = !string.IsNullOrWhiteSpace(UserNametxt.Text);
            bool isPasswordValid = !string.IsNullOrWhiteSpace(Passwordtxt.Text) && Passwordtxt.TextLength >= 4;

            if (!isUsernameValid)
                usernameErrorLbl.Visible = true;

            if (!isPasswordValid)
                passwordErrorLbl.Visible = true;

            return isUsernameValid && isPasswordValid;
        }
    }
}