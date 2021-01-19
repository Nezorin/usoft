using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Homework()
        {
            return View();
        }
    }
}