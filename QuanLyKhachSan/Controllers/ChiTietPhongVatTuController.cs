using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    [Authorize]
    public class ChiTietPhongVatTuController : Controller
    {
        public readonly ApplicationDbContext _db;
        public ChiTietPhongVatTuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var qr_PhongVatTu = _db.ChiTietPhongVatTu.Where(s=>s.TinhTrang != "Đã xóa").ToList();
            return View(qr_PhongVatTu);
        }
        [HttpPost]
        public IActionResult ThemVatTuVaoPhong(string MaPhong, string MaVatTu, string SoLuong)
         {
            var existingChiTietPhongVatTu = _db.ChiTietPhongVatTu
                .FirstOrDefault(ct => ct.MaPhong == MaPhong && ct.MaVatTu == MaVatTu);

            if (existingChiTietPhongVatTu != null)
            {
                existingChiTietPhongVatTu.SoLuong += int.Parse(SoLuong);
            }
            else
            {
                 var newChiTietPhongVatTu = new ChiTietPhongVatTu
                {
                    MaPhong = MaPhong,
                    MaVatTu = MaVatTu,
                    SoLuong = int.Parse(SoLuong),
                    TinhTrang ="Đang hoạt động",
                };

                _db.ChiTietPhongVatTu.Add(newChiTietPhongVatTu);
            }

            _db.SaveChanges();
                
            // Chuyển hướng về trang Index của ChiTietPhongVatTu
            return RedirectToAction("Index", "ChiTietPhongVatTu");
        }
        [HttpPost]
        public IActionResult SuaPhongVatTu(string MaPhong, string MaVatTu, string SoLuong, string TinhTrang)
        {
            try
            {
                var chiTietPhongVatTu = _db.ChiTietPhongVatTu
                    .FirstOrDefault(ct => ct.MaPhong == MaPhong && ct.MaVatTu == MaVatTu);

                if (chiTietPhongVatTu != null)
                {
                    chiTietPhongVatTu.SoLuong = int.Parse(SoLuong);
                    chiTietPhongVatTu.TinhTrang = TinhTrang;

                    _db.SaveChanges();

                    return Json(new { success = true, message = "Cập nhật thành công." });
                }
                else
                {
                    return Json(new { success = false, message = "Không tìm thấy chi tiết phòng vật tư." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Đã xảy ra lỗi. Vui lòng thử lại." });
            }
        }
        [HttpPost]
        public IActionResult XoaPhongVatTu(string MaPhong, string MaVatTu)
        {
            try
            {
                var chiTietPhongVatTu = _db.ChiTietPhongVatTu
                    .FirstOrDefault(ct => ct.MaPhong == MaPhong && ct.MaVatTu == MaVatTu);

                if (chiTietPhongVatTu != null)
                {
                    // Thay đổi trạng thái thành đã xóa
                    chiTietPhongVatTu.TinhTrang = "Đã xóa";

                    // Lưu thay đổi vào cơ sở dữ liệu
                    _db.SaveChanges();

                    return Json(new { success = true, message = "Đã xóa thành công." });
                }
                else
                {
                    return Json(new { success = false, message = "Không tìm thấy chi tiết phòng vật tư." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Đã xảy ra lỗi. Vui lòng thử lại." });
            }
        }

    }
}
