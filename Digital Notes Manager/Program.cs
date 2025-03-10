using Digital_Notes_Manager.Domain.Models;
using Digital_Notes_Manager.Infrastructure;
using Digital_Notes_Manager.Presentation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Windows.Forms;

namespace Digital_Notes_Manager
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureServices();

            // Resolve the LogIn form from DI container
            var loginForm = serviceProvider.GetRequiredService<LogIn>();

            // Run the application
            System.Windows.Forms.Application.Run(loginForm);
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Load configuration from appsettings.json
            var configuration = LoadConfiguration();
            string connectionString = configuration.GetConnectionString("DefaultConnection")!;

            // Register logging
            services.AddLogging(); // Ensure logging is available

            // Register DbContext with SQL Server configuration
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Register Identity with custom User model (User class)
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

            services.AddTransient<LogIn>();
            services.AddTransient<Register>();

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
