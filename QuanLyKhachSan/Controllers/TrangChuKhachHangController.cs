using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;


namespace QuanLyKhachSan.Controllers
{
    public class TrangChuKhachHangController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TrangChuKhachHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listPhong = _db.Phong.Include(p => p.ImageLinks).ToList();
            ViewBag.DanhSachPhong = listPhong;
            var listLoaiPhong = _db.LoaiPhong.ToList();
            ViewBag.DanhSachLoaiPhong = listLoaiPhong;
            return View(listPhong);
        }
        [HttpGet]
   
        public IActionResult LayLoaiPhong(string maPhong)
        {
            // Assuming you have a relationship between Phong and LoaiPhong using MaLoaiPhong
            var loaiPhong = _db.Phong
                .Where(p => p.MaPhong == maPhong)
                .Select(p => p.LoaiPhong) // Assuming you have a navigation property LoaiPhong in your Phong model
                .FirstOrDefault();

            return Json(loaiPhong); // Assuming you want to return JSON data
        }
        [HttpGet]
        public async Task<IActionResult> SlideAnhPhong (string maPhong)
        {
            var phong = await _db.Phong.Include(p => p.ImageLinks).FirstOrDefaultAsync(s => s.MaPhong == maPhong);
            if(phong == null)
            {
                return Json(null);

            }
            return Json(phong.ImageLinks.Select(s => s.Url));
        }
    }
}
