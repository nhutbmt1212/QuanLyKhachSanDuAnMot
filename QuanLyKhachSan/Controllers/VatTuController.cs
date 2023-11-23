using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class VatTuController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VatTuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult DanhSachVatTu()
        {
            var listVatTu = _db.VatTu.ToList();
            return View(listVatTu);
        }
    }
}
