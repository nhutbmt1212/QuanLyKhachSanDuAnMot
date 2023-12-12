using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using QuanLyKhachSan.Models;

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
            return RedirectToAction("Login","Access");
        }
        [HttpPost]
        public IActionResult LayTinhTrangPhong()
        {
            var phongDaDat = _db.Phong.Select(x => x.TinhTrang== "Đang hoạt động").Count();
            var soluongphong = _db.Phong.Count();

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
        [HttpGet]
        public IActionResult LayThuNhapTheoNam()
        {
            var thanhTien = _db.HoaDon.Sum(s => s.SoTienThanhToan);

            return Json(thanhTien);
        }
        [HttpGet]
        public IActionResult LayThuNhapTheoThang(int year, int month)
        {
            // Giả sử dbContext là một instance của DbContext của bạn
            var thanhtien = _db.HoaDon
                .Where(hd => hd.ThoiGianThanhToan.Year == year && hd.ThoiGianThanhToan.Month == month)
                .Sum(hd => hd.SoTienThanhToan);

            // Trả về tổng thu nhập dưới dạng JSON
            return Json(thanhtien);
        }
        [HttpPost]
        public IActionResult LaySoLuongKhachHang()
        {
            
            var soluongkhachahng = _db.KhachHang.Count();

       

            // Trả về dữ liệu dưới dạng JSON
            return Json(new { soluongkhachahng = soluongkhachahng });
        }
    }
}
