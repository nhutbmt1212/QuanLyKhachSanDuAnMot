using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class PhongController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhongController(ApplicationDbContext db)
        {
            _db = db;
        }
        //comment
        public IActionResult TrangChuPhong()
        {
            var listPhong = _db.Phong.Include(p => p.ImageLinks).Where(s=>s.TinhTrang!="Đã xóa").ToList();
            ViewBag.DanhSachPhong = listPhong;
            var listLoaiPhong = _db.LoaiPhong.ToList();
            ViewBag.DanhSachLoaiPhong = listLoaiPhong;
            return View(listPhong);
        }
        [HttpGet]
        public async Task<IActionResult> GetImages(string MaPhong)
        {
            var phong = await _db.Phong
                .Include(p => p.ImageLinks)
                .FirstOrDefaultAsync(p => p.MaPhong == MaPhong);

            if (phong == null)
            {
                return NotFound();
            }

            return Json(phong.ImageLinks.Select(il => il.Url));
        }
        [HttpPost]
        public async Task<IActionResult> LuuPhongVaAnh([FromForm] Phong phong, [FromForm] List<IFormFile> Imageurl)
        {
            var images = new List<ImageLink>();

            foreach (var image in Imageurl)
            {
                var fileName = Path.GetFileName(image.FileName);
                var path = Path.Combine("wwwroot", "UploadImage", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                var relativePath = $"{fileName}";
                images.Add(new ImageLink { Url = relativePath });
            }
            phong.TinhTrang = "Đang hoạt động";
            phong.KhuVuc = "A";

            phong.ImageLinks = images;

            _db.Phong.Add(phong);
            await _db.SaveChangesAsync();

            return RedirectToAction("TrangChuPhong", "Phong");
        }



        [HttpPost]
        public async Task<IActionResult> SuaAnh(string phongId, List<string> editedImageUrls)
        {
            var phong = await _db.Phong
                .Include(p => p.ImageLinks)
                .FirstOrDefaultAsync(p => p.MaPhong == phongId);

            if (phong == null)
            {
                return NotFound();
            }

            // Update the existing images with the edited URLs
            phong.ImageLinks.Clear();

            foreach (var editedImageUrl in editedImageUrls)
            {
                phong.ImageLinks.Add(new ImageLink { Url = editedImageUrl });
            }

            await _db.SaveChangesAsync();

            return View("Index");
        }
        public IActionResult XoaPhong(string MaPhong)
        {
            var qr_maPhong = _db.Phong.FirstOrDefault(s => s.MaPhong == MaPhong);
            if (qr_maPhong != null)
            {
                qr_maPhong.TinhTrang = "Đã xóa";
                _db.Phong.Update(qr_maPhong);
                _db.SaveChanges();
            }
            return RedirectToAction("TrangChuPhong");
        }
    }

}

