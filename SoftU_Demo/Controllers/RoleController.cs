using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<ApplicationUser> _roleManager;
        public RoleController(RoleManager<ApplicationUser> roleManager)
        {
            _roleManager = roleManager;
        }
        //[HttpPost]
        //public async Task<IActionResult> Create([Required] string name)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
        //        if (result.Succeeded)
        //            return RedirectToAction("Index");
        //        else
        //            Errors(result);
        //    }
        //    return View(name);
        //}
    }
}
