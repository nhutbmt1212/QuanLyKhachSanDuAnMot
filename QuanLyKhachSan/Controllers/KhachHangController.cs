using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class KhachHangController : Controller
    {
        private readonly ApplicationDbContext _db;
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

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("DanhSachKhachHang", "KhachHang");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemKhachHang(KhachHang kh)
        { 
            
            kh.TinhTrang = "Đang hoạt động";
            kh.NgayDangKy = DateTime.Now;
        
              
                _db.KhachHang.Add(kh);
                _db.SaveChanges();
       

            return RedirectToAction("DanhSachKhachHang", "KhachHang");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaKhachHang(KhachHang kh)
        {
           //còn lỗi ngày đăng ký chưa lấy từ đb
                _db.KhachHang.Update(kh);
               _db.SaveChanges();
            

            return RedirectToAction("DanhSachKhachHang", "KhachHang");

        }
    }
}
