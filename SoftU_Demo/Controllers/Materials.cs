using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class MaterialsController : Controller
    {
        public IActionResult Materials()
        {
            return View();
        }
    }
}