using Digital_Notes_Manager.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Interfaces
{
    public interface INoteService : ICrudService<NoteDto>
    {
        Task AddNoteAsync(NoteDto _note);

        Task<List<NoteDto>> GetAllNotes();

        Task<NoteDto> GetNoteByIdAsync(int noteId);

        Task SaveNoteContentAsync(string filePath, string content);

        Task<string> LoadNoteContentAsync(string filePath);

        Task<List<NoteDto>> SearchByContent(string content);

        Task<List<NoteDto>> SearchByCategory(string categoty);

        Task<List<NoteDto>> SearchByTitle(string categoty);
    }
}
