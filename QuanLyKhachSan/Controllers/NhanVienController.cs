using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;
using System.Drawing;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace QuanLyKhachSan.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly ApplicationDbContext _db;
        public NhanVienController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult TrangChuNhanVien()
        {
            var listNhanVien = _db.NhanVien.ToList();
            return View(listNhanVien);
        }
        [HttpPost]
        public IActionResult ThemNhanVien(NhanVien nv, [FromServices] IWebHostEnvironment hostingEnvironment)
        {
            if (nv.AnhNhanVien != null && nv.AnhNhanVien.Length > 0)
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "UploadImage");
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                var uniqueFileName = Guid.NewGuid().ToString() + "_" + nv.AnhNhanVien.FileName;
                var filePath = Path.Combine(uploadFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    nv.AnhNhanVien.CopyTo(stream);
                }

                // Save the relative file path to the database
                nv.AnhNhanVienBase64 = Path.Combine("UploadImage", uniqueFileName);

                _db.NhanVien.Add(nv);
                _db.SaveChanges();
            }

            return RedirectToAction("TrangChuNhanVien", "NhanVien");
        }
    }
}
