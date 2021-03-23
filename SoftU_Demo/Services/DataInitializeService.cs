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
            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (await roleManager.FindByNameAsync("Teacher") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Teacher"));
            }
            if (await roleManager.FindByNameAsync("User") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
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
                    Course = "1",
                    EmailConfirmed = true
                };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRolesAsync(admin, new string[] { "User", "Teacher", "Admin" });
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
