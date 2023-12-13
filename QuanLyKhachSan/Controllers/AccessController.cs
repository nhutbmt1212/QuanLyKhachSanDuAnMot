using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using QuanLyKhachSan.Models;
using System;
using System.Net.Mail;
using System.Net;

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
        [HttpPost]
        public async Task<IActionResult> GuiMail(string Email)
        {
            var existEmailNhanVien = _db.NhanVien.FirstOrDefault(s => s.Email == Email);
            var existEmailKhachHang = _db.NhanVien.FirstOrDefault(s => s.Email == Email);
            if(existEmailKhachHang != null)
            {
                string MaXacNhan;
                Random rnd = new Random();
                MaXacNhan = rnd.Next().ToString();

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("khachsanasap@gmail.com", "ulwg gvjl vqmb iwya");

                MailMessage mail = new MailMessage();
                mail.To.Add(Email);
                mail.From = new MailAddress("khachsanasap@gmail.com");
                mail.Subject = "Thông Báo Quan Trọng Từ Khách Sạn ASAP";

                string logoUrl = "https://i.imgur.com/2VUOkoU.png";

                mail.Body = "Kính gửi,<br>" +
                            "Chúng tôi xác nhận bạn đã sử dụng quên mật khẩu của chúng tôi<br>" +
                            "<strong><h2>Đây là mã xác nhận của bạn: " + MaXacNhan + "</h2></strong><br>" +
                            "Xin vui lòng không cung cấp cho người khác<br>" +
                            "Trân trọng.<br>" +
                            "Đội ngũ hỗ trợ Khách Sạn ASAP" + "<br><br>" +
                            "<img src='" + logoUrl + "' alt='Logo' />";
                mail.IsBodyHtml = true;
                await smtp.SendMailAsync(mail);
                return Json(new { success = true, confirmationCode = MaXacNhan, responseText = "Email đã được gửi thành công!" });
            }
            if(existEmailNhanVien != null)
            {
                string MaXacNhan;
                Random rnd = new Random();
                MaXacNhan = rnd.Next().ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("khachsanasap@gmail.com", "ulwg gvjl vqmb iwya");
                MailMessage mail = new MailMessage();
                mail.To.Add(Email);
                mail.From = new MailAddress("khachsanasap@gmail.com");
                mail.Subject = "Thông Báo Quan Trọng Từ Khách Sạn ASAP";
                string logoUrl = "https://i.imgur.com/2VUOkoU.png";
                mail.Body = "Kính gửi,<br>" +
                            "Chúng tôi xác nhận bạn đã sử dụng quên mật khẩu của chúng tôi<br>" +
                            "<strong><h2>Đây là mã xác nhận của bạn: " + MaXacNhan + "</h2></strong><br>" +
                            "Xin vui lòng không cung cấp cho người khác<br>" +
                            "Trân trọng.<br>" +
                            "Đội ngũ hỗ trợ Khách Sạn ASAP" + "<br><br>" +
                            "<img src='" + logoUrl + "' alt='Logo' />";
                mail.IsBodyHtml = true;
                await smtp.SendMailAsync(mail);
                return Json(new { success = true, confirmationCode = MaXacNhan, responseText = "Email đã được gửi thành công!" });
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult QuenMatKhau(string Email , string NewPassword)
        {
            var qr_nhanvien = _db.NhanVien.FirstOrDefault(s => s.Email == Email);
            var qr_khachhang = _db.KhachHang.FirstOrDefault(s => s.Email == Email);
            if (qr_nhanvien!=null)
            {
                qr_nhanvien.MatKhau = NewPassword;
                _db.NhanVien.Update(qr_nhanvien);
            }
            if (qr_khachhang != null)
            {
                qr_khachhang.MatKhau = NewPassword;
                _db.KhachHang.Update(qr_khachhang);
            }
            _db.SaveChanges();
            return Ok();
        }

    }
}
