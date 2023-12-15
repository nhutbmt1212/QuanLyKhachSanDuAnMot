using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class AddThemKhoaDichVu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3815), new DateTime(2021, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3836), new DateTime(2022, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3840), new DateTime(2020, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3844), new DateTime(2018, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3847), new DateTime(2019, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00006",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00007",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00008",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00009",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00010",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 18, 49, 47, 122, DateTimeKind.Local).AddTicks(4167));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9785), new DateTime(2021, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9806), new DateTime(2022, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9810), new DateTime(2020, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9813), new DateTime(2018, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9816), new DateTime(2019, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00006",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00007",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00008",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00009",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00010",
                column: "NgayTao",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 787, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 788, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 788, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 788, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 788, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 15, 17, 59, 5, 788, DateTimeKind.Local).AddTicks(119));
        }
    }
}
