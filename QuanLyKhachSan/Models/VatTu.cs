using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.Models
{
    public class VatTu
    {
        [Key]
        [StringLength(6)]
        public string MaVatTu { get; set; }
        [StringLength(30)]
        public string TenVatTu { get; set; 
        }  [StringLength(30)]
        public string NhaSanXuat { get; set; }
        [StringLength(30)]
        public string TinhTrangVatTu { get; set; }
        [DataType(DataType.Time)]
        public DateTime NgayThem { get; set; }
    }
}
