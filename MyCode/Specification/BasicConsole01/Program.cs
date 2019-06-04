using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace BasicConsole01
{
    internal class Program
    {
        public static void Main()
        {
            using IHost host = Host.CreateDefaultBuilder()
                .ConfigureServices(ConfigureServices)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                })
                .Build();

            UseContainer(host.Services);
        }

        private static IConfiguration Configuration { get; set; }

        private static void ConfigureServices(IServiceCollection services)
        {
            var serviceDescriptor = services.First(x => x.ServiceType == typeof(IConfiguration));
            Configuration = serviceDescriptor.ImplementationInstance as IConfiguration;
            // We can not use IConfiguration

            services.AddSingleton<MainConsole>();
        }

        private static void UseContainer(IServiceProvider serviceProvider)
        {
            serviceProvider.UseNLog();
            var mainConsole = serviceProvider.GetRequiredService<MainConsole>();
            mainConsole.DoWork();
        }
    }
}