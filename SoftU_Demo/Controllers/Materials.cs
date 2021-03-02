using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    [Authorize]
    public class MaterialsController : Controller
    {
        public IActionResult Materials()
        {
            return View();
        }
    }
}