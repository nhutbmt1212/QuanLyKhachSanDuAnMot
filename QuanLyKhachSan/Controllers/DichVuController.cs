using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Org.BouncyCastle.Asn1.Cms;
using QuanLyKhachSan.Models;
using System.Data;

namespace QuanLyKhachSan.Controllers
{
	[Authorize]

	public class DichVuController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();
        public DichVuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult DanhSachDichVu()
        {
            var listDichVu = _db.DichVu.ToList();
            return View(listDichVu);
        }

        public IActionResult XoaDichVu(string id)
        {
            var qr_MaDichVu = _db.DichVu.Find(id);
            if (qr_MaDichVu != null)
            {
                _db.DichVu.Remove(qr_MaDichVu);
                _db.SaveChanges();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa dịch vụ thành công";

            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("DanhSachDichVu", "DichVu");
        }
        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.DichVu.Any(d => d.MaDichVu == $"DV{randomString}"));

            return $"DV{randomString}";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemDichVu(DichVu dv)
        {
            if (_db.DichVu.Any(d => d.MaDichVu == dv.MaDichVu))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm dịch vụ thất bại Mã dịch vụ bị trùng";
                return RedirectToAction("DanhSachDichVu", "DichVu");
            }
            dv.MaDichVu = GenerateRandomCode();
            dv.TinhTrang = "Còn hàng";
            dv.GioBatDauDichVu = TimeSpan.Parse(Request.Form["GioBatDauDichVu"]);
            dv.GioKetThucDichVu = TimeSpan.Parse(Request.Form["GioKetThucDichVu"]);
            _db.DichVu.Add(dv);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Thêm dịch vụ thành công";


            return RedirectToAction("DanhSachDichVu", "DichVu");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaDichVu(DichVu dv)
        {
            dv.GioBatDauDichVu = TimeSpan.Parse(Request.Form["GioBatDauDichVu"]);
            dv.GioKetThucDichVu = TimeSpan.Parse(Request.Form["GioKetThucDichVu"]);
            _db.DichVu.Update(dv);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Sửa dịch vụ thành công";

            return RedirectToAction("DanhSachDichVu", "DichVu");

        }
        public ActionResult ExportExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("DichVu");

                var dichvu = _db.DichVu.ToList();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("Mã Dịch Vụ");
                dataTable.Columns.Add("Tên Dịch Vụ");
                dataTable.Columns.Add("Đơn Vị Tính");
                dataTable.Columns.Add("Giá Tiền");
                dataTable.Columns.Add("Tình Trạng");
                dataTable.Columns.Add("Giờ Bắt Đầu Dịch Vụ");
                dataTable.Columns.Add("Giờ Kết Thúc Dịch Vụ");

                foreach (var dv in dichvu)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = dv.MaDichVu;
                    dataRow[1] = dv.TenDichVu;
                    dataRow[2] = dv.DonViTinh;
                    dataRow[3] = dv.GiaTien;
                    dataRow[4] = dv.TinhTrang;
                    dataRow[5] = dv.GioBatDauDichVu;
                    dataRow[6] = dv.GioKetThucDichVu;
                    dataTable.Rows.Add(dataRow);
                }

                ws.Cells["A1"].LoadFromDataTable(dataTable, true);

                var stream = new MemoryStream(pck.GetAsByteArray());

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DichVu.xlsx");
            }
        }

        public async Task<IActionResult> Import(IFormFile formFile)
        {
            if (formFile == null || formFile.Length <= 0)
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Chọn một file để nhập dữ liệu.";
                return RedirectToAction("DanhSachDichVu", "DichVu");
            }

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Chỉ hỗ trợ file .xlsx";
                return RedirectToAction("DanhSachDichVu", "DichVu");
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
                        if (worksheet.Cells[row, 1].Value == null || worksheet.Cells[row, 2].Value == null || worksheet.Cells[row, 3].Value == null || worksheet.Cells[row, 4].Value == null || worksheet.Cells[row, 5].Value == null || worksheet.Cells[row, 6].Value == null || worksheet.Cells[row, 7].Value == null)
                        {
                            errorRows.Add(row);
                            continue;
                        }

                        var MaDichVu = worksheet.Cells[row, 1].Value.ToString().Trim();
                        var TenDichVu = worksheet.Cells[row, 2].Value.ToString().Trim();
                        var DonViTinh = worksheet.Cells[row, 3].Value.ToString().Trim();
                        int GiaTien;
                        int.TryParse(worksheet.Cells[row, 4].Value.ToString().Trim(), out GiaTien); 
                        var TinhTrang = worksheet.Cells[row, 5].Value.ToString().Trim();
                        TimeSpan GioBatDauDichVu;
                        TimeSpan.TryParse(worksheet.Cells[row, 6].Value.ToString().Trim(), out GioBatDauDichVu);
                        TimeSpan GioKetThucDichVu;
                        TimeSpan.TryParse(worksheet.Cells[row, 7].Value.ToString().Trim(), out GioKetThucDichVu);

                        var dichVu = _db.DichVu.FirstOrDefault(dv => dv.MaDichVu == MaDichVu);
                        if (dichVu != null)
                        {
                            // Cập nhật dịch vụ
                            dichVu.TenDichVu = TenDichVu;
                            dichVu.DonViTinh = DonViTinh;
                            dichVu.GiaTien = GiaTien;
                            dichVu.TinhTrang = TinhTrang;
                            dichVu.GioBatDauDichVu = GioBatDauDichVu;
                            dichVu.GioKetThucDichVu = GioKetThucDichVu;
                        }
                        else
                        {
                            // Thêm dịch vụ mới
                            var list = new DichVu
                            {
                                MaDichVu = MaDichVu,
                                TenDichVu = TenDichVu,
                                DonViTinh = DonViTinh,
                                GiaTien = GiaTien,
                                TinhTrang = TinhTrang,
                                GioBatDauDichVu = GioBatDauDichVu,
                                GioKetThucDichVu = GioKetThucDichVu
                            };
                            _db.DichVu.Add(list);
                        }
                        _db.SaveChanges();
                    }

                    if (errorRows.Count > 0)
                    {
                        TempData["SwalIcon"] = "error";
                        TempData["SwalTitle"] = $"Có lỗi ở các dòng: {string.Join(", ", errorRows)}. Vui lòng kiểm tra lại file Excel của bạn.";
                        return RedirectToAction("DanhSachDichVu", "DichVu");
                    }
                }
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Import file thành công";
                return RedirectToAction("DanhSachDichVu", "DichVu");
            }
        }
        public async Task<IActionResult> ExportPDF()
        {
            Document pdfDoc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);

            var dichvu = _db.DichVu.ToList();

            pdfDoc.Open();
            float cm = 20;
            float points = cm * 72 / 2.54f;
            float pointsForColumn = points * 1.25f;
            PdfPTable table = new PdfPTable(7);
            table.SetTotalWidth(new float[] { pointsForColumn, pointsForColumn, pointsForColumn, pointsForColumn, pointsForColumn, pointsForColumn, pointsForColumn });

            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            Font headerFont = FontFactory.GetFont("Arial", 5, Font.BOLD, BaseColor.WHITE);
            BaseColor headerBackgroundColor = new BaseColor(0, 119, 119);

            string[] headers = { "Mã Dịch Vụ", "Tên Dịch Vụ", "Đơn Vị Tính", "Giá Tiền", "Tình Trạng", "Giờ Bắt Đầu Dịch Vụ", "Giờ Kết Thúc Dịch Vụ" };

            foreach (var header in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                cell.BackgroundColor = headerBackgroundColor;
                table.AddCell(cell);
            }

            Font contentFont = FontFactory.GetFont("Arial", 5, Font.NORMAL, BaseColor.BLACK);

            foreach (var dv in dichvu)
            {
                table.AddCell(new Phrase(dv.MaDichVu.ToString(), contentFont));
                table.AddCell(new Phrase(dv.TenDichVu.ToString(), contentFont));
                table.AddCell(new Phrase(dv.DonViTinh.ToString(), contentFont));
                table.AddCell(new Phrase(dv.GiaTien.ToString(), contentFont));
                table.AddCell(new Phrase(dv.TinhTrang.ToString(), contentFont));
                table.AddCell(new Phrase(dv.GioBatDauDichVu.ToString(), contentFont));
                table.AddCell(new Phrase(dv.GioKetThucDichVu.ToString(), contentFont));
            }

            pdfDoc.Add(table);

            pdfDoc.Close();

            byte[] bytes = memoryStream.ToArray();
            memoryStream.Close();

            return File(bytes, "application/pdf", "DichVu.pdf");
        }


    }
}
