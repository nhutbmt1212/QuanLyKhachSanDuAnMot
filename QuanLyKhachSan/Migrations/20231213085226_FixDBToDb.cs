using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class FixDBToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" });

            migrationBuilder.DeleteData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" });

            migrationBuilder.DeleteData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" });

            migrationBuilder.DeleteData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" });

            migrationBuilder.DeleteData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" });

            migrationBuilder.DeleteData(
                table: "ChiTietPhongVatTu",
                keyColumns: new[] { "MaPhong", "MaVatTu" },
                keyValues: new object[] { "P001", "VT001" });

            migrationBuilder.DeleteData(
                table: "ChiTietPhongVatTu",
                keyColumns: new[] { "MaPhong", "MaVatTu" },
                keyValues: new object[] { "P001", "VT002" });

            migrationBuilder.DeleteData(
                table: "ChiTietPhongVatTu",
                keyColumns: new[] { "MaPhong", "MaVatTu" },
                keyValues: new object[] { "P001", "VT003" });

            migrationBuilder.DeleteData(
                table: "ChiTietPhongVatTu",
                keyColumns: new[] { "MaPhong", "MaVatTu" },
                keyValues: new object[] { "P001", "VT004" });

            migrationBuilder.DeleteData(
                table: "ChiTietPhongVatTu",
                keyColumns: new[] { "MaPhong", "MaVatTu" },
                keyValues: new object[] { "P001", "VT005" });

            migrationBuilder.DeleteData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001");

            migrationBuilder.DeleteData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002");

            migrationBuilder.DeleteData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003");

            migrationBuilder.DeleteData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004");

            migrationBuilder.DeleteData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005");

            migrationBuilder.DeleteData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002");

            migrationBuilder.DeleteData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004");

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005");

            migrationBuilder.DeleteData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001");

            migrationBuilder.DeleteData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003");

            migrationBuilder.DeleteData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP002");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP005");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP001");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP003");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP004");

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.InsertData(
                table: "LoaiPhong",
                columns: new[] { "MaLoaiPhong", "GiaPhongTheoNgay", "GiaTheoGio", "PhuThuTraMuon", "SoLuongNguoiLon", "SoLuongTreEm", "TenLoaiPhong" },
                values: new object[,]
                {
                    { "LP0001", 100000, 50000, 20000, 1, 0, "Phòng Đơn" },
                    { "LP0002", 150000, 80000, 25000, 2, 1, "Phòng Đôi" },
                    { "LP0003", 200000, 120000, 30000, 4, 2, "Phòng Gia Đình" },
                    { "LP0004", 250000, 150000, 35000, 3, 1, "Phòng Suite" },
                    { "LP0005", 300000, 200000, 40000, 2, 0, "Phòng VIP" }
                });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9249), new DateTime(2021, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9269), new DateTime(2022, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9272), new DateTime(2020, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9275), new DateTime(2018, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9279), new DateTime(2019, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "MaPhong", "MaLoaiPhong", "NgayTao", "TinhTrang" },
                values: new object[,]
                {
                    { "P00001", "LP0001", new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9407), "Đang hoạt động" },
                    { "P00002", "LP0002", new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9408), "Đang hoạt động" },
                    { "P00003", "LP0003", new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9410), "Đang hoạt động" },
                    { "P00004", "LP0004", new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9411), "Đang hoạt động" },
                    { "P00005", "LP0005", new DateTime(2023, 12, 13, 15, 52, 25, 961, DateTimeKind.Local).AddTicks(9412), "Đang hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "imglink",
                columns: new[] { "ImageLinkId", "MaPhong", "Url" },
                values: new object[,]
                {
                    { 1, "P00001", "Deluxe_fomxmd_horizontal.webp" },
                    { 2, "P00001", "Deluxe2_y1oap9_horizontal.webp" },
                    { 3, "P00002", "Deluxe3_5wufjk_horizontal.webp" },
                    { 4, "P00002", "DeluxePremium3_nbft54_horizontal.webp" },
                    { 5, "P00003", "HLC-64_gr3tad_horizontal_kd7412_horizontal.webp" },
                    { 6, "P00003", "HLC-65_162rzy_horizontal_68gd8e_horizontal.webp" },
                    { 7, "P00003", "HLC-71_gx38pc_horizontal_atp0eq_horizontal.webp" },
                    { 8, "P00003", "HLC-72_7i5du6_horizontal_4ka00z_horizontal.webp" },
                    { 9, "P00004", "HLC-75_ueo7hb_horizontal_cichzd_horizontal.webp" },
                    { 10, "P00004", "HLC-77_bun0l5_horizontal_7rl43c_horizontal.webp" },
                    { 11, "P00004", "HLC-90_z82lws_horizontal_scaf5o_horizontal.webp" },
                    { 12, "P00004", "HLC-92_g5s1jd_horizontal_2sxis1_horizontal.webp" },
                    { 13, "P00005", "HLC-101_fjad9s_horizontal_v4iia9_horizontal.webp" },
                    { 14, "P00005", "HLC-108_xzs4v9_horizontal_uhmq5c_horizontal.webp" },
                    { 15, "P00005", "HLC-112_dv5czy_horizontal_qliyr2_horizontal.webp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "imglink",
                keyColumn: "ImageLinkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00001");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00002");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00003");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00004");

            migrationBuilder.DeleteData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00005");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP0001");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP0002");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP0003");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP0004");

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: "LP0005");

            migrationBuilder.InsertData(
                table: "DanhGia",
                columns: new[] { "MaDanhGia", "BinhLuan", "DiemDanhGia", "MaKhachHang", "NgayDanhGia" },
                values: new object[,]
                {
                    { "DG001", "Dịch vụ tốt, phòng sạch sẽ.", 5, "KH001", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2588) },
                    { "DG002", "Không hài lòng với dịch vụ nhân viên.", 2, "KH002", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2589) },
                    { "DG003", "Phòng ốc quá ồn ào, không yên tĩnh.", 3, "KH003", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2590) },
                    { "DG004", "Dịch vụ và phòng ốc đều rất tốt.", 5, "KH004", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2591) },
                    { "DG005", "Giá cả hợp lý, nhân viên nhiệt tình.", 4, "KH005", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2592) }
                });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "MaHoaDon", "MaDatPhong", "MaNhanVien", "SoTienThanhToan", "ThoiGianThanhToan", "TongTienDichVu", "TongTienPhong" },
                values: new object[,]
                {
                    { "HD001", "DP001", "NV001", 150000, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2507), 50000, 100000 },
                    { "HD002", "DP002", "NV002", 230000, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2510), 80000, 150000 },
                    { "HD003", "DP003", "NV003", 320000, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2512), 120000, 200000 },
                    { "HD004", "DP004", "NV004", 400000, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2513), 150000, 250000 },
                    { "HD005", "DP005", "NV005", 500000, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2515), 200000, 300000 }
                });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.InsertData(
                table: "LoaiPhong",
                columns: new[] { "MaLoaiPhong", "GiaPhongTheoNgay", "GiaTheoGio", "PhuThuTraMuon", "SoLuongNguoiLon", "SoLuongTreEm", "TenLoaiPhong" },
                values: new object[,]
                {
                    { "LP001", 100000, 50000, 20000, 1, 0, "Phòng Đơn" },
                    { "LP002", 150000, 80000, 25000, 2, 1, "Phòng Đôi" },
                    { "LP003", 200000, 120000, 30000, 4, 2, "Phòng Gia Đình" },
                    { "LP004", 250000, 150000, 35000, 3, 1, "Phòng Suite" },
                    { "LP005", 300000, 200000, 40000, 2, 0, "Phòng VIP" }
                });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2319), new DateTime(2021, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2336), new DateTime(2022, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2339), new DateTime(2020, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2342), new DateTime(2018, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2345), new DateTime(2019, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "MaPhong", "MaLoaiPhong", "NgayTao", "TinhTrang" },
                values: new object[,]
                {
                    { "P001", "LP001", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2469), "Đang hoạt động" },
                    { "P002", "LP002", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2470), "Đang hoạt động" },
                    { "P003", "LP003", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2472), "Đang hoạt động" },
                    { "P004", "LP004", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2473), "Đang hoạt động" },
                    { "P005", "LP005", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2474), "Đang hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "ChiTietPhongVatTu",
                columns: new[] { "MaPhong", "MaVatTu", "SoLuong", "TinhTrang" },
                values: new object[,]
                {
                    { "P001", "VT001", 2, "Đang sử dụng" },
                    { "P001", "VT002", 2, "Đang sử dụng" },
                    { "P001", "VT003", 2, "Đang sử dụng" },
                    { "P001", "VT004", 2, "Đang sử dụng" },
                    { "P001", "VT005", 2, "Tạm ngừng" }
                });

            migrationBuilder.InsertData(
                table: "DatPhong",
                columns: new[] { "MaDatPhong", "HinhThucDatPhong", "MaKhachHang", "MaNhanVien", "MaPhong", "NgayNhan", "NgayTra", "SoLuongNguoiLon", "SoLuongTreEm", "SoTienTraTruoc", "TinhTrang", "TongTienPhong" },
                values: new object[,]
                {
                    { "DP001", "Trực tuyến", "KH001", "NV001", "P001", new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 12, 14, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2560), 2, 1, 50000, "Đã xác nhận", 100000 },
                    { "DP002", "Điện thoại", "KH002", "NV002", "P002", new DateTime(2023, 12, 15, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 12, 17, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2568), 1, 0, 80000, "Đã xác nhận", 150000 },
                    { "DP003", "Trực tiếp", "KH003", "NV003", "P003", new DateTime(2023, 12, 16, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 18, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2570), 3, 2, 120000, "Đã xác nhận", 200000 },
                    { "DP004", "Trực tuyến", "KH004", "NV004", "P004", new DateTime(2023, 12, 17, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 12, 19, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2573), 2, 0, 150000, "Đã xác nhận", 250000 },
                    { "DP005", "Điện thoại", "KH005", "NV005", "P005", new DateTime(2023, 12, 18, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 12, 20, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2575), 1, 1, 200000, "Đã xác nhận", 300000 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietDichVu",
                columns: new[] { "MaDichVu", "MaKhachHang", "MaDatPhong", "MaNhanVien", "SoLuong", "ThoiGianDichVu", "TrangThai" },
                values: new object[,]
                {
                    { "DV001", "KH001", "DP001", "NV001", 2, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2603), "Hoàn thành" },
                    { "DV002", "KH002", "DP003", "NV002", 1, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2605), "Chưa hoàn thành" },
                    { "DV003", "KH003", "DP001", "NV003", 3, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2607), "Hoàn thành" },
                    { "DV004", "KH004", "DP004", "NV004", 2, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2608), "Chưa hoàn thành" },
                    { "DV005", "KH005", "DP001", "NV005", 1, new DateTime(2023, 12, 13, 15, 35, 10, 777, DateTimeKind.Local).AddTicks(2610), "Hoàn thành" }
                });
        }
    }
}
