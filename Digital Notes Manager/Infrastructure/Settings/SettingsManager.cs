using Digital_Notes_Manager.Application.DTOs;
using System;

namespace Digital_Notes_Manager.Infrastructure.Settings
{
    public static class SettingsManager
    {
        public static void SaveUser(UserDTO user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            Properties.Settings.Default.UserId = user.UserID;
            Properties.Settings.Default.Username = user.Username;
            Properties.Settings.Default.Save();
        }

        public static void ClearUser()
        {
            Properties.Settings.Default.UserId = string.Empty;
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.Save();
        }

        public static UserDTO? GetLoggedInUser()
        {
            if (!IsUserLoggedIn())
                return null;

            return new UserDTO
            {
                UserID = Properties.Settings.Default.UserId,
                Username = Properties.Settings.Default.Username,
            };
        }

        public static bool IsUserLoggedIn()
        {
            return !string.IsNullOrWhiteSpace(Properties.Settings.Default.UserId) &&
                   !string.IsNullOrWhiteSpace(Properties.Settings.Default.Username);
        }
    }
}