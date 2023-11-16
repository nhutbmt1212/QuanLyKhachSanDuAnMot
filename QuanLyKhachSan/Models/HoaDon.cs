using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    public class HoaDon
    {
        [Key]
        [StringLength(6)]
        public string MaHoaDon { get; set; }
        [StringLength(6)]
        public string MaDatPhong { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ThoiGianThanhToan { get; set; }
        [StringLength(6)]
        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }
        public string MaNhanVien { get; set; }
        public int TongTienDichVu { get; set; }
        public int TongTienPhong { get; set; }
        public int SoTienThanhToan { get; set; }
    }
}
