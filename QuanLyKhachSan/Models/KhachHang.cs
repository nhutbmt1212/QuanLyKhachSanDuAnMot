using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.Models
{
    public class KhachHang
    {
        [Key]
        [StringLength(6)]
        public string MaKhachHang { get; set; }
        [StringLength(50)]
        public string TenKhachHang { get; set; }
        [StringLength(10)]
        public string SoDienThoai { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(12)]
        public string CCCD { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgaySinh { get; set; }
        [StringLength(3)]
        public string GioiTinh { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string TinhTrang { get; set; }
        [StringLength(30)]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgayDangKy { get; set; }
    }
}
