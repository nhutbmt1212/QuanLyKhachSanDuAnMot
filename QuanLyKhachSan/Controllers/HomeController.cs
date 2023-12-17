using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using QuanLyKhachSan.Models;
using Microsoft.Extensions.Hosting;

namespace QuanLyKhachSan.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
        [HttpPost]
        public IActionResult LayTinhTrangPhong()
        {
            var phongDaDat = _db.DatPhong.Count(x => x.NgayNhan < DateTime.Now && x.NgayTra > DateTime.Now && x.TinhTrang== "Đã được duyệt" || x.TinhTrang== "Chờ check out" || x.TinhTrang== "Chờ check in");
            var soluongphong = _db.Phong.Count(x => x.TinhTrang == "Đang hoạt động");

            var PhongTrong = soluongphong - phongDaDat;

            // Trả về dữ liệu dưới dạng JSON
            return Json(new { PhongTrong = PhongTrong, phongDaDat = phongDaDat });
        }

        public IActionResult LayDoanhThuTheoThang()
        {
            // Khởi tạo mảng với 12 phần tử tương ứng với 12 tháng
            var doanhThuTheoThang = new decimal[12];

            // Lấy dữ liệu từ cơ sở dữ liệu
            var duLieuTuDb = _db.HoaDon
                .GroupBy(hd => new { hd.ThoiGianThanhToan.Year, hd.ThoiGianThanhToan.Month })
                .Select(g => new
                {
                    Thang = g.Key.Month,
                    Nam = g.Key.Year,
                    DoanhThu = (decimal)g.Sum(hd => hd.SoTienThanhToan)
                })
                .ToList();

            // Cập nhật giá trị cho các tháng có dữ liệu
            foreach (var item in duLieuTuDb)
            {
                // Lưu ý rằng chỉ số của mảng bắt đầu từ 0
                doanhThuTheoThang[item.Thang - 1] = item.DoanhThu;
            }

            return Json(doanhThuTheoThang);
        }

        [HttpPost]
        public IActionResult LaySoLuongKhachHang()
        {

            var soluongkhachahng = _db.KhachHang.Count();



            // Trả về dữ liệu dưới dạng JSON
            return Json(new { soluongkhachahng = soluongkhachahng });
        }
        [HttpPost]
        public IActionResult GetServiceDetails()
        {
            var query = from chiTiet in _db.ChiTietDichVu
                        join dichVu in _db.DichVu on chiTiet.MaDichVu equals dichVu.MaDichVu
                        group new { chiTiet, dichVu } by new { dichVu.TenDichVu } into grouped
                        select new
                        {
                            TenDichVu = grouped.Key.TenDichVu,
                            TongSoLuong = grouped.Sum(x => x.chiTiet.SoLuong),
                            TongTien = grouped.Sum(x => x.chiTiet.SoLuong * x.dichVu.GiaTien)
                        };

            return Json(query);
        }
        [HttpPost]
        public IActionResult LayLoaiPhong()
        {
            var query = from phong in _db.Phong
                        join loaiPhong in _db.LoaiPhong on phong.MaLoaiPhong equals loaiPhong.MaLoaiPhong
                        join datPhong in _db.DatPhong on phong.MaPhong equals datPhong.MaPhong
                        group new { phong, loaiPhong, datPhong } by new { loaiPhong.TenLoaiPhong } into grouped
                        select new
                        {
                            TenLoaiPhong = grouped.Key.TenLoaiPhong,
                            SoLuong = grouped.Count(),
                            TongTien = grouped.Sum(x => x.datPhong.TongTienPhong)
                        };

            return Json(query);
        }
        [HttpPost]

        public IActionResult DemNhanVienHoatDong()
        {
            // Đếm tổng số nhân viên với tình trạng là "Hoat Dong"
            var tongNhanVien = _db.NhanVien.Count(x => x.TinhTrang == "Hoạt động" || x.TinhTrang == "Hoat Dong");

            // Đếm số nhân viên nam với tình trạng là "Hoat Dong"
            var nhanVienNam = _db.NhanVien.Count(x => x.GioiTinh == "Nam" && x.TinhTrang == "Hoạt động" || x.TinhTrang== "Hoat Dong");

            // Đếm số nhân viên nữ với tình trạng là "Hoat Dong"
            var nhanVienNu = tongNhanVien - nhanVienNam;

            return Json(new { tongNhanVien = tongNhanVien, nhanVienNam = nhanVienNam, nhanVienNu = nhanVienNu });
        }

        [HttpPost]
        public IActionResult LayGioiTinhKhachHang()
        {
            // Đếm tổng số khách hàng với tình trạng không phải là "Ngừng hoạt động"
            var TongKhachHang = _db.KhachHang.Count(x => x.TinhTrang == "Hoạt động" || x.TinhTrang== "Đang hoạt động");



            // Đếm số khách hàng nữ với tình trạng không phải là "Ngừng hoạt động"
            var khachHangNu = _db.KhachHang.Count(x => x.GioiTinh == "Nữ" && x.TinhTrang == "Hoạt động" || x.TinhTrang == "Đang hoạt động");
            // Đếm số khách hàng nam với tình trạng không phải là "Ngừng hoạt động"
            var khachHangNam = TongKhachHang - khachHangNu;
            return Json(new { TongKhachHang = TongKhachHang, khachHangNam = khachHangNam, khachHangNu = khachHangNu });
        }



    }
}
