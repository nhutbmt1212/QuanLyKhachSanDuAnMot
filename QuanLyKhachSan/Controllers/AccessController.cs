using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using QuanLyKhachSan.Models;
using System;

namespace QuanLyKhachSan.Controllers
{
    public class AccessController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();

        public AccessController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");

            }
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> Login(string TenDangNhap, string MatKhau)
		{
			List<Claim> claims = new List<Claim>();
			ClaimsIdentity claimsIdentity;
			AuthenticationProperties properties = new AuthenticationProperties()
			{
				AllowRefresh = true,
			};
			//query nhanvien,khachhang
			var qr_nhanvien = _db.NhanVien.FirstOrDefault(s => s.TenDangNhap == TenDangNhap && s.MatKhau == MatKhau);
			var qr_khachhang = _db.KhachHang.FirstOrDefault(s => s.Email == TenDangNhap && s.MatKhau == MatKhau);
			if (qr_nhanvien!=null)
			{
				if(qr_nhanvien.ChucVu=="Quản lý")
				{
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, TenDangNhap));
                    claims.Add(new Claim(ClaimTypes.Role, "Quản lý"));
                    claims.Add(new Claim(ClaimTypes.UserData, TenDangNhap));
                    claims.Add(new Claim(ClaimTypes.Name, qr_nhanvien.TenNhanVien));
                    claims.Add(new Claim(ClaimTypes.Surname, qr_nhanvien.MaNhanVien));

                    claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
                    return RedirectToAction("Index", "Home");
                }
				else if(qr_nhanvien.ChucVu=="Nhân viên")
				{
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, TenDangNhap));
                    claims.Add(new Claim(ClaimTypes.Role, "Nhân viên"));
                    claims.Add(new Claim(ClaimTypes.UserData, TenDangNhap));
                    claims.Add(new Claim(ClaimTypes.Name, qr_nhanvien.TenNhanVien));
                    claims.Add(new Claim(ClaimTypes.Surname, qr_nhanvien.MaNhanVien));


                    claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
                    return RedirectToAction("Index", "Home");
                }
			
			}
			else if (qr_khachhang!=null)
			{
				claims.Add(new Claim(ClaimTypes.NameIdentifier, TenDangNhap));
				claims.Add(new Claim(ClaimTypes.Role, "Khách hàng"));
                claims.Add(new Claim(ClaimTypes.UserData, TenDangNhap));
                claims.Add(new Claim(ClaimTypes.Name, qr_khachhang.TenKhachHang));
                claims.Add(new Claim(ClaimTypes.Surname, qr_khachhang.MaKhachHang));


                claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
				return RedirectToAction("Index", "TrangChuKhachHang");
			}
            else
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Đăng nhập không thành công";
            }

			
			return View();
		}
        public IActionResult GiaoDienDangKy()
        {
            return View("GiaoDienDangKy");
        }
        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.KhachHang.Any(d => d.MaKhachHang == $"NV{randomString}"));

            return $"KH{randomString}";
        }
        [HttpPost]
        public IActionResult DangKyTaikhoan(string TenKhachHang, string Email, string MatKhau)
        {

            var kh = new KhachHang
            {
                MaKhachHang = GenerateRandomCode(),
                TenKhachHang = TenKhachHang,
                Email = Email,
                MatKhau = MatKhau,
                NgayDangKy =DateTime.Now,
                TinhTrang="Đang hoạt động"
                
            };
            _db.KhachHang.Add(kh);
            _db.SaveChanges();
            return View("Login");
        }



	}
}
