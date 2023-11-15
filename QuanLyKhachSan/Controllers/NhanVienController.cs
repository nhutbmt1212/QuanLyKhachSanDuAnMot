using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly ApplicationDbContext _db;
        public NhanVienController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult TrangChuNhanVien()
        {
            var listNhanVien = _db.NhanVien.ToList();
            return View(listNhanVien);
        }
        [HttpPost] // Đánh dấu phương thức này như một phương thức POST
        [ValidateAntiForgeryToken] // Ngăn chặn tấn công giả mạo yêu cầu đến trang web

        public IActionResult ThemNhanVien(NhanVien nv, [FromServices] IWebHostEnvironment hostingEnvironment)
        {
            if (nv.AnhNhanVien != null && nv.AnhNhanVien.Length > 0) // Kiểm tra xem người dùng có tải lên ảnh không
            {
                var uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "UploadImage"); // Xác định thư mục tải lên
                if (!Directory.Exists(uploadFolder)) // Kiểm tra xem thư mục đã tồn tại chưa
                {
                    Directory.CreateDirectory(uploadFolder); // Nếu không, tạo thư mục
                }

                var filePath = Path.Combine(uploadFolder, nv.AnhNhanVien.FileName); // Xác định đường dẫn đầy đủ của file

                // Kiểm tra xem file đã tồn tại chưa
                if (!System.IO.File.Exists(filePath)) // Nếu file chưa tồn tại
                {
                    using (var stream = new FileStream(filePath, FileMode.Create)) // Tạo một stream để ghi file
                    {
                        nv.AnhNhanVien.CopyTo(stream); // Sao chép nội dung của file tải lên vào stream
                    }
                }

                // Lưu đường dẫn tương đối của file vào cơ sở dữ liệu
                nv.AnhNhanVienBase64 = Path.Combine("UploadImage", nv.AnhNhanVien.FileName);

                _db.NhanVien.Add(nv); // Thêm nhân viên mới vào cơ sở dữ liệu
                _db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }

            return RedirectToAction("TrangChuNhanVien", "NhanVien"); // Chuyển hướng người dùng về trang chủ nhân viên
        }


        public IActionResult XoaNhanVien(string id)
        {
            var qr_NhanVien = _db.NhanVien.Find(id);
            if (qr_NhanVien != null)
            {
                _db.NhanVien.Remove(qr_NhanVien);
                _db.SaveChanges();

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("TrangChuNhanVien", "NhanVien");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaNhanVien(NhanVien nv, [FromServices] IWebHostEnvironment hostingEnvironment)
        {          
            var existingEmployee = _db.NhanVien.Find(nv.MaNhanVien);

            if (nv.AnhNhanVien == null)
            {
                if (existingEmployee != null)
                {
                  
                    nv.AnhNhanVienBase64 = existingEmployee.AnhNhanVienBase64;
                    _db.Entry(existingEmployee).CurrentValues.SetValues(nv);
                    _db.SaveChanges();
                }
               
            }
            else
            {
                //xác định thư mục tải lên 
                var upLoadFolder = Path.Combine(hostingEnvironment.WebRootPath, "UpLoadImage");
                //kiểm tra thư mục đã tồn tại chưa
                if (!Directory.Exists(upLoadFolder))
                {
                    Directory.CreateDirectory(upLoadFolder);
                }
                var filePath = Path.Combine(upLoadFolder, nv.AnhNhanVien.FileName);
                //kiểm tra file đã tồn tại trong folder chưa
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        nv.AnhNhanVien.CopyTo(stream);
                    }

                }
                nv.AnhNhanVienBase64 = Path.Combine("UpLoadImage", nv.AnhNhanVien.FileName);
                _db.Entry(existingEmployee).CurrentValues.SetValues(nv);
                _db.SaveChanges();
            }
            return RedirectToAction("TrangChuNhanVien", "NhanVien");
        }

    }
}
