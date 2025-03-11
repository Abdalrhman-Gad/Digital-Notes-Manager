using Digital_Notes_Manager.Application.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Interfaces
{
    public interface IUserService : ICrudService<UserAuthDTO>
    {
        Task<IdentityResult> RegisterUserAsync(UserAuthDTO item);

        Task<bool> LoginUserAsync(UserAuthDTO _user);

        UserDTO? GetLoggedInUser();

        void UserLogout();

        bool IsUserLogin();
    }
}
