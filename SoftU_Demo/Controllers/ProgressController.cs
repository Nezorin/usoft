using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class ProgressController : Controller
    {
        public IActionResult Progress()
        {
            return View();
        }
    }
}