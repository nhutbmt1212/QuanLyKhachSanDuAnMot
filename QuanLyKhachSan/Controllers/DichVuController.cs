using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Cms;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class DichVuController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();
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
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa dịch vụ thành công";

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("DanhSachDichVu", "DichVu");
        }
        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.DichVu.Any(d => d.MaDichVu == $"DV{randomString}"));

            return $"DV{randomString}";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemDichVu(DichVu dv)
        {
            if (_db.DichVu.Any(d => d.MaDichVu == dv.MaDichVu))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm dịch vụ thất bại Mã dịch vụ bị trùng";
                return RedirectToAction("DanhSachDichVu", "DichVu");
            }
            dv.MaDichVu = GenerateRandomCode();
            dv.TinhTrang = "Còn hàng";
            dv.GioBatDauDichVu = TimeSpan.Parse(Request.Form["GioBatDauDichVu"]);
            dv.GioKetThucDichVu = TimeSpan.Parse(Request.Form["GioKetThucDichVu"]);
            _db.DichVu.Add(dv);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Thêm dịch vụ thành công";


            return RedirectToAction("DanhSachDichVu", "DichVu");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaDichVu(DichVu dv)
        {
            dv.GioBatDauDichVu = TimeSpan.Parse(Request.Form["GioBatDauDichVu"]);
            dv.GioKetThucDichVu = TimeSpan.Parse(Request.Form["GioKetThucDichVu"]);
            _db.DichVu.Update(dv);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Sửa dịch vụ thành công";

            return RedirectToAction("DanhSachDichVu", "DichVu");

        }
    }
}
