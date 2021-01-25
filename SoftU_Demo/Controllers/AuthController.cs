using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace SoftU_WebApp.Controllers
{
    public class AuthController : Controller
    {
        private ApplicationDbContext _db;
        public AuthController(ApplicationDbContext dbContext)
        {
            _db = dbContext;

        }
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            //Console.WriteLine(_db.Users.ToList().Count());
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}