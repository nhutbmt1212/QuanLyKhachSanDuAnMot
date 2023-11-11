using Microsoft.AspNetCore.Mvc;

namespace QuanLyKhachSan.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult TrangChuNhanVien()
        {
            return View();
        }
    }
}
