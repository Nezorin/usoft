using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SoftU_WebApp.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Schedule()
        {
            return View();
        }
    }
}