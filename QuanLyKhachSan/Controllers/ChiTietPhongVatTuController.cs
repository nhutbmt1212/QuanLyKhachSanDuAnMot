using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class ChiTietPhongVatTuController : Controller
    {
        public readonly ApplicationDbContext _db;
        public ChiTietPhongVatTuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var qr_PhongVatTu = _db.ChiTietPhongVatTu.Where(s=>s.TinhTrang != "Đã xóa").ToList();
            return View(qr_PhongVatTu);
        }
    }
}
