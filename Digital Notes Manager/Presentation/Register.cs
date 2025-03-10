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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Digital_Notes_Manager.Presentation
{
    public partial class Register : Form
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IServiceProvider _serviceProvider;

        public Register(
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IUserStore<User> userStore,
            IServiceProvider serviceProvider
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _serviceProvider = serviceProvider;

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
                    var user = CreateUser();

                    await _userStore.SetUserNameAsync(user, UserNametxt.Text, CancellationToken.None);

                    var result = await _userManager.CreateAsync(user, ConfirmPasswordtxt.Text);

                    if (result.Succeeded)
                    {
                        if (result.Succeeded)
                        {
                            var login = _serviceProvider.GetRequiredService<LogIn>();
                            this.Hide();
                            login.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private User CreateUser()
        {
            try
            {
                return Activator.CreateInstance<User>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
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
