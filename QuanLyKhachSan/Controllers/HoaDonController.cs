using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{

    public class HoaDonController : Controller
    {

        private readonly ApplicationDbContext _db;
        public class HoaDonDTO
{
    public HoaDon HoaDon { get; set; }
    public DatPhong DatPhong { get; set; }
    public Phong Phong { get; set; }
    public LoaiPhong LoaiPhong { get; set; }
    public KhachHang KhachHang { get; set; }
    public NhanVien NhanVien { get; set; }
    public List<ChiTietDichVu> ChiTietDichVu { get; set; }
}
        public HoaDonController(ApplicationDbContext db )
        {
            _db = db;
        }
        public IActionResult TrangChuHoaDon()
        {
            var qr_HoaDon = _db.HoaDon.ToList();
            return View(qr_HoaDon);
        }
        // Controller
        [HttpPost]
        public IActionResult LayThongTinHoaDon(string MaHoaDon)
        {
            var qr_HoaDon = (from hd in _db.HoaDon
                             join dp in _db.DatPhong on hd.MaDatPhong equals dp.MaDatPhong
                             join p in _db.Phong on dp.MaPhong equals p.MaPhong
                             join lp in _db.LoaiPhong on p.MaLoaiPhong equals lp.MaLoaiPhong
                             join kh in _db.KhachHang on dp.MaKhachHang equals kh.MaKhachHang
                             join nv in _db.NhanVien on dp.MaNhanVien equals nv.MaNhanVien
                             where hd.MaHoaDon == MaHoaDon
                             select new
                             {
                                 HoaDon = hd,
                                 DatPhong = dp,
                                 Phong = p,
                                 LoaiPhong = lp,
                                 KhachHang = kh,
                                 NhanVien = nv
                             }).FirstOrDefault();

            return Json(qr_HoaDon);
        }

        [HttpPost]
        public IActionResult LayThongTinDichVu(string MaHoaDon)
        {
            var qr_HoaDon = _db.HoaDon.FirstOrDefault(s => s.MaHoaDon == MaHoaDon);

            if (qr_HoaDon == null)
            {
                // Handle the case where the bill is not found
                return NotFound("Bill not found");
            }

            var qr_DichVuChiTiet = _db.ChiTietDichVu
                .Where(s => s.MaDatPhong == qr_HoaDon.MaDatPhong)
                .ToList();

            // Assuming ChiTietDichVu contains a property named MaDichVu
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
