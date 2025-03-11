using Digital_Notes_Manager.Application.DTOs;
using Digital_Notes_Manager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Helpers
{
    public static class MapHelper
    {
        public static NoteDto NoteToDto(Note note)
        {
            return new NoteDto
            {
                NoteID = note.NoteID,
                Title = note.Title,
                Content = note.Content,
                Category = note.Category,
                CreationDate = note.CreationDate,
                ReminderDate = note.ReminderDate,
            };
        }

        public static Note DtoToNote(NoteDto noteDto)
        {
            return new Note
            {
                NoteID = noteDto.NoteID,
                Title = noteDto.Title,
                Content = noteDto.Content,
                Category = noteDto.Category,
                CreationDate = noteDto.CreationDate,
                ReminderDate = noteDto.ReminderDate,
            };
        }
    }
}
