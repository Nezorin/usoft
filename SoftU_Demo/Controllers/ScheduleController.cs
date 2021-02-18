using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class ScheduleController : Controller
    {
        [Authorize]
        public IActionResult Schedule()
        {
            return View();
        }
    }
}