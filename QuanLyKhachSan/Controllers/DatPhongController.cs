using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;
using System.Security.Claims;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class DatPhongController : Controller
	{
		private readonly ApplicationDbContext _db;
		public DatPhongController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			var listPhong = _db.Phong.Include(p => p.ImageLinks).Where(s => s.TinhTrang != "Đã xóa" && s.TinhTrang !="Đang bảo trì").ToList();
			return View(listPhong);
		}

		[HttpPost]
		public IActionResult GetLoaiPhong(string? id)
		{
			var qr_loaiPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == id);
			return Json(new { qr_loaiPhong });
		}
		[HttpGet]
		public IActionResult LayThongTinPhong(string MaPhong)
		{
			var qr_phong = _db.Phong.FirstOrDefault(s => s.MaPhong == MaPhong);
			var qr_LoaiPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == qr_phong.MaLoaiPhong);
			return Json(new { qr_LoaiPhong, qr_phong });
		}
		[HttpGet]
		public async Task<IActionResult> LayDanhSachDichVu()
		{
			var qr_ListDichVu = _db.DichVu.ToList();
			return Json(qr_ListDichVu);
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
		[HttpPost]
		public IActionResult DatPhongNhanh(List<string> arrMaDichVu, List<int> arrSoLuongDichVu, string maKhachHang, string hinhThuc, DateTime ngayNhan, DateTime ngayTra, int tongNguoiLon, int tongTreEm, int tongTienPhong, int soTienTraTruoc, string maPhong)
		{
			Random random = new Random();

			// mã random mã đặt phòng
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string randomCharacterLastMaDatPhong = new string(Enumerable.Repeat(chars, 4)
				.Select(s => s[random.Next(s.Length)]).ToArray());
			string MaDatPhong = "DP" + randomCharacterLastMaDatPhong;
			//mã nhân viên đặt phòng
			var MaNhanVienDatPhong = User.FindFirst(ClaimTypes.Surname)?.Value;
			var DatPhong = new DatPhong
			{
				MaDatPhong = MaDatPhong,
				MaKhachHang = maKhachHang,
				MaPhong = maPhong,
				NgayNhan = ngayNhan,
				NgayTra = ngayTra,
				SoLuongNguoiLon = tongNguoiLon,
				SoLuongTreEm = tongTreEm,
				HinhThucDatPhong = hinhThuc,
				TongTienPhong = tongTienPhong,
				MaNhanVien = MaNhanVienDatPhong,
				TinhTrang = "Đã được duyệt",
				SoTienTraTruoc = soTienTraTruoc,
			};
			_db.DatPhong.Add(DatPhong);
			if (arrMaDichVu != null || arrSoLuongDichVu != null)
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
						MaNhanVien = MaNhanVienDatPhong,
						ThoiGianDichVu = DateTime.Now,
						TrangThai = "Hoạt động",
						MaDatPhong = MaDatPhong
					};
					_db.ChiTietDichVu.Add(DichVu);
				}
			}
			_db.SaveChanges();
			TempData["SwalIcon"] = "success";
			TempData["SwalTitle"] = "Đặt phòng thành công";

			return Json(new { arrMaDichVu, arrSoLuongDichVu });
		}
		[HttpGet]
		public IActionResult LayThanhToanMaDatPhong(string maPhong)
		{
			var qr_MaDatPhongTheoNgayGioHienTai = _db.DatPhong.FirstOrDefault(s => s.MaPhong == maPhong && s.NgayNhan <= DateTime.Now && s.NgayTra >= DateTime.Now && s.TinhTrang != "Đã thanh toán");
			var qr_MaKhachHangTheoMaDatPhong = _db.KhachHang.FirstOrDefault(s => s.MaKhachHang == qr_MaDatPhongTheoNgayGioHienTai.MaKhachHang);
			var qr_PhongTheoMaPhong = _db.Phong.FirstOrDefault(s => s.MaPhong == maPhong);
			var qr_LoaiPhongTheoMaPhong = _db.LoaiPhong.FirstOrDefault(s => s.MaLoaiPhong == qr_PhongTheoMaPhong.MaLoaiPhong);

			var qr_DichVuTheoMaDatPhong = _db.ChiTietDichVu
				.Where(s => s.MaDatPhong == qr_MaDatPhongTheoNgayGioHienTai.MaDatPhong)
				.Join(_db.DichVu, ctdv => ctdv.MaDichVu, dv => dv.MaDichVu, (ctdv, dv) => new { ctdv.MaDichVu, ctdv.SoLuong, dv.TenDichVu, dv.GiaTien })
				.Select(s => new { s.MaDichVu, s.TenDichVu, s.SoLuong, s.GiaTien, ThanhTien = s.SoLuong * s.GiaTien }) // Calculate ThanhTien
				.ToList();

			return Json(new { qr_MaDatPhongTheoNgayGioHienTai, qr_MaKhachHangTheoMaDatPhong, qr_DichVuTheoMaDatPhong, qr_LoaiPhongTheoMaPhong });
		}
		[HttpGet]
		public IActionResult ThanhToanPhong(string MaDatPhong, int TongTienDichVu, int TongTienPhong, int SoTienThanhToan)
		{
			var MaNhanVienDatPhong = User.FindFirst(ClaimTypes.Surname)?.Value;

			Random random = new Random();

			// mã random mã đặt phòng
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string randomCharacterLastMaDatPhong = new string(Enumerable.Repeat(chars, 4)
				.Select(s => s[random.Next(s.Length)]).ToArray());
			string MaHoaDon = "HD" + randomCharacterLastMaDatPhong;

			var qr_maDatPhong = _db.DatPhong.FirstOrDefault(s => s.MaDatPhong == MaDatPhong);
			qr_maDatPhong.TinhTrang = "Đã thanh toán";
			_db.DatPhong.Update(qr_maDatPhong);
			var hoaDon = new HoaDon
			{
				MaHoaDon = MaHoaDon,
				MaDatPhong = MaDatPhong,
				ThoiGianThanhToan = DateTime.Now,
				MaNhanVien = MaNhanVienDatPhong,
				TongTienDichVu = TongTienDichVu,
				TongTienPhong = TongTienPhong,
				SoTienThanhToan = SoTienThanhToan
			};

			_db.HoaDon.Add(hoaDon);
			_db.SaveChanges();
			TempData["SwalIcon"] = "success";
			TempData["SwalTitle"] = "Thanh toán thành công";
			return RedirectToAction("Index", "DatPhong");
		}

		[HttpPost]
		public IActionResult CheckNgayDatPhong(DateTime ngayNhanMoi, DateTime ngayTraMoi, string maPhongMoi)
		{
			var datPhongs = _db.DatPhong.ToList();

			var result = datPhongs.SelectMany(dp =>
				Enumerable.Range(0, 1 + (dp.NgayTra - dp.NgayNhan).Days)
					.Select(offset => new
					{
						MaDatPhong = dp.MaDatPhong,
						NgayNhan = dp.NgayNhan,
						NgayDuocThue = dp.NgayNhan.AddDays(offset),
						NgayTra = dp.NgayTra
					})
				).ToList();

			var datPhongTrung = result.Any(r => r.MaDatPhong == maPhongMoi &&
				((ngayNhanMoi.Date >= r.NgayNhan.Date && ngayNhanMoi.Date <= r.NgayTra.Date) ||
				(ngayTraMoi.Date >= r.NgayNhan.Date && ngayTraMoi.Date <= r.NgayTra.Date)));

			return Json(!datPhongTrung);
		}
		[HttpPost]
		public IActionResult KiemTraNgayNhanVaTra(DateTime NgayNhan, DateTime NgayTra,string MaPhong)
		{
			string result = null;
			
			var qr_Phong = _db.DatPhong.Where(s => s.MaPhong == MaPhong && s.TinhTrang== "Hủy đặt phòng").ToList();
			//check ngày nhận nằm trong khung giờ đã được đặt
			if(qr_Phong != null)
			{
                foreach (var phong in qr_Phong)
                {
                    if(NgayNhan >= phong.NgayNhan && NgayTra <= phong.NgayTra)
					{
						result = "Khung giờ này đã có người đặt";
						return Json(result);
					}else if(NgayNhan <phong.NgayNhan && NgayTra > phong.NgayNhan)
					{
						result = "Khung giờ này đã có người đặt";
						return Json(result);
					}
					else if(NgayNhan >phong.NgayNhan && NgayNhan < phong.NgayTra)
					{
						result = "Khung giờ này đã có người đặt";
						return Json(result);
					}

					
                }
			}
			
			return Json(result);
			
		}

	}

}
