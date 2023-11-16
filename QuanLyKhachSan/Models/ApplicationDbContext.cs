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
        }
    }
}
