using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PlanetWeights
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        [ExcludeFromCodeCoverage]
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        [ExcludeFromCodeCoverage]
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
