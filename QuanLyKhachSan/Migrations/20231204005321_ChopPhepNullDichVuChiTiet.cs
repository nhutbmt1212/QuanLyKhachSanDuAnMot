using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class ChopPhepNullDichVuChiTiet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVu_NhanVien_MaNhanVien",
                table: "ChiTietDichVu");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianDichVu",
                table: "ChiTietDichVu",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MaNhanVien",
                table: "ChiTietDichVu",
                type: "nvarchar(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1976), new DateTime(2023, 12, 5, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 6, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1984), new DateTime(2023, 12, 8, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 7, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1987), new DateTime(2023, 12, 9, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 8, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1990), new DateTime(2023, 12, 10, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 9, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 12, 11, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1692), new DateTime(2021, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1712), new DateTime(2022, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1717), new DateTime(2020, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1721), new DateTime(2018, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1725), new DateTime(2019, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 4, 7, 53, 21, 457, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVu_NhanVien_MaNhanVien",
                table: "ChiTietDichVu",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVu_NhanVien_MaNhanVien",
                table: "ChiTietDichVu");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianDichVu",
                table: "ChiTietDichVu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaNhanVien",
                table: "ChiTietDichVu",
                type: "nvarchar(6)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(883), new DateTime(2023, 12, 4, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(892), new DateTime(2023, 12, 7, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 6, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 12, 8, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 7, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(898), new DateTime(2023, 12, 9, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 8, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 12, 10, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(615), new DateTime(2021, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(636), new DateTime(2022, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(640), new DateTime(2020, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(644), new DateTime(2018, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(648), new DateTime(2019, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 3, 16, 2, 11, 484, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVu_NhanVien_MaNhanVien",
                table: "ChiTietDichVu",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
