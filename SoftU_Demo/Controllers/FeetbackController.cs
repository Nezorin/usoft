using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class FeetbackController : Controller
    {
        public IActionResult Feetback()
        {
            return View();
        }
    }
}