using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using QuanLyKhachSan.Models;
using System;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Controllers
{
    public class VatTuController : Controller
    {
        private readonly ApplicationDbContext _db;
        private static Random random = new Random();

        public VatTuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult DanhSachVatTu()
        {
            var listVatTu = _db.VatTu.ToList();
            return View(listVatTu);
        }
        public string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString;

            do
            {
                randomString = new string(Enumerable.Repeat(chars, 4)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_db.VatTu.Any(d => d.MaVatTu == $"VT{randomString}"));

            return $"VT{randomString}";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemVatTu(VatTu vt)
        {
            if (_db.VatTu.Any(d => d.MaVatTu == vt.MaVatTu))
            {
                // Mã đã tồn tại, có thể xử lý theo ý muốn, ví dụ thông báo lỗi
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Thêm vật tư thất bại Mã vật tư bị trùng";
                return RedirectToAction("DanhSachVatTu", "VatTu");
            }
            vt.MaVatTu = GenerateRandomCode();
                vt.NgayThem = DateTime.Now;
                _db.VatTu.Add(vt);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Thêm vật tư thành công";
            return RedirectToAction("DanhSachVatTu", "VatTu");
  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult SuaVatTu(VatTu vt)
        {

                _db.VatTu.Update(vt);
                _db.SaveChanges();
            TempData["SwalIcon"] = "success";
            TempData["SwalTitle"] = "Sửa vật tư thành công";
            return RedirectToAction("DanhSachVatTu", "VatTu");

        }

        public async Task<IActionResult> DeleteVatTu(string id)
        {
            var vt = await _db.VatTu.FindAsync(id);
            if (vt != null)
            {
                _db.VatTu.Remove(vt);
                await _db.SaveChangesAsync();
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Xóa vật tư thành công";
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("DanhSachVatTu", "VatTu");
        }
        public ActionResult ExportExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("VatTu");

                var vattu = _db.VatTu.ToList();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("Mã Vật Tư");
                dataTable.Columns.Add("Tên Vật Tư");
                dataTable.Columns.Add("Tình Trạng Vật Tư");
                dataTable.Columns.Add("Ngày Thêm");
                dataTable.Columns.Add("Nhà Sản Xuất");

                foreach (var vt in vattu)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = vt.MaVatTu;
                    dataRow[1] = vt.TenVatTu;
                    dataRow[2] = vt.TinhTrangVatTu;
                    dataRow[3] = vt.NgayThem.ToShortDateString();
                    dataRow[4] = vt.NhaSanXuat;
                    dataTable.Rows.Add(dataRow);
                }

                ws.Cells["A1"].LoadFromDataTable(dataTable, true);

                var stream = new MemoryStream(pck.GetAsByteArray());

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "VatTu.xlsx");
            }
        }
        public async Task<IActionResult> Import(IFormFile formFile)
        {
            if (formFile == null || formFile.Length <= 0)
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Chọn một file để nhập dữ liệu.";
                return RedirectToAction("DanhSachVatTu", "VatTu");
            }

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SwalIcon"] = "error";
                TempData["SwalTitle"] = "Chỉ hỗ trợ file .xlsx";
                return RedirectToAction("DanhSachVatTu", "VatTu");
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
                        if (worksheet.Cells[row, 1].Value == null || worksheet.Cells[row, 2].Value == null || worksheet.Cells[row, 3].Value == null || worksheet.Cells[row, 4].Value == null || worksheet.Cells[row, 5].Value == null)
                        {
                            errorRows.Add(row);
                            continue;
                        }

                        var MaVatTu = worksheet.Cells[row, 1].Value.ToString().Trim();
                        var TenVatTu = worksheet.Cells[row, 2].Value.ToString().Trim();
                        var TinhTrangVatTu = worksheet.Cells[row, 3].Value.ToString().Trim();
                        DateTime ngayThem;
                        DateTime.TryParse(worksheet.Cells[row, 4].Value.ToString().Trim(), out ngayThem);
                        var NhaSanXuat = worksheet.Cells[row, 5].Value.ToString().Trim();

                        var vatTu = _db.VatTu.FirstOrDefault(vt => vt.MaVatTu == MaVatTu);
                        if (vatTu != null)
                        {
                            // Cập nhật vật tư
                            vatTu.TenVatTu = TenVatTu;
                            vatTu.TinhTrangVatTu = TinhTrangVatTu;
                            vatTu.NgayThem = ngayThem;
                            vatTu.NhaSanXuat = NhaSanXuat;
                        }
                        else
                        {
                            // Thêm vật tư mới
                            var list = new VatTu
                            {
                                MaVatTu = MaVatTu,
                                TenVatTu = TenVatTu,
                                TinhTrangVatTu = TinhTrangVatTu,
                                NgayThem = ngayThem,
                                NhaSanXuat = NhaSanXuat
                            };
                            _db.VatTu.Add(list);
                        }
                        _db.SaveChanges();
                    }

                    if (errorRows.Count > 0)
                    {
                        TempData["SwalIcon"] = "error";
                        TempData["SwalTitle"] = $"Có lỗi ở các dòng: {string.Join(", ", errorRows)}. Vui lòng kiểm tra lại file Excel của bạn.";
                        return RedirectToAction("DanhSachVatTu", "VatTu");
                    }
                }
                TempData["SwalIcon"] = "success";
                TempData["SwalTitle"] = "Import file thành công";
                return RedirectToAction("DanhSachVatTu", "VatTu");
            }
        }


        public async Task<IActionResult> ExportPDF()
        {
            Document pdfDoc = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);

            var vattu = _db.VatTu.ToList();

            pdfDoc.Open();
            float cm = 20;
            float points = cm * 72 / 2.54f;
            float pointsForColumn = points * 1.5f;
            PdfPTable table = new PdfPTable(5);
            table.SetTotalWidth(new float[] { pointsForColumn, pointsForColumn, pointsForColumn, pointsForColumn, pointsForColumn });

            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            Font headerFont = FontFactory.GetFont("Arial", 10, Font.BOLD, BaseColor.WHITE);
            BaseColor headerBackgroundColor = new BaseColor(0, 119, 119);

            string[] headers = { "Mã Vật Tư", "Tên Vật Tư", "Tình Trạng Vật Tư", "Ngày Thêm", "Nhà Sản Xuất" };

            foreach (var header in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(header, headerFont));
                cell.BackgroundColor = headerBackgroundColor;
                table.AddCell(cell);
            }

            Font contentFont = FontFactory.GetFont("Arial", 10, Font.NORMAL, BaseColor.BLACK);

            foreach (var vt in vattu)
            {
                table.AddCell(new Phrase(vt.MaVatTu.ToString(), contentFont));
                table.AddCell(new Phrase(vt.TenVatTu.ToString(), contentFont));
                table.AddCell(new Phrase(vt.TinhTrangVatTu.ToString(), contentFont));
                table.AddCell(new Phrase(vt.NgayThem.ToShortDateString().ToString(), contentFont));
                table.AddCell(new Phrase(vt.NhaSanXuat.ToString(), contentFont));
            }

            pdfDoc.Add(table);

            pdfDoc.Close();

            byte[] bytes = memoryStream.ToArray();
            memoryStream.Close();

            return File(bytes, "application/pdf", "VatTu.pdf");
        }



    }
}
