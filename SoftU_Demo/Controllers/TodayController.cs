using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class TodayController : Controller
    {
        public IActionResult Today()
        {
            return View();
        }
    }
}