using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.Models
{
    public class ChiTietPhongVatTu
    {
        [Key, Column(Order = 0)]
        [StringLength(6)]
        public string MaVatTu { get; set; }

        [Key, Column(Order = 1)]
        [StringLength(6)]
        public string MaPhong { get; set; }

        [ForeignKey("MaVatTu")]
        public VatTu VatTu { get; set; }

        [ForeignKey("MaPhong")]
        public Phong Phong { get; set; }

        public int SoLuong { get; set; }

        [StringLength(30)]
        public string TinhTrang { get; set; }
    }
}
