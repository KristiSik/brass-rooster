using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace BrassRooster.WebApi
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }

            return 0;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
