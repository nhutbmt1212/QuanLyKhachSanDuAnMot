using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{

    public class TaiKhoan
    {
        [Key]
        public string TenDangNhap { get; set; }

        public string Email { get; set; }


        [Required]
        public string MatKhau { get; set; }

        [StringLength(55)]
        public string TenNguoiSuDung { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public DateTime NgayTaoTaiKhoan { get; set; }
        public bool LuuMatKhau { get; set; }
    }
}
