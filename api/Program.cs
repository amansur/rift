using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using rift.Data;

namespace rift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            
            // using(var scope = host.Services.CreateScope())
            // {
            //     var services = scope.ServiceProvider;
            //     try 
            //     {
            //         var context = services.GetRequiredService<ApiContext>();
            //         context.Database.EnsureCreated();
            //         context.Database.Migrate();
            //     }
            //     catch(Exception)
            //     {
            //         //
            //     }
            // }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:4000")
                .UseStartup<Startup>()
                .Build();
    }
}
