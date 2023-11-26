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
            var loaiPhong = _db.Phong
                .Where(p => p.MaPhong == maPhong)
                .Select(p => p.LoaiPhong) 
                .FirstOrDefault();

            return Json(loaiPhong); 
        }
        [HttpGet]
        public async Task<IActionResult> SlideAnhPhong(string maPhong)
        {
            var phong = await _db.Phong.Include(p => p.ImageLinks).FirstOrDefaultAsync(s => s.MaPhong == maPhong);
            if (phong == null)
            {
                return Json(null);

            }
            return Json(phong.ImageLinks.Select(s => s.Url));
        }
    }
}
