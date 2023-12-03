using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class ChoPhepNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhong_NhanVien_MaNhanVien",
                table: "DatPhong");

            migrationBuilder.AlterColumn<string>(
                name: "MaNhanVien",
                table: "DatPhong",
                type: "nvarchar(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)");

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
                name: "FK_DatPhong_NhanVien_MaNhanVien",
                table: "DatPhong",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhong_NhanVien_MaNhanVien",
                table: "DatPhong");

            migrationBuilder.AlterColumn<string>(
                name: "MaNhanVien",
                table: "DatPhong",
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
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7383), new DateTime(2023, 12, 2, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 3, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 12, 5, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 4, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7398), new DateTime(2023, 12, 6, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 5, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 12, 7, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 12, 6, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7404), new DateTime(2023, 12, 8, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7057), new DateTime(2021, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7080), new DateTime(2022, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7085), new DateTime(2020, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7089), new DateTime(2018, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7093), new DateTime(2019, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhong_NhanVien_MaNhanVien",
                table: "DatPhong",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
