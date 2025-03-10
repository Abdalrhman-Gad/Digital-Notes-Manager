using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Domain.Exceptions
{
    public class NoteNotFoundException : Exception
    {
        public NoteNotFoundException(string message) : base(message)
        {
        }
    }
}
