using Microsoft.AspNetCore.Mvc;

namespace QuanLyKhachSan.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
