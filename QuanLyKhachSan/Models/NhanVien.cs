using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace QuanLyKhachSan.Models
{
    public class NhanVien
    {
        [Key]
        [StringLength(6)]
        public string MaNhanVien { get; set; }
        [StringLength(50)]
        public string TenNhanVien { get; set; }
        [StringLength(10)]
        public string SoDienThoai { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(12)]
        public string CCCD { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(3)]
        public string GioiTinh { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayDangKy { get; set; }

        [StringLength(15)]
        public string ChucVu { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayVaoLam { get; set; }
        [NotMapped]
        public IFormFile AnhNhanVien { get; set; }

        public string AnhNhanVienBase64 { get; set; }
        [StringLength(20)]
        public string TinhTrang {  get; set; }
        [StringLength(30)]
        [DataType(DataType.Password)]
        public string MatKhau {  get; set; }

    
    }
}
