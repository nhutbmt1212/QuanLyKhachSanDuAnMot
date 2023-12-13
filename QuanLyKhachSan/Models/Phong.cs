using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    public class Phong
    {
        [Key]
        [StringLength(6)]
        public string MaPhong { get; set; }
        [StringLength(6)]
        [ForeignKey("MaLoaiPhong")]
        public LoaiPhong LoaiPhong { get; set; }
        public string MaLoaiPhong { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime NgayTao { get; set; }
        [StringLength(20)]
        public string TinhTrang { get; set; }
        public ICollection<ImageLink> ImageLinks { get; set; }
    }
}
