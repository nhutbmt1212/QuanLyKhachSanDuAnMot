using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class AddKhuVucPhong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KhuVuc",
                table: "Phong",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 11, 18, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 19, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6387), new DateTime(2023, 11, 21, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 20, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 11, 22, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 21, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 11, 23, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 22, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6417), new DateTime(2023, 11, 24, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV001",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV002",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV003",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV004",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV005",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6166), new DateTime(2021, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6182), new DateTime(2022, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6185), new DateTime(2020, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6189), new DateTime(2018, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6191), new DateTime(2019, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                columns: new[] { "KhuVuc", "NgayTao" },
                values: new object[] { "Khu A", new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                columns: new[] { "KhuVuc", "NgayTao" },
                values: new object[] { "Khu A", new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                columns: new[] { "KhuVuc", "NgayTao" },
                values: new object[] { "Khu B", new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                columns: new[] { "KhuVuc", "NgayTao" },
                values: new object[] { "Khu C", new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                columns: new[] { "KhuVuc", "NgayTao" },
                values: new object[] { "Khu C", new DateTime(2023, 11, 17, 14, 20, 40, 108, DateTimeKind.Local).AddTicks(6336) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhuVuc",
                table: "Phong");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 11, 17, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 18, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3296), new DateTime(2023, 11, 20, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 19, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3300), new DateTime(2023, 11, 21, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 20, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 11, 22, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 21, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 11, 23, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV001",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV002",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV003",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV004",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV005",
                column: "GioDichVu",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3030), new DateTime(2021, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3091), new DateTime(2020, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3095), new DateTime(2018, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3099), new DateTime(2019, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 11, 16, 18, 34, 49, 506, DateTimeKind.Local).AddTicks(3243));
        }
    }
}
