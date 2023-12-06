using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class DatPhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DatPhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var qr_Phong = _db.Phong.ToList();
            return View(qr_Phong);
        }

        [HttpPost]
        public IActionResult GetLoaiPhong (string? id)
        {
            var qr_loaiPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == id);
            return Json(new { qr_loaiPhong });
        }
        [HttpGet]
        public IActionResult LayThongTinPhong(string MaPhong)
        {
            var qr_phong = _db.Phong.FirstOrDefault(s => s.MaPhong == MaPhong);
            var qr_LoaiPhong = _db.LoaiPhong.FirstOrDefault(s=>s.MaLoaiPhong == qr_phong.MaLoaiPhong);
            return Json(qr_LoaiPhong);
        }
    }
}
