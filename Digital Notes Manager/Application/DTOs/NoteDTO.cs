﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.DTOs
{
    public class NoteDto
    {
        public int NoteID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ReminderDate { get; set; }
    }
}
