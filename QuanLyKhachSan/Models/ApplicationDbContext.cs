using Microsoft.EntityFrameworkCore;

namespace QuanLyKhachSan.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan
                {
                    TenDangNhap = "admin",
                    Email = "admin123@gmai.com",
                    MatKhau = "admin",
                    TenNguoiSuDung = "Trương Minh Nhựt",
                    SoDienThoai = "0394858697",
                    NgaySinh = new DateTime(2004, 9, 29), // Corrected date format
                    GioiTinh = "Nam",
                    NgayTaoTaiKhoan = DateTime.Now
                },
                new TaiKhoan
                {
                    TenDangNhap = "user",
                    MatKhau = "user",
                    Email = "user123@gmai.com",
                    TenNguoiSuDung = "Trương Minh Nhựt",
                    SoDienThoai = "0394858697",
                    NgaySinh = new DateTime(2004, 9, 29), // Corrected date format
                    GioiTinh = "Nam",
                    NgayTaoTaiKhoan = DateTime.Now
                }
            );

            //modelBuilder.Entity<NhanVien>().HasData(
            //    new NhanVien
            //    {
            //        MaNhanVien = "NV0001",
            //        Email = "nhutbmt82@gmail.com",
            //        TenNhanVien = "Trương Minh Nhựt",
            //        DiaChi = "Hòa Thuận",
            //        SoDienThoai = "0938485965",
            //        CCCD = "123456789012",
            //        GioiTinh = "Nam",
            //        NgaySinh = new DateTime(2004, 9, 29), // Corrected date format
            //        NgayDangKy = new DateTime(2022, 9, 29), // Corrected date format
            //        ChucVu = "Quản lý",
            //        NgayVaoLam = new DateTime(2023, 9, 29), // Corrected date format
            //        AnhNhanVien = "123"
            //    }
            //);
        }


    }
}
