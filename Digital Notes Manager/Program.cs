using Digital_Notes_Manager.Domain.Models;
using Digital_Notes_Manager.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Digital_Notes_Manager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new DigitalNotesManagerForm());
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DNMContext>
                (options => options.UseSqlServer("DefaultConnection"));

            //services.AddSingleton<User>();

            return services.BuildServiceProvider();
        }
    }
}