using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;
using System.Drawing;

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
        public IActionResult ThemNhanVien(string manhanvien,string tennhanvien,string email, string diachi, string sodienthoai, string cccd, string gioitinh, string chucvu, string ngaysinh, DateTime ngaydangky, DateTime ngayvaolam,IFormFile anhnhanvien)
        {
            return RedirectToAction("Index","NhanVien");
        }
    }
}
