using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class PhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult TrangChuPhong()
        {
            var listPhong = _db.Phong.Include(p => p.LoaiPhong).ToList();
            ViewBag.DanhSachPhong = listPhong;
            return View(listPhong);

        }
        [HttpPost]
        public IActionResult ThemPhong(Phong phong, IFormFileCollection files)
        {
            if (ModelState.IsValid)
            {
                // Lưu thông tin phòng vào cơ sở dữ liệu
                _db.Phong.Add(phong);
                _db.SaveChanges();

                // Lưu ảnh vào thư mục Upload với tên trùng với mã phòng
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine("Upload", $"{phong.MaPhong}_{file.FileName}");

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }
                    }
                }

                return RedirectToAction("TrangChuPhong");
            }

            // Nếu ModelState không hợp lệ, quay lại trang thêm phòng với thông tin đã nhập
            return View(phong);
        }
    }
}
