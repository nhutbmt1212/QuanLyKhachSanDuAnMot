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

        public IActionResult XoaDichVu(string id)
        {
            var qr_MaDichVu = _db.DichVu.Find(id);
            if (qr_MaDichVu != null)
            {
                _db.DichVu.Remove(qr_MaDichVu);
                _db.SaveChanges();

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("DanhSachDichVu", "DichVu");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemDichVu(DichVu dv)
        {
            dv.TinhTrang = "Còn hàng";
                _db.DichVu.Add(dv);
                _db.SaveChanges();
            

            return RedirectToAction("DanhSachDichVu", "DichVu");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaDichVu(DichVu dv)
        {
            
                _db.DichVu.Update(dv);
                _db.SaveChanges();
            

            return RedirectToAction("DanhSachDichVu", "DichVu");

        }
    }
}
