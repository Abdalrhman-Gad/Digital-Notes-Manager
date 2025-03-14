using Digital_Notes_Manager.Application.Services;
using Digital_Notes_Manager.Domain.Models;
using Digital_Notes_Manager.Infrastructure;
using Digital_Notes_Manager.Presentation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Digital_Notes_Manager
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureServices();

            var loginForm = serviceProvider.GetRequiredService<LogIn>();
            var mainForm = serviceProvider.GetRequiredService<MainForm>();


            var userService = serviceProvider.GetRequiredService<UserService>();

            Form form = userService.GetLoggedInUser() == null ? loginForm : mainForm;

            System.Windows.Forms.Application.Run(form);
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            var configuration = LoadConfiguration();
            string connectionString = configuration.GetConnectionString("DefaultConnection")!;

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;

                options.SignIn.RequireConfirmedAccount = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddLogging();

            services.AddSingleton<UserService>();
            services.AddSingleton<NoteService>();

            services.AddSingleton<IHostedService, ReminderBackgroundService>();

            services.AddTransient<LogIn>();
            services.AddTransient<Register>();
            services.AddTransient<MainForm>();
            services.AddTransient<NoteDetailsForm>();
            services.AddTransient<NoteEditorForm>();

            return services.BuildServiceProvider();
        }

        private static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
