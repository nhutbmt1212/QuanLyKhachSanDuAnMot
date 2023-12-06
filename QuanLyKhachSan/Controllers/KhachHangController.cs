using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class KhachHangController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();
        public KhachHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult DanhSachKhachHang()
        {
            var listKhachHang = _db.KhachHang.ToList();
            return View(listKhachHang);
        }
        public IActionResult XoaKhachHang(string id)
        {
            var qr_MaKh = _db.KhachHang.Find(id);
            if (qr_MaKh != null)
            {
                _db.KhachHang.Remove(qr_MaKh);
                _db.SaveChanges();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa khách hàng thành công";
            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("DanhSachKhachHang", "KhachHang");
        }

        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.KhachHang.Any(d => d.MaKhachHang == $"KH{randomString}"));

            return $"KH{randomString}";
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemKhachHang(KhachHang kh)
        {
            if (_db.KhachHang.Any(d => d.MaKhachHang == kh.MaKhachHang))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm khách hàng thất bại Mã khách hàng bị trùng";
                return RedirectToAction("DanhSachKhachHang", "KhachHang");
            }
            kh.MaKhachHang = GenerateRandomCode();
            kh.TinhTrang = "Đang hoạt động";
            kh.NgayDangKy = DateTime.Now;
        
              
                _db.KhachHang.Add(kh);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Thêm khách hàng thành công";

            return RedirectToAction("DanhSachKhachHang", "KhachHang");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaKhachHang(KhachHang kh)
        {
           //còn lỗi ngày đăng ký chưa lấy từ đb
                _db.KhachHang.Update(kh);
               _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Sửa khách hàng thành công";

            return RedirectToAction("DanhSachKhachHang", "KhachHang");

        }
    }
}
