using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
            return RedirectToAction("Index", "TrangChuKhachHang");
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
            return Json(new { qr_Phong, qr_LoaiPhong });

        }
        [HttpGet]
        public IActionResult LayThongTinDichVu(string MaDichVu)
        {
            var qr_dichvu = _db.DichVu.FirstOrDefault(s => s.MaDichVu == MaDichVu);
            return Json(qr_dichvu);
        }
        //đặt phòng
        [HttpPost]
        public IActionResult DatPhong(string TenKhachHang, string GioiTinh, string sdt, string email, DateTime ngaysinh, string diachi, string cccd, DateTime NgayNhan, DateTime NgayTra, string MaPhong, int SoLuongNguoiLon, int SoLuongTreEm, int TongTien, List<int> arrSoLuongDichVu, List<string> arrMaDichVu)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string maKhachHang = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            var khachHang = new KhachHang
            {
                MaKhachHang = maKhachHang,
                TenKhachHang = TenKhachHang,
                SoDienThoai = sdt,
                DiaChi = diachi,
                CCCD = cccd,
                NgaySinh = ngaysinh,
                GioiTinh = GioiTinh,
                Email = email,
                TinhTrang = "Đang hoạt động",
                MatKhau = maKhachHang,
                NgayDangKy = DateTime.Now
            };
            _db.KhachHang.Add(khachHang);
            const string chars1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string MaDatPhong = new string(Enumerable.Repeat(chars1, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            var DatPhong = new DatPhong
            {
                MaDatPhong = MaDatPhong,
                MaKhachHang = maKhachHang,
                MaPhong = MaPhong,
                NgayNhan = NgayNhan,
                NgayTra = NgayTra,
                SoLuongNguoiLon = SoLuongNguoiLon,
                SoLuongTreEm = SoLuongTreEm,
                HinhThucDatPhong = "Trả sau",
                TongTienPhong = TongTien,
                MaNhanVien = null,
                TinhTrang = "Chờ xử lý",
                SoTienTraTruoc = 0
            };
            _db.DatPhong.Add(DatPhong);
            if (arrMaDichVu !=null || arrSoLuongDichVu !=null)
            {


                for (int i = 0; i < arrMaDichVu.Count; i++)
                {
                    var maDichVu = arrMaDichVu[i];
                    var SoLuongDichVu = arrSoLuongDichVu[i];

                    var DichVu = new ChiTietDichVu
                    {
                        MaDichVu = maDichVu,
                        MaKhachHang = maKhachHang,
                        SoLuong = SoLuongDichVu,
                        MaNhanVien = null,
                        ThoiGianDichVu = DateTime.Now,
                        TrangThai = "Hoạt động",
                        MaDatPhong = MaDatPhong
                    };
                    _db.ChiTietDichVu.Add(DichVu);
                }
            }
            _db.SaveChanges();
            return Json("ok");
        }


    }
}
