using Microsoft.AspNetCore.Identity;

namespace WebApp.Services
{
    public class UserAndRoleInitializerService //only roles yet
    {
        public static void SeedData(RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
        }
        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole("User");
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole("Admin");
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
