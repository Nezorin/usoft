using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult FullCalendar()
        {
            return View();
        }
    }
}