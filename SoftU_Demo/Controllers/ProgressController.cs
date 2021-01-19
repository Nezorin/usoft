using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class ProgressController : Controller
    {
        public IActionResult Progress()
        {
            return View();
        }
    }
}