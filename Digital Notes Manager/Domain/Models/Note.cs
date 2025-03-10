using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Domain.Models
{
    public class Note
    {
        public int NoteID { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string  Content { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 1)]
        public string Category { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime? ReminderDate { get; set; }

        public User User { get; set; }
    }
}
