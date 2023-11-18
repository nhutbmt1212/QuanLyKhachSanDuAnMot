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
        public IActionResult XoaLoaiPhong(string id)
        {
            var qr_MaLoaiPhong = _db.LoaiPhong.Find(id);
            if (qr_MaLoaiPhong != null)
            {
                _db.LoaiPhong.Remove(qr_MaLoaiPhong);
                _db.SaveChanges();

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("TrangChuLoaiPhong", "LoaiPhong");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemLoaiPhong(LoaiPhong loaiphong)
        {
            if (ModelState.IsValid)
            {
                _db.LoaiPhong.Add(loaiphong);
                _db.SaveChanges();
            }

            return RedirectToAction("TrangChuLoaiPhong", "LoaiPhong");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaLoaiPhong(LoaiPhong loaiphong)
        {
            if (ModelState.IsValid)
            {
                _db.LoaiPhong.Update(loaiphong);
                _db.SaveChanges();
            }

            return RedirectToAction("TrangChuLoaiPhong", "LoaiPhong");

        }
    }
}
