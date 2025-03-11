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
        public Task<bool> DeleteAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(NoteDto item)
        {
            throw new NotImplementedException();
        }
    }
}
