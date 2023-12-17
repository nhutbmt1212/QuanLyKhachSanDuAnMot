using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;
using System.Security.Claims;


namespace QuanLyKhachSan.Controllers
{
    [Authorize]
    public class TiepNhanDatPhongController : Controller
    {

        private readonly ApplicationDbContext _db;
        public TiepNhanDatPhongController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            var datPhongChoXuLy = _db.DatPhong
                .Include(dp => dp.KhachHang)
                .Include(dp => dp.Phong)
                .ThenInclude(p => p.LoaiPhong)
                .Where(dp => dp.TinhTrang == "Chờ xử lý")
                .ToList();

            return View(datPhongChoXuLy);
        }
        public IActionResult GetReservationDetails(string maDatPhong)
        {
            var reservation = _db.DatPhong
                .Include(dp => dp.KhachHang)
                .Include(dp => dp.Phong)
                .ThenInclude(p => p.LoaiPhong)
               
                .FirstOrDefault(dp => dp.MaDatPhong == maDatPhong);

            return Json(reservation);
        }
        public IActionResult GetServiceItems(string maDatPhong)
        {
            try
            {
                var serviceItems = _db.ChiTietDichVu
                    .Include(ctdv => ctdv.DichVu)
                    .Where(ctdv => ctdv.MaDatPhong == maDatPhong)
                    .Select(ctdv => new
                    {
                        ctdv.MaDichVu,
                        ctdv.DichVu.TenDichVu,
                        ctdv.SoLuong,
                        ctdv.DichVu.GiaTien,
                                       
                    })
                    .ToList();

                return Json(serviceItems);
            }
            catch (Exception ex)
            {
                return BadRequest("Error retrieving service items: " + ex.Message);
            }
        }
        public IActionResult ChapNhanDatPhong(string MaDatPhong)
        {
            var MaNhanVienDatPhong = User.FindFirst(ClaimTypes.Surname)?.Value;

            var qr_datPhong = _db.DatPhong.FirstOrDefault(s => s.MaDatPhong == MaDatPhong);
            if (qr_datPhong != null)
            {
                qr_datPhong.TinhTrang = "Đã được duyệt";
                qr_datPhong.MaNhanVien = MaNhanVienDatPhong;
                _db.DatPhong.Update(qr_datPhong);
                _db.SaveChanges();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Đã xác nhận đặt phòng thành công";
            }
            return Json(0);
        }
        public IActionResult HuyDatPhong(string MaDatPhong)
        {
            var MaNhanVienDatPhong = User.FindFirst(ClaimTypes.Surname)?.Value;

            var qr_datPhong = _db.DatPhong.FirstOrDefault(s => s.MaDatPhong == MaDatPhong);
            if (qr_datPhong != null)
            {
                qr_datPhong.TinhTrang = "Đã hủy";
                qr_datPhong.MaNhanVien = MaNhanVienDatPhong;
                _db.DatPhong.Update(qr_datPhong);
                _db.SaveChanges();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Đã hủy xác nhận đặt phòng thành công";
            }
            return Json(0);
        }

    }
}
