using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;
using DocumentFormat.OpenXml.VariantTypes;

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
        [HttpPost]
        public IActionResult TinhTienDichVu(List<string> arrMaDichVu, List<string> arrSoLuongDichVu)
        {
            decimal tongTien = 0;
            for (int i = 0; i < arrMaDichVu.Count; i++)
            {
                var maDichVu = arrMaDichVu[i];
                var soLuong = int.Parse(arrSoLuongDichVu[i]);

                // Giả sử bạn có một bảng DịchVụ trong cơ sở dữ liệu với các cột MaDichVu, GiaTien
                var dichVu = _db.DichVu.SingleOrDefault(dv => dv.MaDichVu == maDichVu);
                if (dichVu != null)
                {
                    tongTien += dichVu.GiaTien * soLuong;
                }
            }
            return Json(tongTien);
        }
    
        public IActionResult ThongTinDatPhong()
        {
            return View("ThongTinDatPhong");
        }

        public IActionResult LayThongTinPhongTheoMaPhong(string maPhong)
        {
            var qr_Phong = _db.Phong.FirstOrDefault(s => s.MaPhong == maPhong);
            var maLoaiPhong = qr_Phong.MaLoaiPhong;
            var qr_LoaiPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == maLoaiPhong);
            return Json (new { qr_Phong, qr_LoaiPhong });

        }
        [HttpGet]
        public ActionResult LayThongTinDichVu(string MaDichVu)
        {
            var qr_dichvu = _db.DichVu.FirstOrDefault(s => s.MaDichVu == MaDichVu);
            return Json(qr_dichvu);
        }
    }
}
