using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class ChoPhepNullKhachHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "KhachHang",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "KhachHang",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "KhachHang",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "KhachHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CCCD",
                table: "KhachHang",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 12, 13, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 14, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6818), new DateTime(2023, 12, 16, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 15, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 12, 17, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 16, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 12, 18, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6871), new DateTime(2023, 12, 19, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6478), new DateTime(2021, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6502), new DateTime(2022, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6508), new DateTime(2020, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6514), new DateTime(2018, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6519), new DateTime(2019, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 12, 13, 17, 28, 632, DateTimeKind.Local).AddTicks(6958));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "KhachHang",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "KhachHang",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GioiTinh",
                table: "KhachHang",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "KhachHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CCCD",
                table: "KhachHang",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

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
        }
    }
}
