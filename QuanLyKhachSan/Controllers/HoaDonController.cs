using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class HoaDonController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HoaDonController(ApplicationDbContext db )
        {
            _db = db;
        }
        public IActionResult TrangChuHoaDon()
        {
            var qr_HoaDon = _db.HoaDon.ToList();
            return View(qr_HoaDon);
        }
        [HttpPost]
        public IActionResult LayThongTinHoaDon(string MaHoaDon)
        {
            var qr_HoaDon = _db.HoaDon.FirstOrDefault(s => s.MaHoaDon == MaHoaDon);
            var qr_DatPhong = _db.DatPhong.FirstOrDefault(s => s.MaDatPhong == qr_HoaDon.MaDatPhong);
            var qr_Phong = _db.Phong.FirstOrDefault(s => s.MaPhong == qr_DatPhong.MaPhong);
            var qr_LoaiPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == qr_Phong.MaLoaiPhong);
            var qr_KhachHang = _db.KhachHang.FirstOrDefault(s => s.MaKhachHang == qr_DatPhong.MaKhachHang);
            var qr_NhanVien = _db.NhanVien.FirstOrDefault(s => s.MaNhanVien == qr_DatPhong.MaNhanVien);
         

            return Json(new {qr_HoaDon, qr_DatPhong,qr_Phong,qr_LoaiPhong,qr_KhachHang,qr_NhanVien});
        }
    }
}
