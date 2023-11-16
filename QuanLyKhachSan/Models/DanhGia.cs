using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    public class DanhGia
    {
        [Key]
        [StringLength(6)]
        public string MaDanhGia { get; set; }
        [StringLength(6)]
        [ForeignKey("MaKhachHang")]
        public KhachHang KhachHang { get; set; }
        public string MaKhachHang { get; set; }
        [StringLength (100)]
        public string BinhLuan { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgayDanhGia { get; set; }
        public int DiemDanhGia { get; set; }
    }
}
