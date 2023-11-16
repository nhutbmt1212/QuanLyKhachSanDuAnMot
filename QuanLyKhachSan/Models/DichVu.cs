using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.Models
{
    public class DichVu
    {
        [Key]
        [StringLength(6)]
        public string MaDichVu { get; set; }
        [StringLength(30)]
        public string TenDichVu { get; set; }
        [StringLength(30)]
        public string DonViTinh { get; set; }
        public int GiaTien { get; set; }
        [StringLength(30)]
        public string TinhTrang { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime GioDichVu { get; set; }
    }
}
