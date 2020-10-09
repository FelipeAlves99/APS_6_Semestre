using System;
using System.Windows.Forms;
using APS_6.Domain.Interfaces.Repository;
using APS_6.Domain.Interfaces.Services;
using APS_6.Domain.Services;
using APS_6.Infra.Data.Sql.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace APS.ClientCore
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<Form1>();
                    services.AddScoped<IUserService, UserService>();
                    services.AddScoped<IUserRepository, UserRepository>();
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<Form1>();
                    Application.Run(form1);
                }
                catch (Exception ex)
                {
                    Console.Write("failed: " + ex.Message);
                }
            }
        }
    }
}
