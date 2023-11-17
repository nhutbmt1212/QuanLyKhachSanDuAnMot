using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class LoaiPhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LoaiPhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult TrangChuLoaiPhong()
        {
            var listLoaiPhong = _db.LoaiPhong.ToList();
            return View(listLoaiPhong);
        }
    }
}
