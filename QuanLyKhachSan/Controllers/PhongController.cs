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
    }
}
