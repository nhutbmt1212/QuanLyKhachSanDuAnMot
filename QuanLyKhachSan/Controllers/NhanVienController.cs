using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;
using System.Data;
using OfficeOpenXml;
using System.ComponentModel;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanLyKhachSan.Controllers
{
    [Authorize]
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
                nv.TinhTrang = "Hoat Dong";
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

        public ActionResult ExportExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Đặt bản quyền cho EPPlus
            using (ExcelPackage pck = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("NhanVien");

                // Lấy danh sách 
                var nhanvien = _db.NhanVien.ToList();

                // Tạo một bảng để lưu trữ dữ liệu 
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("Mã Nhân Viên");
                dataTable.Columns.Add("Tên Nhân Viên");
                dataTable.Columns.Add("CCCD");
                dataTable.Columns.Add("Giới tính");
                dataTable.Columns.Add("Ngày sinh");
                dataTable.Columns.Add("Điện thoại");
                dataTable.Columns.Add("Địa chỉ");
                dataTable.Columns.Add("Chức Vụ");
                dataTable.Columns.Add("Ngày Vào Làm");
                dataTable.Columns.Add("Tình trạng");
                dataTable.Columns.Add("Tên đăng nhập");
                dataTable.Columns.Add("Mật khẩu");
                dataTable.Columns.Add("Ảnh nhân viên");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Ngày đăng ký");
                // Thêm dữ liệu  vào bảng
                foreach (var nv in nhanvien)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = nv.MaNhanVien;
                    dataRow[1] = nv.TenNhanVien;
                    dataRow[2] = nv.CCCD;
                    dataRow[3] = nv.GioiTinh;
                    dataRow[4] = nv.NgaySinh;
                    dataRow[5] = nv.SoDienThoai;
                    dataRow[6] = nv.DiaChi;
                    dataRow[7] = nv.ChucVu;
                    dataRow[8] = nv.NgayVaoLam;
                    dataRow[9] = nv.TinhTrang;
                    dataRow[10] = nv.TenDangNhap;
                    dataRow[11] = nv.MatKhau;
                    dataRow[12] = nv.AnhNhanVienBase64;
                    dataRow[13] = nv.Email;
                    dataRow[14] = nv.NgayDangKy.ToShortDateString();
                    dataTable.Rows.Add(dataRow);
                }

                // Thêm dữ liệu từ bảng vào worksheet
                ws.Cells["A1"].LoadFromDataTable(dataTable, true);

                // Gửi file Excel về client
                var stream = new MemoryStream(pck.GetAsByteArray());

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NhanVien.xlsx");
            }
        }
        public async Task<IActionResult> Import(IFormFile formFile)
        {
            if (formFile == null || formFile.Length <= 0)
            {
                return BadRequest("Chọn một file để nhập dữ liệu.");
            }

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("Chỉ hỗ trợ file .xlsx");
            }

           
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Sử dụng sheet đầu tiên
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var list = new NhanVien();
                        list.MaNhanVien = worksheet.Cells[row, 1].Value.ToString().Trim();
                        list.TenNhanVien = worksheet.Cells[row, 2].Value.ToString().Trim();
                            list.CCCD = worksheet.Cells[row, 3].Value.ToString().Trim();
                            list.GioiTinh = worksheet.Cells[row, 4].Value.ToString().Trim();
                        if (DateTime.TryParse(worksheet.Cells[row, 5].Value.ToString().Trim(), out DateTime ngaySinh))
                        {
                            list.NgaySinh = ngaySinh;
                        }
                        //list.NgaySinh = new DateTime(01 / 01 / 2000);
                        list.SoDienThoai = worksheet.Cells[row, 6].Value.ToString().Trim();
                            list.DiaChi = worksheet.Cells[row, 7].Value.ToString().Trim();
                            list.ChucVu = worksheet.Cells[row, 8].Value.ToString().Trim();
                        if (DateTime.TryParse(worksheet.Cells[row, 9].Value.ToString().Trim(), out DateTime ngayVaoLam))
                        {
                            list.NgayVaoLam = ngayVaoLam;
                        }
                        //list.NgayVaoLam = new DateTime(01 / 01 / 2000);
                        list.TinhTrang = worksheet.Cells[row, 10].Value.ToString().Trim();
                            list.TenDangNhap = worksheet.Cells[row, 11].Value.ToString();
                            list.MatKhau = worksheet.Cells[row, 12].Value.ToString();
                            list.AnhNhanVienBase64 = worksheet.Cells[row, 13].Value.ToString().Trim();
                            list.Email = worksheet.Cells[row, 14].Value.ToString().Trim();
                        if (DateTime.TryParse(worksheet.Cells[row, 15].Value.ToString().Trim(), out DateTime ngayDangKy))
                        {
                            list.NgayDangKy = ngayDangKy;
                        }
                        //list.NgayDangKy = new DateTime(01 / 01 / 2000);
                        _db.NhanVien.Add(list);
                        _db.SaveChanges();


                    }
                    
                }
            return RedirectToAction("TrangChuNhanVien", "NhanVien");
        }

         

           
    }



    }


}

