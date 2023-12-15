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
        [HttpPost]
        public IActionResult LayThongTinDichVu(string MaDatPhong)
        {
            

            var qr_DichVuChiTiet = _db.ChiTietDichVu
                .Where(s => s.MaDatPhong == MaDatPhong)
                .ToList();

            var maDichVuList = qr_DichVuChiTiet.Select(c => c.MaDichVu).ToList();

            var qr_DichVu = _db.DichVu
                .Where(s => maDichVuList.Contains(s.MaDichVu))
                .ToList();

            var result = new
            {
                DichVuChiTiet = qr_DichVuChiTiet,
                DichVu = qr_DichVu
            };

            return Json(result);
        }

    }
}
