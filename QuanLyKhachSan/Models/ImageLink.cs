using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.Models
{
    public class ImageLink
    {
        public int ImageLinkId { get; set; }
        public string Url { get; set; }
        [StringLength(6)]
        [ForeignKey("MaPhong")]
        public Phong Phong { get; set; }
        public string MaPhong { get; set; }
    }
}
