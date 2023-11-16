using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.Models
{
    public class LoaiPhong
    {
        [Key]
        [StringLength(6)]
        public string MaLoaiPhong { get; set; }
        [StringLength(20)]
        public string TenLoaiPhong { get; set; }
        public int GiaTheoGio { get; set; }
        public int GiaPhongTheoNgay { get; set; }
        public int PhuThuTraMuon { get; set; }
        public int SoLuongNguoiLon { get; set; }
        public int SoLuongTreEm { get; set; }
    }
}
