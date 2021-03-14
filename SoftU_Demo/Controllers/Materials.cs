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
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
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
            // Путь к файлу
            string file_path = Path.Combine(_applicationEnvironment.WebRootPath, path.Remove(0, 1));
            // Тип файла - content-type пока любой octet
            string file_type = "application/octet-stream";
            // Имя файла - необязательно
            string file_name = name;
            return PhysicalFile(file_path, file_type, file_name);
        }
    }
}