using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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
        public DbSet<ImageLink> imglink { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<VatTu> VatTu { get; set; }
        public DbSet<ChiTietPhongVatTu> ChiTietPhongVatTu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình khóa chính tổng hợp cho ChiTietDichVu
            modelBuilder.Entity<ChiTietDichVu>()
                .HasKey(c => new { c.MaDichVu, c.MaKhachHang });
            modelBuilder.Entity<ChiTietPhongVatTu>()
                .HasKey(c => new { c.MaVatTu, c.MaPhong });
            modelBuilder.Entity<ChiTietDichVu>()
               .HasOne(cd => cd.DatPhong)
               .WithMany(dp => dp.ChiTietDichVu)
               .HasForeignKey(cd => cd.MaDatPhong)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);


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
                   ChucVu = "Quản lý",
                   NgayVaoLam = DateTime.Now.AddYears(-2),
                   AnhNhanVienBase64 = "UploadImage\\profileStaff.jpg",
                   TinhTrang = "Hoạt động",
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
                   GioiTinh = "Nữ",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Nhân viên",
                   NgayVaoLam = DateTime.Now.AddYears(-1),
                   AnhNhanVienBase64 = "UploadImage\\profileStaff2.jpg",
                   TinhTrang = "Hoạt động",
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
                   ChucVu = "Nhân viên",
                   NgayVaoLam = DateTime.Now.AddYears(-3),
                   AnhNhanVienBase64 = "UploadImage\\profileStaff3.jpg",
                   TinhTrang = "Nghỉ việc",
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
                   GioiTinh = "Nữ",
                   NgayDangKy = DateTime.Now,
                   ChucVu = "Quản lý",
                   NgayVaoLam = DateTime.Now.AddYears(-5),
                   AnhNhanVienBase64 = "UploadImage\\profileStaff4.jpg",
                   TinhTrang = "Hoạt động",
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
                   ChucVu = "Nhân viên",
                   NgayVaoLam = DateTime.Now.AddYears(-4),
                   AnhNhanVienBase64 = "UploadImage\\profileStaff5.webp",
                   TinhTrang = "Hoạt động",
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
                    Email = "khachhang1@example.com",
                    TinhTrang = "Hoạt động",
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
                    GioiTinh = "Nữ",
                    Email = "khachhang2@example.com",
                    TinhTrang = "Hoạt động",
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
                    Email = "khachhang3@example.com",
                    TinhTrang = "Hoạt động",
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
                    GioiTinh = "Nữ",
                    Email = "khachhang4@example.com",
                    TinhTrang = "Hoạt động",
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
                    Email = "khachhang5@example.com",
                    TinhTrang = "Ngừng hoạt động",
                    MatKhau = "password5",
                    NgayDangKy = DateTime.Now
                }
           );

            modelBuilder.Entity<LoaiPhong>().HasData(
                new LoaiPhong
                {
                    MaLoaiPhong = "LP0001",
                    TenLoaiPhong = "Phòng Đơn",
                    GiaTheoGio = 50000,
                    GiaPhongTheoNgay = 100000,
                    PhuThuTraMuon = 20000,
                    SoLuongNguoiLon = 1,
                    SoLuongTreEm = 0
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP0002",
                    TenLoaiPhong = "Phòng Đôi",
                    GiaTheoGio = 80000,
                    GiaPhongTheoNgay = 150000,
                    PhuThuTraMuon = 25000,
                    SoLuongNguoiLon = 2,
                    SoLuongTreEm = 1
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP0003",
                    TenLoaiPhong = "Phòng Gia Đình",
                    GiaTheoGio = 120000,
                    GiaPhongTheoNgay = 200000,
                    PhuThuTraMuon = 30000,
                    SoLuongNguoiLon = 4,
                    SoLuongTreEm = 2
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP0004",
                    TenLoaiPhong = "Phòng Suite",
                    GiaTheoGio = 150000,
                    GiaPhongTheoNgay = 250000,
                    PhuThuTraMuon = 35000,
                    SoLuongNguoiLon = 3,
                    SoLuongTreEm = 1
                },
                new LoaiPhong
                {
                    MaLoaiPhong = "LP0005",
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
                    MaPhong = "P00001",
                    MaLoaiPhong = "LP0001",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Đang hoạt động",
                },
                new Phong
                {
                    MaPhong = "P00002",
                    MaLoaiPhong = "LP0002",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Đang hoạt động",
                },
                new Phong
                {
                    MaPhong = "P00003",
                    MaLoaiPhong = "LP0003",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Đang hoạt động",
                },
                new Phong
                {
                    MaPhong = "P00004",
                    MaLoaiPhong = "LP0004",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Đang hoạt động",
                },
                new Phong
                {
                    MaPhong = "P00005",
                    MaLoaiPhong = "LP0005",
                    NgayTao = DateTime.Now,
                    TinhTrang = "Đang hoạt động",
                }
            );

            modelBuilder.Entity<ImageLink>().HasData(
                new ImageLink
                {
                    ImageLinkId = 1,
                    Url = "Deluxe_fomxmd_horizontal.webp",
                    MaPhong = "P00001"
                },
                 new ImageLink
                 {
                     ImageLinkId= 2,
                     Url = "Deluxe2_y1oap9_horizontal.webp",
                     MaPhong = "P00001"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 3,
                     Url = "Deluxe3_5wufjk_horizontal.webp",
                     MaPhong = "P00002"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 4,
                     Url = "DeluxePremium3_nbft54_horizontal.webp",
                     MaPhong = "P00002"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 5,
                     Url = "HLC-64_gr3tad_horizontal_kd7412_horizontal.webp",
                     MaPhong = "P00003"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 6,
                     Url = "HLC-65_162rzy_horizontal_68gd8e_horizontal.webp",
                     MaPhong = "P00003"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 7,
                     Url = "HLC-71_gx38pc_horizontal_atp0eq_horizontal.webp",
                     MaPhong = "P00003"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 8,
                     Url = "HLC-72_7i5du6_horizontal_4ka00z_horizontal.webp",
                     MaPhong = "P00003"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 9,
                     Url = "HLC-75_ueo7hb_horizontal_cichzd_horizontal.webp",
                     MaPhong = "P00004"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 10,
                     Url = "HLC-77_bun0l5_horizontal_7rl43c_horizontal.webp",
                     MaPhong = "P00004"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 11,
                     Url = "HLC-90_z82lws_horizontal_scaf5o_horizontal.webp",
                     MaPhong = "P00004"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 12,
                     Url = "HLC-92_g5s1jd_horizontal_2sxis1_horizontal.webp",
                     MaPhong = "P00004"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 13,
                     Url = "HLC-101_fjad9s_horizontal_v4iia9_horizontal.webp",
                     MaPhong = "P00005"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 14,
                     Url = "HLC-108_xzs4v9_horizontal_uhmq5c_horizontal.webp",
                     MaPhong = "P00005"
                 },
                 new ImageLink
                 {
                     ImageLinkId= 15,
                     Url = "HLC-112_dv5czy_horizontal_qliyr2_horizontal.webp",
                     MaPhong = "P00005"
                 }
                );

            modelBuilder.Entity<DichVu>().HasData(
              new DichVu
              {
                  MaDichVu = "DV001",
                  TenDichVu = "Giặt ủi",
                  DonViTinh = "Kg",
                  GiaTien = 20000,
                  TinhTrang = "Hoạt động",
                  GioBatDauDichVu = new TimeSpan(8, 0, 0), // 08:00
                  GioKetThucDichVu = new TimeSpan(20, 0, 0) // 20:00
              },
              new DichVu
              {
                  MaDichVu = "DV002",
                  TenDichVu = "Đưa đón sân bay",
                  DonViTinh = "Lượt",
                  GiaTien = 200000,
                  TinhTrang = "Hoạt động",
                  GioBatDauDichVu = new TimeSpan(6, 0, 0), // 06:00
                  GioKetThucDichVu = new TimeSpan(22, 0, 0) // 22:00
              },
              new DichVu
              {
                  MaDichVu = "DV003",
                  TenDichVu = "Dọn phòng",
                  DonViTinh = "Lần",
                  GiaTien = 50000,
                  TinhTrang = "Hoạt động",
                  GioBatDauDichVu = new TimeSpan(6, 0, 0), // 06:00
                  GioKetThucDichVu = new TimeSpan(22, 0, 0) // 22:00
              },
              new DichVu
              {
                  MaDichVu = "DV004",
                  TenDichVu = "Ăn sáng",
                  DonViTinh = "Người",
                  GiaTien = 50000,
                  TinhTrang = "Hoạt động",
                  GioBatDauDichVu = new TimeSpan(6, 0, 0), // 06:00
                  GioKetThucDichVu = new TimeSpan(22, 0, 0) // 22:00
              },
              new DichVu
              {
                  MaDichVu = "DV005",
                  TenDichVu = "Thuê xe máy",
                  DonViTinh = "Xe",
                  GiaTien = 120000,
                  TinhTrang = "Hoạt động",
                  GioBatDauDichVu = new TimeSpan(6, 0, 0), // 06:00
                  GioKetThucDichVu = new TimeSpan(22, 0, 0) // 22:00
              }
         );

           
           

            
           

            modelBuilder.Entity<VatTu>().HasData(
              new VatTu
              {
                  MaVatTu = "VT001",
                  TenVatTu = "Giường",
                  TinhTrangVatTu = ".",
                  NgayThem = DateTime.Now,
                  NhaSanXuat="Nội Thất Minh Nhật"
              },
              new VatTu
              {
                  MaVatTu = "VT002",
                  TenVatTu = "Bàn",
                  TinhTrangVatTu = ".",
                  NgayThem = DateTime.Now,
                  NhaSanXuat="Cửa Hàng Đồ Gỗ Minh Quốc"
              },
              new VatTu
              {
                  MaVatTu = "VT003",
                  TenVatTu = "Ghế",
                  TinhTrangVatTu = ".",
                  NgayThem = DateTime.Now,
                  NhaSanXuat="Cửa Hàng Đồ Gỗ Minh Quốc"
              },
              new VatTu
              {
                  MaVatTu = "VT004",
                  TenVatTu = "Đèn ngủ",
                  TinhTrangVatTu = ".",
                  NgayThem = DateTime.Now,
                  NhaSanXuat="Đèn trang chí Lan Anh"
              },
              new VatTu
              {
                  MaVatTu = "VT005",
                  TenVatTu = "Rèm",
                  TinhTrangVatTu = ".",
                  NgayThem = DateTime.Now,
                  NhaSanXuat="Rèm xinh Bmt"
              }
          );
           
        }
    }
}
