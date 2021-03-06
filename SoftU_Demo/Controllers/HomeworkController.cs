using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeworkController : Controller
    {
        public IActionResult Homework()
        {
            return View();
        }
    }
}