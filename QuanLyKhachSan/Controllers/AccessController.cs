using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class AccessController : Controller
    {
        private readonly ApplicationDbContext _db;
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

			if (TenDangNhap == "admin" && MatKhau == "admin")
			{
				claims.Add(new Claim(ClaimTypes.NameIdentifier, TenDangNhap));
				claims.Add(new Claim(ClaimTypes.Role, "Quản lý"));
				claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
				return RedirectToAction("Index", "Home");
			}
			else if (TenDangNhap == "user" && MatKhau == "user")
			{
				claims.Add(new Claim(ClaimTypes.NameIdentifier, TenDangNhap));
				claims.Add(new Claim(ClaimTypes.Role, "Nhân viên"));
				claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
				return RedirectToAction("Index", "Home");
			}

			ViewData["ValidateMessage"] = "User not found";
			return View();
		}


	}
}
