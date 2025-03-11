using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Interfaces;
using Digital_Notes_Manager.Domain.Exceptions;
using Digital_Notes_Manager.Domain.Models;
using Digital_Notes_Manager.Infrastructure;
using Digital_Notes_Manager.Infrastructure.Settings;
using Microsoft.AspNetCore.Identity;

namespace Digital_Notes_Manager.Application.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        private readonly IUserStore<Domain.Models.User> _userStore;
        private readonly UserManager<Domain.Models.User> _userManager;
        private readonly SignInManager<Domain.Models.User> _signInManager;


        public UserService(
            ApplicationDbContext context,
            IUserStore<Domain.Models.User> userStore,
            UserManager<Domain.Models.User> userManager,
            SignInManager<Domain.Models.User> signInManager)
        {
            _context = context;
            _userStore = userStore;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> RegisterUserAsync(UserAuthDTO _user)
        {
            var user = CreateUser();

            await _userStore.SetUserNameAsync(user, _user.Username, CancellationToken.None);

            return await _userManager.CreateAsync(user, _user.Password);
        }

        public async Task<bool> UpdateAsync(UserAuthDTO _user)
        {
            var user = await _context.Users.FindAsync(_user.UserID);

            if (user == null)
            {
                throw new UserNotFoundException($"User not found with id:{_user.UserID}");
            }

            user.UserName = _user.Username;

            if (!string.IsNullOrWhiteSpace(_user.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passwordResult = await _userManager.ResetPasswordAsync(user, token, _user.Password);

                if (!passwordResult.Succeeded)
                {
                    return false;
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public void UserLogout()
        {
            SettingsManager.ClearUser();
        }

        private Domain.Models.User CreateUser()
        {
            try
            {
                return Activator.CreateInstance<Domain.Models.User>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Domain.Models.User)}'. " +
                    $"Ensure that '{nameof(Domain.Models.User)}' is not an abstract class and has a parameterless constructor");
            }
        }

        public async Task<bool> LoginUserAsync(UserAuthDTO _user)
        {
            var user = await _userManager.FindByNameAsync(_user.Username);
            if (user != null)
            {
                var result = await _userManager.CheckPasswordAsync(user, _user.Password);
                if (result)
                {
                    SettingsManager.SaveUser(new UserDTO { UserID = user.Id, Username = user.UserName! });
                    return true;
                }
                else
                    return false;
            }
            throw new UserNotFoundException($"User not found with username: {_user.Username}");
        }

        public async Task<bool> DeleteAsync(int userId)
        {
            var user = _context.Users.Find(userId)!;

            if (user == null)
            {
                throw new UserNotFoundException($"User not found with id:{userId}");
            }

            await _userManager.DeleteAsync(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public UserDTO? GetLoggedInUser()
        {
            return SettingsManager.GetLoggedInUser();
        }

        public bool IsUserLogin()
        {
            return SettingsManager.IsUserLoggedIn();
        }
    }
}