﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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