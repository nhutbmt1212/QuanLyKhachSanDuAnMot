using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class QuanLyDatPhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public QuanLyDatPhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var qr_DatPhong = _db.DatPhong.Where(s => s.TinhTrang != "Đã thanh toán" && s.TinhTrang != "Chờ xử lý").ToList();
            return View(qr_DatPhong);
        }
        [HttpPost]
        public IActionResult LayThongTinDichVu(string MaDatPhong)
        {


            var qr_DichVuChiTiet = _db.ChiTietDichVu
                .Where(s => s.MaDatPhong == MaDatPhong)
                .ToList();

            var maDichVuList = qr_DichVuChiTiet.Select(c => c.MaDichVu).ToList();

            var qr_DichVu = _db.DichVu
                .Where(s => maDichVuList.Contains(s.MaDichVu))
                .ToList();



            return Json(new { qr_DichVuChiTiet, qr_DichVu });
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult LayThongTinDatPhong(string MaDatPhong)
        {
            var qr_DatPhong = _db.DatPhong.FirstOrDefault(s => s.MaDatPhong == MaDatPhong);

            return Json(new { qr_DatPhong });
        }


        [HttpPost]
        public IActionResult LayThongTinDichVuChiTiet(string MaDatPhong)
        {


            var qr_DichVuChiTiet = _db.ChiTietDichVu
                .Where(s => s.MaDatPhong == MaDatPhong)
                .ToList();

            var maDichVuList = qr_DichVuChiTiet.Select(c => c.MaDichVu).ToList();

            var qr_DichVu = _db.DichVu
                .Where(s => maDichVuList.Contains(s.MaDichVu))
                .ToList();


            var result = new
            {
                DichVuChiTiet = qr_DichVuChiTiet,
                DichVu = qr_DichVu,
            };

            return Json(result);
        }

        [HttpPost]
        public IActionResult TongDichVu()
        {
            var qr_TongDichVu = _db.DichVu.Count();
            return Json(qr_TongDichVu);
        }

        [HttpPost]
        public IActionResult TinhTienPhong(string MaPhong)
        {
            var qr_Phong = _db.Phong.FirstOrDefault(s => s.MaPhong == MaPhong);
            var qr_LoaiPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == qr_Phong.MaLoaiPhong);
            return Json(new { qr_LoaiPhong });
        }
        [HttpPost]
        public IActionResult suaDatPhong(
     List<string> ThanhTienMaDichVu,
     List<string> arrSoLuongDichVu,
     string maDatPhongValue,
     string maPhongValue,
     string maKhachHangValue,
     DateTime ngayNhanValue,
     DateTime ngayTraValue,
     int soLuongNguoiLonValue,
     int soLuongTreEmValue,
     string hinhThucDatPhongValue,
     string maNhanVienValue,
     int khachTraTruocValue,
     int tongtienPhongValue,
     string tinhTrangValue)
        {
            var datPhong = new DatPhong
            {
                MaDatPhong = maDatPhongValue,
                MaKhachHang = maKhachHangValue,
                MaPhong = maPhongValue,
                NgayNhan = ngayNhanValue,
                NgayTra = ngayTraValue,
                SoLuongNguoiLon = soLuongNguoiLonValue,
                SoLuongTreEm = soLuongTreEmValue,
                HinhThucDatPhong = hinhThucDatPhongValue,
                TongTienPhong = tongtienPhongValue,
                MaNhanVien = maNhanVienValue,
                TinhTrang = tinhTrangValue,
                SoTienTraTruoc = khachTraTruocValue
            };
            _db.DatPhong.Update(datPhong);
            var existingServices = _db.ChiTietDichVu.Where(s => s.MaDatPhong == maDatPhongValue).ToList();
            foreach (var serviceId in ThanhTienMaDichVu)
            {
                var serviceIndex = ThanhTienMaDichVu.IndexOf(serviceId);
                var serviceQuantity = int.Parse(arrSoLuongDichVu[serviceIndex]);
                var existingService = existingServices.FirstOrDefault(s => s.MaDichVu == serviceId);
                if (existingService != null)
                {
                    existingService.SoLuong = serviceQuantity;
                }
                else
                {
                    var newService = new ChiTietDichVu
                    {
                        MaDichVu = serviceId,
                        MaKhachHang = maKhachHangValue,
                        MaDatPhong = maDatPhongValue,
                        SoLuong = serviceQuantity,
                        MaNhanVien = maNhanVienValue,
                        ThoiGianDichVu = DateTime.Now, 
                        TrangThai = "Hoạt động" 
                    };
                    _db.ChiTietDichVu.Add(newService);
                }
            }
            var servicesToRemove = existingServices.Where(s => !ThanhTienMaDichVu.Contains(s.MaDichVu)).ToList();
            foreach (var serviceToRemove in servicesToRemove)
            {
                _db.ChiTietDichVu.Remove(serviceToRemove);
            }
                _db.SaveChanges();
            return RedirectToAction("Index", "QuanLyDatPhong");
        }


    }
}
