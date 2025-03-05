using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Domain.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(maximumLength:50,MinimumLength =5)]
        public string Username { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 8)]
        public string Password { get; set; }

        public List<Note> Notes { get; set; } = new();
    }
}
