using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
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