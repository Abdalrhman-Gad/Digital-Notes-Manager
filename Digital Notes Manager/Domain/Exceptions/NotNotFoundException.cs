using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Domain.Exceptions
{
    public class NotNotFoundException : Exception
    {
        public NotNotFoundException(string message) : base(message)
        {
        }
    }
}
