using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public ScheduleController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public IActionResult Schedule()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var user = await _userManager.GetUserAsync(User);
            var events = _dbContext.ScheduleItems.Where(i => i.Group == user.Group && i.Course == user.Course).Select(e => new
            {
                id = e.Id,
                title = e.Discipline,
                description = e.Description,
                start = e.Start,
                end = e.End,
                backgroundColor = "#a389d4",
                textColor = "#fff"
            }).ToList();
            return new JsonResult(events);
        }
    }
}