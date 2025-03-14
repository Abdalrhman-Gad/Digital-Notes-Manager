using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Events;

namespace Digital_Notes_Manager.Application.Interfaces
{
    public interface INoteService : ICrudService<NoteDto>
    {
        event EventHandler? NoteChanged;

        event EventHandler<ReminderEventArgs>? ReminderTrigged;

        void OnNoteChanged();

        void OnReminderTrigged(ReminderEventArgs eventArgs);

        Task AddNoteAsync(NoteDto _note);

        Task<List<NoteDto>> GetAllNotes();

        Task<NoteDto> GetNoteByIdAsync(int noteId);

        Task<List<NoteDto>> GetNotesWithReminders();

        Task SaveNoteContentAsync(string filePath, string content);

        Task<string> LoadNoteContentAsync(string filePath);

        Task<List<NoteDto>> SearchByContent(string content);

        Task<List<NoteDto>> SearchByCategory(string categoty);

        Task<List<NoteDto>> SearchByTitle(string categoty);
    }
}
