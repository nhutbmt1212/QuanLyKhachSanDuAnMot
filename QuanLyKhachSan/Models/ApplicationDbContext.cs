 using Microsoft.EntityFrameworkCore;

namespace QuanLyKhachSan.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option) 
        {
            
        }
        public DbSet<TaiKhoan> TaiKhoan { get; set;}
    }
}
