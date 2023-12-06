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
        private static Random random = new Random();

        public VatTuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult DanhSachVatTu()
        {
            var listVatTu = _db.VatTu.ToList();
            return View(listVatTu);
        }
        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.VatTu.Any(d => d.MaVatTu == $"VT{randomString}"));

            return $"VT{randomString}";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemVatTu(VatTu vt)
        {
            if (_db.VatTu.Any(d => d.MaVatTu == vt.MaVatTu))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm vật tư thất bại Mã vật tư bị trùng";
                return RedirectToAction("DanhSachVatTu", "VatTu");
            }
            vt.MaVatTu = GenerateRandomCode();
                vt.NgayThem = DateTime.Now;
                _db.VatTu.Add(vt);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Thêm vật tư thành công";
            return RedirectToAction("DanhSachVatTu", "VatTu");
  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult SuaVatTu(VatTu vt)
        {

                _db.VatTu.Update(vt);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Sửa vật tư thành công";
            return RedirectToAction("DanhSachVatTu", "VatTu");

        }

        public async Task<IActionResult> DeleteVatTu(string id)
        {
            var vt = await _db.VatTu.FindAsync(id);
            if (vt != null)
            {
                _db.VatTu.Remove(vt);
                await _db.SaveChangesAsync();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa vật tư thành công";
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("DanhSachVatTu", "VatTu");
        }
    }
}
