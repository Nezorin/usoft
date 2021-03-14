using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class TodayController : Controller
    {
        public IActionResult Today()
        {
            return View();
        }
    }
}