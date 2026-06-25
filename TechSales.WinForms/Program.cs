using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using TechSales.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace TechSales.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            System.Windows.Forms.Application.EnableVisualStyles();

            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            services.AddSingleton<IConfiguration>(config);

            services.AddDbContext<TechSalesDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            var provider = services.BuildServiceProvider();

            System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}