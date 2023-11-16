using Microsoft.EntityFrameworkCore;

namespace QuanLyKhachSan.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<ChiTietDichVu> ChiTietDichVu { get; set; }
        public DbSet<DanhGia> DanhGia { get; set; }
        public DbSet<DatPhong> DatPhong { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình khóa chính tổng hợp cho ChiTietDichVu
            modelBuilder.Entity<ChiTietDichVu>()
                .HasKey(c => new { c.MaDichVu, c.MaKhachHang });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NhanVien>().HasData(
               new NhanVien
               {
                   MaNhanVien = "NV001",
                   TenNhanVien = "Nguyen Van A",
                   SoDienThoai = "123456789",
                   DiaChi = "123 Nguyen Van A, Quan 1, TP.HCM",
                   CCCD = "123456789012",
                   NgaySinh = new DateTime(1990, 1, 1),
                   Email = "nhanvien1@example.com",
                   GioiTinh = "Nam",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Quan ly",
                   NgayVaoLam = DateTime.Now.AddYears(-2),
                   AnhNhanVienBase64 = "Base64Image1",
                   TinhTrang = "Hoat dong",
                   TenDangNhap = "user1",
                   MatKhau = "password1"
               },
               new NhanVien
               {
                   MaNhanVien = "NV002",
                   TenNhanVien = "Tran Thi B",
                   SoDienThoai = "987654321",
                   DiaChi = "456 Tran Thi B, Quan 2, TP.HCM",
                   CCCD = "987654321098",
                   NgaySinh = new DateTime(1995, 5, 5),
                   Email = "nhanvien2@example.com",
                   GioiTinh = "Nu",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Nhan vien",
                   NgayVaoLam = DateTime.Now.AddYears(-1),
                   AnhNhanVienBase64 = "Base64Image2",
                   TinhTrang = "Hoat dong",
                   TenDangNhap = "user2",
                   MatKhau = "password2"
               },
               new NhanVien
               {
                   MaNhanVien = "NV003",
                   TenNhanVien = "Le Van C",
                   SoDienThoai = "111223344",
                   DiaChi = "789 Le Van C, Quan 3, TP.HCM",
                   CCCD = "111223344055",
                   NgaySinh = new DateTime(1985, 10, 10),
                   Email = "nhanvien3@example.com",
                   GioiTinh = "Nam",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Nhan vien",
                   NgayVaoLam = DateTime.Now.AddYears(-3),
                   AnhNhanVienBase64 = "Base64Image3",
                   TinhTrang = "Nghi viec",
                   TenDangNhap = "user3",
                   MatKhau = "password3"
               },
               new NhanVien
               {
                   MaNhanVien = "NV004",
                   TenNhanVien = "Pham Thi D",
                   SoDienThoai = "555666777",
                   DiaChi = "101 Pham Thi D, Quan 4, TP.HCM",
                   CCCD = "555666777044",
                   NgaySinh = new DateTime(1988, 8, 8),
                   Email = "nhanvien4@example.com",
                   GioiTinh = "Nu",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Quan ly",
                   NgayVaoLam = DateTime.Now.AddYears(-5),
                   AnhNhanVienBase64 = "Base64Image4",
                   TinhTrang = "Hoat dong",
                   TenDangNhap = "user4",
                   MatKhau = "password4"
               },
               new NhanVien
               {
                   MaNhanVien = "NV005",
                   TenNhanVien = "Hoang Van E",
                   SoDienThoai = "999888777",
                   DiaChi = "202 Hoang Van E, Quan 5, TP.HCM",
                   CCCD = "999888777033",
                   NgaySinh = new DateTime(1980, 12, 12),
                   Email = "nhanvien5@example.com",
                   GioiTinh = "Nam",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Nhan vien",
                   NgayVaoLam = DateTime.Now.AddYears(-4),
                   AnhNhanVienBase64 = "Base64Image5",
                   TinhTrang = "Hoat dong",
                   TenDangNhap = "user5",
                   MatKhau = "password5"
               }
        );

            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang
                {
                    MaKhachHang = "KH001",
                    TenKhachHang = "Nguyen Van X",
                    SoDienThoai = "123456789",
                    DiaChi = "123 Nguyen Van X, Quan 1, TP.HCM",
                    CCCD = "123456789012",
                    NgaySinh = new DateTime(1992, 3, 15),
                    GioiTinh = "Nam",
                    TinhTrang = "Active",
                    MatKhau = "password1",
                    NgayDangKy = DateTime.Now
                },
                new KhachHang
                {
                    MaKhachHang = "KH002",
                    TenKhachHang = "Tran Thi Y",
                    SoDienThoai = "987654321",
                    DiaChi = "456 Tran Thi Y, Quan 2, TP.HCM",
                    CCCD = "987654321098",
                    NgaySinh = new DateTime(1995, 7, 20),
                    GioiTinh = "Nu",
                    TinhTrang = "Active",
                    MatKhau = "password2",
                    NgayDangKy = DateTime.Now
                },
                new KhachHang
                {
                    MaKhachHang = "KH003",
                    TenKhachHang = "Le Van Z",
                    SoDienThoai = "111223344",
                    DiaChi = "789 Le Van Z, Quan 3, TP.HCM",
                    CCCD = "111223344055",
                    NgaySinh = new DateTime(1988, 10, 5),
                    GioiTinh = "Nam",
                    TinhTrang = "Inactive",
                    MatKhau = "password3",
                    NgayDangKy = DateTime.Now
                },
                new KhachHang
                {
                    MaKhachHang = "KH004",
                    TenKhachHang = "Pham Thi K",
                    SoDienThoai = "555666777",
                    DiaChi = "101 Pham Thi K, Quan 4, TP.HCM",
                    CCCD = "555666777044",
                    NgaySinh = new DateTime(1990, 12, 25),
                    GioiTinh = "Nu",
                    TinhTrang = "Active",
                    MatKhau = "password4",
                    NgayDangKy = DateTime.Now
                },
                new KhachHang
                {
                    MaKhachHang = "KH005",
                    TenKhachHang = "Hoang Van M",
                    SoDienThoai = "999888777",
                    DiaChi = "202 Hoang Van M, Quan 5, TP.HCM",
                    CCCD = "999888777033",
                    NgaySinh = new DateTime(1985, 5, 1),
                    GioiTinh = "Nam",
                    TinhTrang = "Active",
                    MatKhau = "password5",
                    NgayDangKy = DateTime.Now
                }
           );

            modelBuilder.Entity<LoaiPhong>().HasData(
                new LoaiPhong
                {
                    MaLoaiPhong = "LP001",
                    TenLoaiPhong = "Phòng Đơn",
                    GiaTheoGio = 50000,
                    GiaPhongTheoNgay = 100000,
                    PhuThuTraMuon = 20000,
                    SoLuongNguoiLon = 1,
                    SoLuongTreEm = 0
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP002",
                    TenLoaiPhong = "Phòng Đôi",
                    GiaTheoGio = 80000,
                    GiaPhongTheoNgay = 150000,
                    PhuThuTraMuon = 25000,
                    SoLuongNguoiLon = 2,
                    SoLuongTreEm = 1
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP003",
                    TenLoaiPhong = "Phòng Gia Đình",
                    GiaTheoGio = 120000,
                    GiaPhongTheoNgay = 200000,
                    PhuThuTraMuon = 30000,
                    SoLuongNguoiLon = 4,
                    SoLuongTreEm = 2
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP004",
                    TenLoaiPhong = "Phòng Suite",
                    GiaTheoGio = 150000,
                    GiaPhongTheoNgay = 250000,
                    PhuThuTraMuon = 35000,
                    SoLuongNguoiLon = 3,
                    SoLuongTreEm = 1
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP005",
                    TenLoaiPhong = "Phòng VIP",
                    GiaTheoGio = 200000,
                    GiaPhongTheoNgay = 300000,
                    PhuThuTraMuon = 40000,
                    SoLuongNguoiLon = 2,
                    SoLuongTreEm = 0
                }
            );

            modelBuilder.Entity<Phong>().HasData(
                new Phong
                {
                    MaPhong = "P001",
                    MaLoaiPhong = "LP001",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Trong",
                    AnhPhong = new byte[] { 0x1, 0x2, 0x3 } // Dữ liệu hình ảnh ở đây là một mảng byte mẫu, hãy thay đổi theo dữ liệu thực tế của bạn
                },
                new Phong
                {
                    MaPhong = "P002",
                    MaLoaiPhong = "LP002",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Trong",
                    AnhPhong = new byte[] { 0x4, 0x5, 0x6 }
                },
                new Phong
                {
                    MaPhong = "P003",
                    MaLoaiPhong = "LP003",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Da Dat",
                    AnhPhong = new byte[] { 0x7, 0x8, 0x9 }
                },
                new Phong
                {
                    MaPhong = "P004",
                    MaLoaiPhong = "LP004",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Trong",
                    AnhPhong = new byte[] { 0xA, 0xB, 0xC }
                },
                new Phong
                {
                    MaPhong = "P005",
                    MaLoaiPhong = "LP005",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Da Dat",
                    AnhPhong = new byte[] { 0xD, 0xE, 0xF }
                }
            );

            modelBuilder.Entity<DichVu>().HasData(
                new DichVu
                {
                    MaDichVu = "DV001",
                    TenDichVu = "Dịch Vụ 1",
                    DonViTinh = "Cái",
                    GiaTien = 50000,
                    TinhTrang = "Hoạt động",
                    GioDichVu = DateTime.Now
                },
                new DichVu
                {
                    MaDichVu = "DV002",
                    TenDichVu = "Dịch Vụ 2",
                    DonViTinh = "Cái",
                    GiaTien = 80000,
                    TinhTrang = "Hoạt động",
                    GioDichVu = DateTime.Now
                },
                new DichVu
                {
                    MaDichVu = "DV003",
                    TenDichVu = "Dịch Vụ 3",
                    DonViTinh = "Bộ",
                    GiaTien = 120000,
                    TinhTrang = "Ngừng hoạt động",
                    GioDichVu = DateTime.Now
                },
                new DichVu
                {
                    MaDichVu = "DV004",
                    TenDichVu = "Dịch Vụ 4",
                    DonViTinh = "Lần sử dụng",
                    GiaTien = 150000,
                    TinhTrang = "Hoạt động",
                    GioDichVu = DateTime.Now
                },
                new DichVu
                {
                    MaDichVu = "DV005",
                    TenDichVu = "Dịch Vụ 5",
                    DonViTinh = "Bộ",
                    GiaTien = 200000,
                    TinhTrang = "Hoạt động",
                    GioDichVu = DateTime.Now
                }
            );
            modelBuilder.Entity<HoaDon>().HasData(
               new HoaDon
               {
                   MaHoaDon = "HD001",
                   MaDatPhong = "DP001",
                   ThoiGianThanhToan = DateTime.Now,
                   MaNhanVien = "NV001",
                   TongTienDichVu = 50000,
                   TongTienPhong = 100000,
                   SoTienThanhToan = 150000
               },
               new HoaDon
               {
                   MaHoaDon = "HD002",
                   MaDatPhong = "DP002",
                   ThoiGianThanhToan = DateTime.Now,
                   MaNhanVien = "NV002",
                   TongTienDichVu = 80000,
                   TongTienPhong = 150000,
                   SoTienThanhToan = 230000
               },
               new HoaDon
               {
                   MaHoaDon = "HD003",
                   MaDatPhong = "DP003",
                   ThoiGianThanhToan = DateTime.Now,
                   MaNhanVien = "NV003",
                   TongTienDichVu = 120000,
                   TongTienPhong = 200000,
                   SoTienThanhToan = 320000
               },
               new HoaDon
               {
                   MaHoaDon = "HD004",
                   MaDatPhong = "DP004",
                   ThoiGianThanhToan = DateTime.Now,
                   MaNhanVien = "NV004",
                   TongTienDichVu = 150000,
                   TongTienPhong = 250000,
                   SoTienThanhToan = 400000
               },
               new HoaDon
               {
                   MaHoaDon = "HD005",
                   MaDatPhong = "DP005",
                   ThoiGianThanhToan = DateTime.Now,
                   MaNhanVien = "NV005",
                   TongTienDichVu = 200000,
                   TongTienPhong = 300000,
                   SoTienThanhToan = 500000
               }
           );
            modelBuilder.Entity<DatPhong>().HasData(
               new DatPhong
               {
                   MaDatPhong = "DP001",
                   MaKhachHang = "KH001",
                   MaPhong = "P001",
                   NgayNhan = DateTime.Now,
                   NgayTra = DateTime.Now.AddDays(1),
                   SoLuongNguoiLon = 2,
                   SoLuongTreEm = 1,
                   HinhThucDatPhong = "Trực tuyến",
                   TongTienPhong = 100000,
                   MaNhanVien = "NV001",
                   TinhTrang = "Đã xác nhận",
                   SoTienTraTruoc = 50000
               },
               new DatPhong
               {
                   MaDatPhong = "DP002",
                   MaKhachHang = "KH002",
                   MaPhong = "P002",
                   NgayNhan = DateTime.Now.AddDays(2),
                   NgayTra = DateTime.Now.AddDays(4),
                   SoLuongNguoiLon = 1,
                   SoLuongTreEm = 0,
                   HinhThucDatPhong = "Điện thoại",
                   TongTienPhong = 150000,
                   MaNhanVien = "NV002",
                   TinhTrang = "Đã xác nhận",
                   SoTienTraTruoc = 80000
               },
               new DatPhong
               {
                   MaDatPhong = "DP003",
                   MaKhachHang = "KH003",
                   MaPhong = "P003",
                   NgayNhan = DateTime.Now.AddDays(3),
                   NgayTra = DateTime.Now.AddDays(5),
                   SoLuongNguoiLon = 3,
                   SoLuongTreEm = 2,
                   HinhThucDatPhong = "Trực tiếp",
                   TongTienPhong = 200000,
                   MaNhanVien = "NV003",
                   TinhTrang = "Đã xác nhận",
                   SoTienTraTruoc = 120000
               },
               new DatPhong
               {
                   MaDatPhong = "DP004",
                   MaKhachHang = "KH004",
                   MaPhong = "P004",
                   NgayNhan = DateTime.Now.AddDays(4),
                   NgayTra = DateTime.Now.AddDays(6),
                   SoLuongNguoiLon = 2,
                   SoLuongTreEm = 0,
                   HinhThucDatPhong = "Trực tuyến",
                   TongTienPhong = 250000,
                   MaNhanVien = "NV004",
                   TinhTrang = "Đã xác nhận",
                   SoTienTraTruoc = 150000
               },
               new DatPhong
               {
                   MaDatPhong = "DP005",
                   MaKhachHang = "KH005",
                   MaPhong = "P005",
                   NgayNhan = DateTime.Now.AddDays(5),
                   NgayTra = DateTime.Now.AddDays(7),
                   SoLuongNguoiLon = 1,
                   SoLuongTreEm = 1,
                   HinhThucDatPhong = "Điện thoại",
                   TongTienPhong = 300000,
                   MaNhanVien = "NV005",
                   TinhTrang = "Đã xác nhận",
                   SoTienTraTruoc = 200000
               }
           );

            modelBuilder.Entity<DanhGia>().HasData(
                new DanhGia
                {
                    MaDanhGia = "DG001",
                    MaKhachHang = "KH001",
                    BinhLuan = "Dịch vụ tốt, phòng sạch sẽ.",
                    NgayDanhGia = DateTime.Now,
                    DiemDanhGia = 5
                },
                new DanhGia
                {
                    MaDanhGia = "DG002",
                    MaKhachHang = "KH002",
                    BinhLuan = "Không hài lòng với dịch vụ nhân viên.",
                    NgayDanhGia = DateTime.Now,
                    DiemDanhGia = 2
                },
                new DanhGia
                {
                    MaDanhGia = "DG003",
                    MaKhachHang = "KH003",
                    BinhLuan = "Phòng ốc quá ồn ào, không yên tĩnh.",
                    NgayDanhGia = DateTime.Now,
                    DiemDanhGia = 3
                },
                new DanhGia
                {
                    MaDanhGia = "DG004",
                    MaKhachHang = "KH004",
                    BinhLuan = "Dịch vụ và phòng ốc đều rất tốt.",
                    NgayDanhGia = DateTime.Now,
                    DiemDanhGia = 5
                },
                new DanhGia
                {
                    MaDanhGia = "DG005",
                    MaKhachHang = "KH005",
                    BinhLuan = "Giá cả hợp lý, nhân viên nhiệt tình.",
                    NgayDanhGia = DateTime.Now,
                    DiemDanhGia = 4
                }
            );
            modelBuilder.Entity<ChiTietDichVu>().HasData(
               new ChiTietDichVu
               {
                   MaDichVu = "DV001",
                   MaKhachHang = "KH001",
                   SoLuong = 2,
                   MaNhanVien = "NV001",
                   ThoiGianDichVu = DateTime.Now,
                   TrangThai = "Hoàn thành"
               },
               new ChiTietDichVu
               {
                   MaDichVu = "DV002",
                   MaKhachHang = "KH002",
                   SoLuong = 1,
                   MaNhanVien = "NV002",
                   ThoiGianDichVu = DateTime.Now,
                   TrangThai = "Chưa hoàn thành"
               },
               new ChiTietDichVu
               {
                   MaDichVu = "DV003",
                   MaKhachHang = "KH003",
                   SoLuong = 3,
                   MaNhanVien = "NV003",
                   ThoiGianDichVu = DateTime.Now,
                   TrangThai = "Hoàn thành"
               },
               new ChiTietDichVu
               {
                   MaDichVu = "DV004",
                   MaKhachHang = "KH004",
                   SoLuong = 2,
                   MaNhanVien = "NV004",
                   ThoiGianDichVu = DateTime.Now,
                   TrangThai = "Chưa hoàn thành"
               },
               new ChiTietDichVu
               {
                   MaDichVu = "DV005",
                   MaKhachHang = "KH005",
                   SoLuong = 1,
                   MaNhanVien = "NV005",
                   ThoiGianDichVu = DateTime.Now,
                   TrangThai = "Hoàn thành"
               }
           );

        }
    }
}
