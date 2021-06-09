using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace L03Order
{
    public class Program
    {
        public static void Main(string[] args)
        {
          var one =  CreateHostBuilder(args);
           var two = one.Build();
           two.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) //=>
            // Host.CreateDefaultBuilder(args)
            //     .ConfigureWebHostDefaults(webBuilder =>
            //     {
            //         webBuilder.UseStartup<Startup>();
            //     });
            {
                IHostBuilder one = Host.CreateDefaultBuilder(args);
                Action<IWebHostBuilder> d = webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                };
                IHostBuilder two = one.ConfigureWebHostDefaults(d);
                return two;
            }

    }
}
