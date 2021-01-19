using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class FeetbackController : Controller
    {
        public IActionResult Feetback()
        {
            return View();
        }
    }
}