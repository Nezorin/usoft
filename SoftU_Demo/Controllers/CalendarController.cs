using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class CalendarController : Controller
    {
        public IActionResult FullCalendar()
        {
            return View();
        }
    }
}