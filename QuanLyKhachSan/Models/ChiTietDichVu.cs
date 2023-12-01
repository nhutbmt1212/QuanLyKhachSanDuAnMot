using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    public class ChiTietDichVu
    {
        [Key, Column(Order = 0)]
        [StringLength(6)]
        public string MaDichVu { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(6)]
        public string MaKhachHang { get; set; }

        [ForeignKey("MaDichVu")]
        public DichVu DichVu { get; set; }

        [ForeignKey("MaKhachHang")]
        public KhachHang KhachHang { get; set; }

        public int SoLuong { get; set; }

        [StringLength(6)]
        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }
        public string MaNhanVien { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ThoiGianDichVu { get; set; }

        [StringLength(30)]
        public string TrangThai { get; set; }
        [StringLength(6)]
        [ForeignKey("MaDatPhong")]
        public DatPhong DatPhong { get; set; }
        public string MaDatPhong { get; set; }
    }
}
