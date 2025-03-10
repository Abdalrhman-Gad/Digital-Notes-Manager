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
        private readonly UserManager<User> _userManager;
        private readonly IServiceProvider _serviceProvider;

        public LogIn(UserManager<User> userManager,IServiceProvider serviceProvider)
        {
            _userManager = userManager;
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
                    var userName = UserNametxt.Text;
                    var password = Passwordtxt.Text;

                    // Get the user from UserManager
                    var user = await _userManager.FindByNameAsync(userName);
                    if (user != null)
                    {
                        // Verify the password using the PasswordHasher
                        var result = await _userManager.CheckPasswordAsync(user, password);

                        if (result)
                        {
                            // Password is correct
                            this.Hide(); // Close the LogIn form
                            MainForm mainForm = new MainForm(); // Open MainForm
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Register failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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