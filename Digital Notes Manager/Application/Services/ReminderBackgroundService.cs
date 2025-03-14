using Digital_Notes_Manager.Application.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Digital_Notes_Manager.Application.Services
{
    public class ReminderBackgroundService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly NoteService _noteService;

        public ReminderBackgroundService(IServiceProvider serviceProvider,NoteService noteService)
        {
            _serviceProvider = serviceProvider;
            _noteService = noteService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var now = DateTime.Now;

                        var notesWithReminders = await _noteService.GetNotesWithReminders();

                        foreach (var note in notesWithReminders)
                        {
                            _noteService.OnReminderTrigged(new ReminderEventArgs(note.Title));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking reminders: {ex.Message}");
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
