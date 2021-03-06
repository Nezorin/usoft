using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebApp.Services;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            //using (var scope = host.Services.CreateScope())
            //{
            //    var serviceProvider = scope.ServiceProvider;
            //    try
            //    {
            //        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //        UserAndRoleInitializerService.SeedData(roleManager);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            host.Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}
