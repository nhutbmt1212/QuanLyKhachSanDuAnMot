using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class AddTodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageLink_Phong_PhongMaPhong",
                table: "ImageLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageLink",
                table: "ImageLink");

            migrationBuilder.RenameTable(
                name: "ImageLink",
                newName: "imglink");

            migrationBuilder.RenameIndex(
                name: "IX_ImageLink_PhongMaPhong",
                table: "imglink",
                newName: "IX_imglink_PhongMaPhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imglink",
                table: "imglink",
                column: "ImageLinkId");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 11, 20, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 11, 23, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 22, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5694), new DateTime(2023, 11, 24, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 11, 25, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 24, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5700), new DateTime(2023, 11, 26, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5416), new DateTime(2021, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5442), new DateTime(2020, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5447), new DateTime(2018, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5452), new DateTime(2019, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.AddForeignKey(
                name: "FK_imglink_Phong_PhongMaPhong",
                table: "imglink",
                column: "PhongMaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imglink_Phong_PhongMaPhong",
                table: "imglink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imglink",
                table: "imglink");

            migrationBuilder.RenameTable(
                name: "imglink",
                newName: "ImageLink");

            migrationBuilder.RenameIndex(
                name: "IX_imglink_PhongMaPhong",
                table: "ImageLink",
                newName: "IX_ImageLink_PhongMaPhong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageLink",
                table: "ImageLink",
                column: "ImageLinkId");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(652), new DateTime(2023, 11, 20, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(660), new DateTime(2023, 11, 23, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 22, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 11, 24, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(666), new DateTime(2023, 11, 25, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 24, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 11, 26, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(430), new DateTime(2021, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(450), new DateTime(2022, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(455), new DateTime(2020, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(459), new DateTime(2018, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(463), new DateTime(2019, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLink_Phong_PhongMaPhong",
                table: "ImageLink",
                column: "PhongMaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong");
        }
    }
}
