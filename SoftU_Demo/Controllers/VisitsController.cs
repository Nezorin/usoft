using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class VisitsController : Controller
    {
        public IActionResult Visits()
        {
            return View();
        }
    }
}