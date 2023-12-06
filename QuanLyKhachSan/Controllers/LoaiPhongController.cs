using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class LoaiPhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();
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
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa loại phòng thành công";

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("TrangChuLoaiPhong", "LoaiPhong");
        }

        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.LoaiPhong.Any(d => d.MaLoaiPhong == $"LP{randomString}"));

            return $"LP{randomString}";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemLoaiPhong(LoaiPhong loaiphong)
        {       
            if (_db.LoaiPhong.Any(d => d.MaLoaiPhong == loaiphong.MaLoaiPhong))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm loại phòng thất bại Mã loại phòng bị trùng";
                return RedirectToAction("TrangChuLoaiPhong", "LoaiPhong");
            }

            loaiphong.MaLoaiPhong = GenerateRandomCode();
            _db.LoaiPhong.Add(loaiphong);
                _db.SaveChanges();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Thêm loại phòng thành công";

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
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Sửa loại phòng thành công";
            }

            return RedirectToAction("TrangChuLoaiPhong", "LoaiPhong");

        }
    }
}
