using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Services
{
    public class NoteService : INoteService
    {
        public Task AddAsync(NoteDto item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NoteDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(NoteDto item)
        {
            throw new NotImplementedException();
        }
    }
}
