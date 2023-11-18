using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class DichVuController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DichVuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult DanhSachDichVu()
        {
            var listDichVu = _db.DichVu.ToList();
            return View(listDichVu);
        }
    }
}
