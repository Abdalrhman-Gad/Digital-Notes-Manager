using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Services
{
    public class UserService : IUserService
    {
        public Task AddAsync(UserDTO item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
