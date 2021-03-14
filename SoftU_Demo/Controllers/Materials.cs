using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _applicationEnvironment;
        public IActionResult Materials()
        {
            return View(_context.Files.ToList());
        }
        public MaterialsController(ApplicationDbContext context, IWebHostEnvironment applicationEnvironment)
        {
            _context = context;
            _applicationEnvironment = applicationEnvironment;
        }
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
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
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path, TimeAdded = DateTime.Now };
                _context.Files.Add(file);
                _context.SaveChanges();
            }

            return RedirectToAction("Materials");
        }
        [HttpGet]
        public IActionResult GetFile(string path, string name)
        {
            // ���� � �����
            string file_path = Path.Combine(_applicationEnvironment.WebRootPath, path.Remove(0, 1));
            // ��� ����� - content-type ���� ����� octet
            string file_type = "application/octet-stream";
            // ��� ����� - �������������
            string file_name = name;
            return PhysicalFile(file_path, file_type, file_name);
        }
    }
}