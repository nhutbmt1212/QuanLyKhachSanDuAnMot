using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class FKImgLinkAndMaDV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imglink_Phong_PhongMaPhong",
                table: "imglink");

            migrationBuilder.DropIndex(
                name: "IX_imglink_PhongMaPhong",
                table: "imglink");

            migrationBuilder.DropColumn(
                name: "PhongMaPhong",
                table: "imglink");

            migrationBuilder.AddColumn<string>(
                name: "MaPhong",
                table: "imglink",
                type: "nvarchar(6)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaDatPhong",
                table: "ChiTietDichVu",
                type: "nvarchar(6)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                columns: new[] { "MaDatPhong", "ThoiGianDichVu" },
                values: new object[] { "DP001", new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                columns: new[] { "MaDatPhong", "ThoiGianDichVu" },
                values: new object[] { "DP003", new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                columns: new[] { "MaDatPhong", "ThoiGianDichVu" },
                values: new object[] { "DP001", new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                columns: new[] { "MaDatPhong", "ThoiGianDichVu" },
                values: new object[] { "DP004", new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                columns: new[] { "MaDatPhong", "ThoiGianDichVu" },
                values: new object[] { "DP001", new DateTime(2023, 12, 1, 10, 18, 33, 497, DateTimeKind.Local).AddTicks(7450) });

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

            migrationBuilder.CreateIndex(
                name: "IX_imglink_MaPhong",
                table: "imglink",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_MaDatPhong",
                table: "ChiTietDichVu",
                column: "MaDatPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDichVu_DatPhong_MaDatPhong",
                table: "ChiTietDichVu",
                column: "MaDatPhong",
                principalTable: "DatPhong",
                principalColumn: "MaDatPhong",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_imglink_Phong_MaPhong",
                table: "imglink",
                column: "MaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDichVu_DatPhong_MaDatPhong",
                table: "ChiTietDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_imglink_Phong_MaPhong",
                table: "imglink");

            migrationBuilder.DropIndex(
                name: "IX_imglink_MaPhong",
                table: "imglink");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietDichVu_MaDatPhong",
                table: "ChiTietDichVu");

            migrationBuilder.DropColumn(
                name: "MaPhong",
                table: "imglink");

            migrationBuilder.DropColumn(
                name: "MaDatPhong",
                table: "ChiTietDichVu");

            migrationBuilder.AddColumn<string>(
                name: "PhongMaPhong",
                table: "imglink",
                type: "nvarchar(6)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3937), new DateTime(2023, 11, 24, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 25, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 11, 27, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 26, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3949), new DateTime(2023, 11, 28, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 27, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3951), new DateTime(2023, 11, 29, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 28, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 11, 30, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3712), new DateTime(2021, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3733), new DateTime(2022, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3736), new DateTime(2020, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3739), new DateTime(2018, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3742), new DateTime(2019, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.CreateIndex(
                name: "IX_imglink_PhongMaPhong",
                table: "imglink",
                column: "PhongMaPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_imglink_Phong_PhongMaPhong",
                table: "imglink",
                column: "PhongMaPhong",
                principalTable: "Phong",
                principalColumn: "MaPhong");
        }
    }
}
