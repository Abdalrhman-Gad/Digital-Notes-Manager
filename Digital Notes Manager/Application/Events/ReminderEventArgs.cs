using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Notes_Manager.Application.Events
{
    public class ReminderEventArgs : EventArgs
    {
        public string Title { get; }

        public ReminderEventArgs(string title)
        {
            Title = title;
        }
    }
}