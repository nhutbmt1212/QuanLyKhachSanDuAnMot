using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using QuanLyKhachSan.Models;
using System.Data;

namespace QuanLyKhachSan.Controllers
{
    [Authorize]

    public class KhachHangController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();
        public KhachHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult DanhSachKhachHang()
        {
            var listKhachHang = _db.KhachHang.Where(s=>s.TinhTrang!="Đã xóa").ToList();
            return View(listKhachHang);
        }
        public IActionResult XoaKhachHang(string id)
        {
            var qr_MaKh = _db.KhachHang.Find(id);
            if (qr_MaKh != null)
            {
                qr_MaKh.TinhTrang = "Đã xóa";
                _db.KhachHang.Update(qr_MaKh);
                _db.SaveChanges();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa khách hàng thành công";
            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("DanhSachKhachHang", "KhachHang");
        }

        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.KhachHang.Any(d => d.MaKhachHang == $"KH{randomString}"));

            return $"KH{randomString}";
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemKhachHang(KhachHang kh)
        {

            if (_db.KhachHang.Any(d => d.MaKhachHang == kh.MaKhachHang))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm khách hàng thất bại Mã khách hàng bị trùng";
                return RedirectToAction("DanhSachKhachHang", "KhachHang");
            }
            kh.MaKhachHang = GenerateRandomCode();
            kh.TinhTrang = "Đang hoạt động";
            kh.NgayDangKy = DateTime.Now;
        
              
                _db.KhachHang.Add(kh);
                _db.SaveChanges();
       

            return RedirectToAction("DanhSachKhachHang", "KhachHang");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaKhachHang(KhachHang kh)
        {
           //còn lỗi ngày đăng ký chưa lấy từ đb
                _db.KhachHang.Update(kh);
               _db.SaveChanges();
            

            return RedirectToAction("DanhSachKhachHang", "KhachHang");

        }
        public ActionResult ExportExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Đặt bản quyền cho EPPlus
            using (ExcelPackage pck = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("KhachHang");

                // Lấy danh sách 
                var nhanvien = _db.KhachHang.ToList();

                // Tạo một bảng để lưu trữ dữ liệu 
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("Mã Khách Hàng");
                dataTable.Columns.Add("Tên Khách Hàng");
                dataTable.Columns.Add("Số điện thoại");
                dataTable.Columns.Add("Địa chỉ");
                dataTable.Columns.Add("CCCD");
                dataTable.Columns.Add("Ngày sinh");
                dataTable.Columns.Add("Giới tính");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Tình trạng");
                dataTable.Columns.Add("Mật khẩu");
                dataTable.Columns.Add("Ngày đăng ký");
                // Thêm dữ liệu  vào bảng
                foreach (var nv in nhanvien)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = nv.MaKhachHang;
                    dataRow[1] = nv.TenKhachHang;
                    dataRow[2] = nv.SoDienThoai;
                    dataRow[3] = nv.DiaChi;
                    dataRow[4] = nv.CCCD;
                    dataRow[5] = nv.NgaySinh.ToShortDateString();
                    dataRow[6] = nv.GioiTinh;
                    dataRow[7] = nv.Email;
                    dataRow[8] = nv.TinhTrang;
                    dataRow[9] = nv.MatKhau;
                    dataRow[10] = nv.NgayDangKy.ToShortDateString();
                    dataTable.Rows.Add(dataRow);
                }

                // Thêm dữ liệu từ bảng vào worksheet
                ws.Cells["A1"].LoadFromDataTable(dataTable, true);

                // Gửi file Excel về client
                var stream = new MemoryStream(pck.GetAsByteArray());

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "KhachHang.xlsx");
            }
        }
        public async Task<IActionResult> Import(IFormFile formFile)
        {
            if (formFile == null || formFile.Length <= 0)
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Chọn 1 file để import";
                return RedirectToAction("DanhSachKhachHang", "KhachHang");
            }

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Chỉ hỗ trợ file .xlsx";
                return RedirectToAction("DanhSachKhachHang", "KhachHang");
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var stream = new MemoryStream())
            {
                await formFile.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Sử dụng sheet đầu tiên
                    var rowCount = worksheet.Dimension.Rows;

                    List<int> errorRows = new List<int>();

                    for (int row = 2; row <= rowCount; row++)
                    {
                        // Kiểm tra dòng trống
                        if (worksheet.Cells[row, 1].Value == null || worksheet.Cells[row, 2].Value == null || worksheet.Cells[row, 3].Value == null || worksheet.Cells[row, 4].Value == null || worksheet.Cells[row, 5].Value == null || worksheet.Cells[row, 6].Value == null || worksheet.Cells[row, 7].Value == null || worksheet.Cells[row, 8].Value == null || worksheet.Cells[row, 9].Value == null || worksheet.Cells[row, 10].Value == null || worksheet.Cells[row, 11].Value == null)
                        {
                            errorRows.Add(row);
                            continue;
                        }

                        var MaKhachHang = worksheet.Cells[row, 1].Value.ToString().Trim();
                        var TenKhachHang = worksheet.Cells[row, 2].Value.ToString().Trim();
                        var SoDienThoai = worksheet.Cells[row, 3].Value.ToString().Trim();
                        var DiaChi = worksheet.Cells[row, 4].Value.ToString().Trim();
                        var CCCD = worksheet.Cells[row, 5].Value.ToString().Trim();
                        DateTime ngaySinh;
                        DateTime.TryParse(worksheet.Cells[row, 6].Value.ToString().Trim(), out ngaySinh);
                        var GioiTinh = worksheet.Cells[row, 7].Value.ToString().Trim();
                        var Email = worksheet.Cells[row, 8].Value.ToString().Trim();
                        var TinhTrang = worksheet.Cells[row, 9].Value.ToString().Trim();
                        var MatKhau = worksheet.Cells[row, 10].Value.ToString().Trim();
                        DateTime ngayDangKy;
                        DateTime.TryParse(worksheet.Cells[row, 11].Value.ToString().Trim(), out ngayDangKy);

                        var khachHang = _db.KhachHang.FirstOrDefault(kh => kh.MaKhachHang == MaKhachHang);
                        if (khachHang != null)
                        {
                            // Cập nhật khách hàng
                            khachHang.TenKhachHang = TenKhachHang;
                            khachHang.SoDienThoai = SoDienThoai;
                            khachHang.DiaChi = DiaChi;
                            khachHang.CCCD = CCCD;
                            khachHang.NgaySinh = ngaySinh;
                            khachHang.GioiTinh = GioiTinh;
                            khachHang.Email = Email;
                            khachHang.TinhTrang = TinhTrang;
                            khachHang.MatKhau = MatKhau;
                            khachHang.NgayDangKy = ngayDangKy;
                        }
                        else
                        {
                            // Thêm khách hàng mới
                            var list = new KhachHang
                            {
                                MaKhachHang = MaKhachHang,
                                TenKhachHang = TenKhachHang,
                                SoDienThoai = SoDienThoai,
                                DiaChi = DiaChi,
                                CCCD = CCCD,
                                NgaySinh = ngaySinh,
                                GioiTinh = GioiTinh,
                                Email = Email,
                                TinhTrang = TinhTrang,
                                MatKhau = MatKhau,
                                NgayDangKy = ngayDangKy
                            };
                            _db.KhachHang.Add(list);
                        }
                        _db.SaveChanges();
                    }

                    if (errorRows.Count > 0)
                    {
                        TempData["SwalIcon"] = "error";
                        TempData["SwalTitle"] = $"Có lỗi ở các dòng: {string.Join(", ", errorRows)}. Vui lòng kiểm tra lại file Excel của bạn.";
                        return RedirectToAction("DanhSachKhachHang", "KhachHang");
                    }
                }
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Import file thành công";
                return RedirectToAction("DanhSachKhachHang", "KhachHang");
            }
        }

        public async Task<IActionResult> ExportPDF()
        {
            // Tạo một tài liệu PDF mới
            Document pdfDoc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);

            // Lấy danh sách nhân viên
            var nhanvien = _db.KhachHang.ToList();

            pdfDoc.Open();
            float cm = 20; // Độ rộng mong muốn bằng cm
            float points = cm * 72 / 2.54f; // Chuyển đổi cm sang points
            // Giảm độ rộng của cột thứ 3 xuống 75%
            float pointsForThirdhColumn = points * 1.25f;
            // Tạo một bảng để lưu trữ dữ liệu khách hàng
            PdfPTable table = new PdfPTable(11);
            table.SetTotalWidth(new float[] { pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn , pointsForThirdhColumn });


            // Tạo một font
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);



            // Tạo một font cho tiêu đề
            Font headerFont = FontFactory.GetFont("Arial", 5, Font.BOLD, BaseColor.WHITE);
            BaseColor headerBackgroundColor = new BaseColor(0, 119, 119);

            // Thêm tiêu đề cho các cột
            string[] headers = { "ID", "Name", "Phone number", "Address", "Idpersonal", "Day of birth", "Sex", "Email", "Condition", "Password", "Date of registration" };

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
                table.AddCell(new Phrase(nv.MaKhachHang.ToString(), contentFont));
                table.AddCell(new Phrase(nv.TenKhachHang.ToString(), contentFont));
                table.AddCell(new Phrase(nv.SoDienThoai.ToString(), contentFont));
                table.AddCell(new Phrase(nv.DiaChi.ToString(), contentFont));
                table.AddCell(new Phrase(nv.CCCD, contentFont));
                table.AddCell(new Phrase(nv.NgaySinh.ToShortDateString().ToString(), contentFont));
                table.AddCell(new Phrase(nv.GioiTinh.ToString(), contentFont));
                table.AddCell(new Phrase(nv.Email.ToString(), contentFont));
                table.AddCell(new Phrase(nv.TinhTrang, contentFont));
                table.AddCell(new Phrase(nv.MatKhau.ToString(), contentFont));
                table.AddCell(new Phrase(nv.NgayDangKy.ToShortDateString().ToString(), contentFont));
            }

            // Thêm bảng vào tài liệu PDF
            pdfDoc.Add(table);

            pdfDoc.Close();

            byte[] bytes = memoryStream.ToArray();
            memoryStream.Close();

            return File(bytes, "application/pdf", "KhachHang.pdf");
        }
        [HttpGet]
        public JsonResult CheckEmail(string email)
        {

            bool exists = EmailExists(email);

            return Json(new { exists = exists });
        }

        private bool EmailExists(string email)
        {

            return _db.KhachHang.Any(nv => nv.Email == email);
        }
        [HttpGet]
        public JsonResult CheckSoDienThoai(string sodienthoai)
        {

            bool exists = SoDienThoaiExists(sodienthoai);


            return Json(new { exists = exists });
        }

        private bool SoDienThoaiExists(string sodienthoai)
        {

            return _db.KhachHang.Any(nv => nv.SoDienThoai == sodienthoai);
        }
        [HttpGet]
       
        [HttpGet]
        public JsonResult CheckCCCD(string cccd)
        {

            bool exists = CCCDExists(cccd);


            return Json(new { exists = exists });
        }

        private bool CCCDExists(string cccd)
        {

            return _db.KhachHang.Any(nv => nv.CCCD == cccd);
        }
    }
}
