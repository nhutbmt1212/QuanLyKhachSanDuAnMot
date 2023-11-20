using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class DatPhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DatPhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var qr_Phong= _db.Phong.ToList();
           
            return View(qr_Phong);
        }
    }
}
