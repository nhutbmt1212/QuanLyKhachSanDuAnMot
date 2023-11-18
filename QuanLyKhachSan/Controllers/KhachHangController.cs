using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly ApplicationDbContext _db;
        public KhachHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult DanhSachKhachHang()
        {
            var listKhachHang = _db.KhachHang.ToList();
            return View(listKhachHang);
        }
    }
}
