using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance.Implementations;
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
            var qr_DatPhong = _db.DatPhong.ToList();
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

            

            return Json(new {qr_DichVuChiTiet,qr_DichVu});
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult LayThongTinDatPhong(string MaDatPhong) {
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
        public IActionResult suaDatPhong(List<string> ThanhTienMaDichVu, List<string> arrSoLuongDichVu, string maDatPhongValue, string maPhongValue, string maKhachHangValue, DateTime ngayNhanValue, DateTime ngayTraValue, int soLuongNguoiLonValue, int soLuongTreEmValue, string hinhThucDatPhongValue, string maNhanVienValue, int khachTraTruocValue, int tongtienPhongValue)
        {

            var DatPhong = new DatPhong
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
                TinhTrang = "Đã được duyệt",
                SoTienTraTruoc = khachTraTruocValue
            };
            _db.DatPhong.Update(DatPhong);
            // Lấy tất cả dịch vụ từ cơ sở dữ liệu
            var allServices = _db.ChiTietDichVu.Where(s => s.MaDatPhong == maDatPhongValue).Select(s => s.MaDichVu).ToList();

            // Xóa dịch vụ không còn trong mảng
            foreach (var service in allServices)
            {
                if (!ThanhTienMaDichVu.Contains(service))
                {
                    var serviceToRemove = _db.ChiTietDichVu.FirstOrDefault(s => s.MaDichVu == service && s.MaDatPhong == maDatPhongValue);
                    _db.ChiTietDichVu.Remove(serviceToRemove);
                }
            }

            // Thêm dịch vụ mới từ mảng
            for (int i = 0; i < ThanhTienMaDichVu.Count; i++)
            {
                if (!allServices.Contains(ThanhTienMaDichVu[i]))
                {
                    var newService = new ChiTietDichVu
                    {
                        MaDichVu = ThanhTienMaDichVu[i],
                        MaKhachHang= maKhachHangValue,
                        SoLuong = int.Parse(arrSoLuongDichVu[i]),
                        MaDatPhong = maDatPhongValue,
                        MaNhanVien = maNhanVienValue,
                        ThoiGianDichVu =DateTime.Now,
                        TrangThai="Hoạt động"
                        // Đặt các trường khác ở đây
                    };
                    _db.ChiTietDichVu.Add(newService);
                }
            }

           

            // Lưu thay đổi
            _db.SaveChanges();

            return RedirectToAction("Index", "QuanLyDatPhong");
        }

    }
}
