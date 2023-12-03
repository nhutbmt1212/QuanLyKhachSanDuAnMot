using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;
using System.Data;
using OfficeOpenXml;
using System.ComponentModel;
using LicenseContext = OfficeOpenXml.LicenseContext;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace QuanLyKhachSan.Controllers
{
    [Authorize]
    public class NhanVienController : Controller
    {
        private const string V = "Hello";
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
            //lỗi không nhận mã nhân viên
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
        //public async Task<IActionResult> ExportPDF()
        //{
        //    // Tạo một tài liệu PDF mới
        //    Document pdfDoc = new Document();
        //    MemoryStream memoryStream = new MemoryStream();
        //    PdfWriter.GetInstance(pdfDoc, memoryStream);

        //    // Lấy danh sách nhân viên
        //    var nhanvien = _db.NhanVien.ToList();

        //    pdfDoc.Open();

        //    float cm = 20; // Độ rộng mong muốn bằng cm
        //    float points = cm * 72 / 2.54f; // Chuyển đổi cm sang points


        //    // Tạo một bảng để lưu trữ dữ liệu khách hàng
        //    PdfPTable table = new PdfPTable(15);
        //    table.SetTotalWidth(new float[] { points, points, points, points, points, points, points, points, points, points, points, points, points, points, points });

        //    // Tạo một font cho tiêu đề
        //    Font headerFont = FontFactory.GetFont("Arial", 12, Font.BOLD, BaseColor.WHITE);
        //    BaseColor headerBackgroundColor = new BaseColor(0, 119, 119);

        //    // Thêm tiêu đề cho các cột
        //    string[] headers = { "Mã Nhân Viên", "Tên Nhân Viên", "CCCD", "Giới tính", "Ngày sinh", "Điện thoại", "Địa chỉ", "Chức Vụ", "Ngày Vào Làm", "Tình trạng", "Tên đăng nhập", "Mật khẩu", "Ảnh nhân viên", "Email", "Ngày đăng ký" };

        //    foreach (var header in headers)
        //    {
        //        PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
        //        cell.BackgroundColor = headerBackgroundColor;
        //        table.AddCell(cell);
        //    }

        //    // Tạo một font cho nội dung
        //    Font contentFont = FontFactory.GetFont("Arial", 10, Font.NORMAL, BaseColor.BLACK);

        //    foreach (var nv in nhanvien)
        //    {
        //        table.AddCell(nv.MaNhanVien.ToString());
        //        table.AddCell(nv.TenDangNhap.ToString());
        //        table.AddCell(nv.CCCD.ToString());
        //        table.AddCell(nv.GioiTinh.ToString());
        //        table.AddCell(nv.NgaySinh.ToShortDateString());
        //        table.AddCell(nv.SoDienThoai.ToString());
        //        table.AddCell(nv.DiaChi.ToString());
        //        table.AddCell(nv.ChucVu.ToString());
        //        table.AddCell(nv.NgayVaoLam.ToShortDateString());
        //        table.AddCell(nv.TinhTrang.ToString());
        //        table.AddCell(nv.TenDangNhap.ToString());
        //        table.AddCell(nv.MatKhau.ToString());
        //        table.AddCell(nv.AnhNhanVienBase64.ToString());
        //        table.AddCell(nv.Email.ToString());
        //        table.AddCell(nv.NgayDangKy.ToShortDateString());

        //    }
        //    // Thêm bảng vào tài liệu PDF
        //    pdfDoc.Add(table);

        //    pdfDoc.Close();

        //    byte[] bytes = memoryStream.ToArray();
        //    memoryStream.Close();

        //    return File(bytes, "application/pdf", "NhanVien.pdf");
        //}
        public async Task<IActionResult> ExportPDF()
        {
            // Tạo một tài liệu PDF mới
            Document pdfDoc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);

            // Lấy danh sách nhân viên
            var nhanvien = _db.NhanVien.ToList();

            pdfDoc.Open();
            float cm = 20; // Độ rộng mong muốn bằng cm
            float points = cm * 72 / 2.54f; // Chuyển đổi cm sang points

            // Giảm độ rộng của cột thứ 3 xuống 75%
            float pointsForFourthColumn = points * 0.75f;
            float pointsForThirdhColumn = points * 1.25f;
            float pointsForConditionhColumn = points * 1.15f;
            // Tạo một bảng để lưu trữ dữ liệu khách hàng
            PdfPTable table = new PdfPTable(15);
            table.SetTotalWidth(new float[] { points, points, pointsForThirdhColumn, pointsForFourthColumn, pointsForThirdhColumn, pointsForThirdhColumn, points, points, pointsForThirdhColumn, pointsForConditionhColumn, points, pointsForThirdhColumn, points, points, pointsForThirdhColumn });


            // Tạo một font
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            

            // Tạo một font cho tiêu đề
            Font headerFont = FontFactory.GetFont("Arial", 5, Font.BOLD, BaseColor.WHITE);
            BaseColor headerBackgroundColor = new BaseColor(0, 119, 119);

            // Thêm tiêu đề cho các cột
            string[] headers = { "ID", "Name", "Idpersonal", "Sex", "Day of birth", "Phone number", "Address", "Duty", "Date of entry", "Condition", "UserName", "Password", "Image", "Email", "Date of registration" };
           
            foreach (var header in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                cell.BackgroundColor = headerBackgroundColor;
                table.AddCell(cell);
            }

            // Tạo một font cho nội dung
            Font contentFont = FontFactory.GetFont("Arial", 5, Font.NORMAL, BaseColor.BLACK);

            foreach (var nv in nhanvien)
            {
                table.AddCell(new Phrase(nv.MaNhanVien.ToString(), contentFont));
                table.AddCell(new Phrase(nv.TenDangNhap.ToString(), contentFont));
                table.AddCell(new Phrase(nv.CCCD.ToString(), contentFont));
                table.AddCell(new Phrase(nv.GioiTinh.ToString(), contentFont));
                table.AddCell(new Phrase(nv.NgaySinh.ToShortDateString(), contentFont));
                table.AddCell(new Phrase(nv.SoDienThoai.ToString(), contentFont ));
                table.AddCell(new Phrase(nv.DiaChi.ToString(), contentFont  ));
                table.AddCell(new Phrase(nv.ChucVu.ToString() , contentFont));
                table.AddCell(new Phrase(nv.NgayVaoLam.ToShortDateString(), contentFont));
                table.AddCell(new Phrase(nv.TinhTrang.ToString(), contentFont));
                table.AddCell(new Phrase(nv.TenDangNhap.ToString(), contentFont));
                table.AddCell(new Phrase(nv.MatKhau.ToString(), contentFont));
                table.AddCell(new Phrase(nv.AnhNhanVienBase64.ToString(), contentFont));
                table.AddCell(new Phrase(nv.Email.ToString(), contentFont));
                table.AddCell(new Phrase(nv.NgayDangKy.ToShortDateString(), contentFont));
            }

            // Thêm bảng vào tài liệu PDF
            pdfDoc.Add(table);

            pdfDoc.Close();

            byte[] bytes = memoryStream.ToArray();
            memoryStream.Close();

            return File(bytes, "application/pdf", "NhanVien.pdf");
        }



    }


}

