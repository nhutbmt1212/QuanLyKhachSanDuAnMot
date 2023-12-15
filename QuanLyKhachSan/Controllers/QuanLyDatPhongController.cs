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
    }
}
