using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;


namespace QuanLyKhachSan.Controllers
{
    public class TrangChuKhachHangController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TrangChuKhachHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listPhong = _db.Phong.Include(p => p.ImageLinks).ToList();
            ViewBag.DanhSachPhong = listPhong;
            var listLoaiPhong = _db.LoaiPhong.ToList();
            ViewBag.DanhSachLoaiPhong = listLoaiPhong;

           
            return View(listPhong);
        }
        [HttpGet]

        public IActionResult LayLoaiPhong(string maPhong)
        {
            var loaiPhong = _db.Phong
                .Where(p => p.MaPhong == maPhong)
                .Select(p => p.LoaiPhong) 
                .FirstOrDefault();

            return Json(loaiPhong); 
        }
        [HttpGet]
        public async Task<IActionResult> SlideAnhPhong(string maPhong)
        {
            var phong = await _db.Phong.Include(p => p.ImageLinks).FirstOrDefaultAsync(s => s.MaPhong == maPhong);

            if (phong == null)
            {
                return Json(null);
            }

            var imageUrls = phong.ImageLinks.Select(s => s.Url).ToList();

            return Json(imageUrls);
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","TrangChuKhachHang");
        }
        [HttpGet]
        public async Task<IActionResult> LayDanhSachDichVu()
        {
            var qr_ListDichVu = _db.DichVu.ToList();
            return Json(qr_ListDichVu);
        }
        [HttpGet]
        public IActionResult TimKiemPhong(DateTime NgayNhanPhong, DateTime NgayTraPhong, int SoLuongNguoiLon, int SoLuongTreEm)
        {
            var maPhongDaDatList = _db.DatPhong
                .Where(s => s.NgayTra > NgayNhanPhong)
                .Select(s => s.MaPhong)
                .ToList();
            var join_Phong = from phong in _db.Phong
                             join loaiphong in _db.LoaiPhong on phong.MaLoaiPhong equals loaiphong.MaLoaiPhong
                             select new
                             {
                                 MaPhong = phong.MaPhong,
                                 SlNguoiLon = loaiphong.SoLuongNguoiLon,
                                 SlTreEm = loaiphong.SoLuongTreEm,

                             };

            var qr_PhongKhongDatTieuChuan = join_Phong.Where(s => s.SlNguoiLon < SoLuongNguoiLon || s.SlTreEm < SoLuongTreEm)
                                                      .Select(s => s.MaPhong)
                                                      .ToList();

            return Json(new { maPhongDaDatList, qr_PhongKhongDatTieuChuan });
        }
   


    }
}
