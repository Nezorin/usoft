using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services
{
    public class DataInitializeService //maybe add roles
    {
        public static async Task InitializeAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "adminPassword123";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("teacher") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("teacher"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                ApplicationUser admin = new ApplicationUser
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    FirstName = "Админ",
                    MiddleName = "Админович",
                    LastName = "Админинов",
                    Group = "1",
                    EmailConfirmed = true
                };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRolesAsync(admin, new string[] { "user", "teacher", "admin" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        System.Console.WriteLine(error.Description);
                        System.Console.WriteLine();
                    }
                }
            }
        }
    }
}
