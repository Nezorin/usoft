using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class VisitsController : Controller
    {
        public IActionResult Visits()
        {
            return View();
        }
    }
}