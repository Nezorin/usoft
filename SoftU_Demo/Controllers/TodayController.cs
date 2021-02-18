using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    [Authorize]
    public class TodayController : Controller
    {
        [Authorize]
        public IActionResult Today()
        {
            return View();
        }
    }
}