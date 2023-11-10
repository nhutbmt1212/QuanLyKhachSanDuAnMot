using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class AccessController : Controller
    {
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
        public async Task<IActionResult> Login(TaiKhoan modelTaiKhoan)
        {
            if (modelTaiKhoan.TenDangNhap =="admin" && modelTaiKhoan.MatKhau=="admin")
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelTaiKhoan.TenDangNhap),
                    new Claim("OtherProperties","Example Role")
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelTaiKhoan.LuuMatKhau
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),properties);
                return RedirectToAction("Index","Home");
            }
            ViewData["ValidateMessage"] = "User not found";
            return View();
        }
    }
}
