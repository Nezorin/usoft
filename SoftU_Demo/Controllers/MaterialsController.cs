using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize]
    public class MaterialsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _applicationEnvironment;
        public MaterialsController(ApplicationDbContext context, IWebHostEnvironment applicationEnvironment, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _applicationEnvironment = applicationEnvironment;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Materials()
        {
            if (User.IsInRole("Teacher"))
            {
                return View(_context.Files.ToList()); // ���� �����.������
            }
            var user = await _userManager.GetUserAsync(User);
            return View(_context.Files.Where(f => f.Course == user.Course && f.Group == user.Group).ToList());

        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile, string name, string course, string group)
        {
            if (uploadedFile != null)
            {
                // ���� � ����� Files
                string path = "/Files/" + uploadedFile.FileName;
                // ��������� ���� � ����� Files � �������� wwwroot
                using (var fileStream = new FileStream(_applicationEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { FileName = uploadedFile.FileName, Name = name, Path = path, TimeAdded = DateTime.Now, 
                    Course = course, Group = group };
                _context.Files.Add(file);
                _context.SaveChanges();
            }

            return RedirectToAction("Materials");
        }
        [HttpGet]
        public IActionResult GetFile(string path, string fileName)
        {
            // ���� � �����
            string file_path = Path.Combine(_applicationEnvironment.WebRootPath, path.Remove(0, 1));
            // ��� ����� - content-type ���� ����� octet
            string file_type = "application/octet-stream";
            // ��� ����� - �������������
            string file_name = fileName;
            return PhysicalFile(file_path, file_type, file_name);
        }
    }
}