using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; } //TODO не каждый юсер состоит в группе
        public string Course { get; set; } //TODO не каждый юсер состоит в группе
    }
}