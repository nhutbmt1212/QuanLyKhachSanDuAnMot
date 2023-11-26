using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;
using System;
using System.Threading.Tasks;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemVatTu(VatTu vt)
        {
            
                vt.NgayThem = DateTime.Now;
                _db.VatTu.Add(vt);
                _db.SaveChanges();
                return RedirectToAction("DanhSachVatTu", "VatTu");
  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult SuaVatTu(VatTu vt)
        {

                _db.VatTu.Update(vt);
                _db.SaveChanges();
                return RedirectToAction("DanhSachVatTu", "VatTu");

        }

        public async Task<IActionResult> DeleteVatTu(string id)
        {
            var vt = await _db.VatTu.FindAsync(id);
            if (vt != null)
            {
                _db.VatTu.Remove(vt);
                await _db.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("DanhSachVatTu", "VatTu");
        }
    }
}
