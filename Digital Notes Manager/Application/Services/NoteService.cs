using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Application.Events;
using Digital_Notes_Manager.Application.Helpers;
using Digital_Notes_Manager.Application.Interfaces;
using Digital_Notes_Manager.Domain.Exceptions;
using Digital_Notes_Manager.Domain.Models;
using Digital_Notes_Manager.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Digital_Notes_Manager.Application.Services
{
    public class NoteService : INoteService
    {
        private readonly ApplicationDbContext _context;

        private readonly UserService _userService;

        private static readonly Expression<Func<Note, NoteDto>> NoteToDto = n => MapHelper.NoteToDto(n);

        public event EventHandler? NoteChanged;

        public event EventHandler<ReminderEventArgs>? ReminderTrigged;

        public NoteService(ApplicationDbContext context, UserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public void OnNoteChanged()
        {
            NoteChanged?.Invoke(this, EventArgs.Empty);
        }

        public void OnReminderTrigged(ReminderEventArgs eventArgs)
        {
            ReminderTrigged?.Invoke(this, eventArgs);
        }

        public async Task AddNoteAsync(NoteDto _note)
        {
            var note = MapHelper.DtoToNote(_note);
            note.UserID = _userService.GetLoggedInUser()!.UserID;

            await _context.Notes.AddAsync(note);
            await _context.SaveChangesAsync();

            OnNoteChanged();
        }

        public async Task<bool> DeleteAsync(int noteId)
        {
            var note = await _context.Notes.FindAsync(noteId)
                ?? throw new NoteNotFoundException($"Note not found with id:{noteId}");

            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();

            OnNoteChanged();
            return true;
        }

        public async Task<bool> UpdateAsync(NoteDto _note)
        {
            var note = await _context.Notes.FindAsync(_note.NoteID)
                ?? throw new NoteNotFoundException($"Note not found with id:{_note.NoteID}");

            note.Title = _note.Title;
            note.Content = _note.Content;
            note.Category = _note.Category;
            note.ReminderDate = _note.ReminderDate;

            await _context.SaveChangesAsync();

            OnNoteChanged();
            return true;
        }

        public Task<List<NoteDto>> GetAllNotes()
        {
            return GetNotesAsync();
        }

        public async Task<NoteDto> GetNoteByIdAsync(int noteId)
        {
            var note = await _context.Notes
                .Where(n => n.NoteID == noteId)
                .Select(n => MapHelper.NoteToDto(n))
                .FirstOrDefaultAsync();

            return note ?? throw new NoteNotFoundException($"Note not found with ID: {noteId}");
        }

        public Task<List<NoteDto>> SearchByCategory(string categoty)
        {
            return GetNotesAsync(n => n.Category == categoty);
        }

        public Task<List<NoteDto>> SearchByContent(string content)
        {
            return GetNotesAsync(n => n.Content.Contains(content));
        }

        public Task<string> LoadNoteContentAsync(string filePath)
        {
            return File.ReadAllTextAsync(filePath);
        }

        public Task SaveNoteContentAsync(string filePath, string content)
        {
            return File.WriteAllTextAsync(filePath, content);
        }

        private Task<List<NoteDto>> GetNotesAsync(Expression<Func<Note, bool>>? predicate = null)
        {
            var userId = _userService.GetLoggedInUser()!.UserID;

            return _context.Notes
                .Where(predicate ?? (n => true))
                .Where(n => n.UserID == userId)
                .Select(NoteToDto)
                .ToListAsync();
        }

        public Task<List<NoteDto>> SearchByTitle(string title)
        {
            return GetNotesAsync(n => n.Title.Contains(title));
        }

        public async Task<List<NoteDto>> GetNotesWithReminders()
        {
            return await GetNotesAsync(n => n.ReminderDate != null && n.ReminderDate <= DateTime.Now);
        }
    }
}
