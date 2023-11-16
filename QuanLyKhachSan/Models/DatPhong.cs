using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    public class DatPhong
    {
        [Key]
        [StringLength(6)]
        public string MaDatPhong { get; set; }
        [StringLength(6)]
        [ForeignKey("MaKhachHang")]
        public KhachHang KhachHang { get; set; }
        public string MaKhachHang { get; set; }
        [StringLength(6)]
        [ForeignKey("MaPhong")]
        public Phong Phong { get; set; }
        public string MaPhong { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgayNhan { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgayTra { get; set; }
        public int SoLuongNguoiLon { get; set; }
        public int SoLuongTreEm { get; set; }
        [StringLength (20)]
        public string HinhThucDatPhong { get; set; }
        public int TongTienPhong { get; set; }
        [StringLength(6)]
        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }
        public string MaNhanVien { get; set; }
        [StringLength(20)]
        public string TinhTrang { get; set; }
        public int SoTienTraTruoc { get; set; }
    }
}
