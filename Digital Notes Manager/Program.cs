using System.Configuration;
using Digital_Notes_Manager.Domain.Models;
using Digital_Notes_Manager.Infrastructure;
using Digital_Notes_Manager.Presentation;
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

            //var serviceProvider = ConfigureServices();

            System.Windows.Forms.Application.Run(new MainForm());
        }

        //private static ServiceProvider ConfigureServices()
        //{
        //    var services = new ServiceCollection();

        //    services.AddDbContext<DNMContext>
        //        (options => options.UseSqlServer("DefaultConnection"));


        //    //services.AddSingleton<User>();

        //    return services.BuildServiceProvider();
        //}
    }
}