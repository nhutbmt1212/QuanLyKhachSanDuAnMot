using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    [PrimaryKey(nameof(TenDangNhap), nameof(Email))]
    public class TaiKhoan
    {
        [Column(Order = 0)]
        public string TenDangNhap { get; set; }
        [Column(Order = 1)]
        public string Email { get; set; }
        [Required]
        public string MatKhau { get; set; }
    }
}
