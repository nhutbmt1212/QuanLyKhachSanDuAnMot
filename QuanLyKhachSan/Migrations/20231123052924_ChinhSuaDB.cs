using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class ChinhSuaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NhaSanXuat",
                table: "VatTu",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

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
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV001",
                columns: new[] { "DonViTinh", "GiaTien", "GioBatDauDichVu", "GioKetThucDichVu", "TenDichVu" },
                values: new object[] { "Kg", 20000, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 20, 0, 0, 0), "Giặt ủi" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV002",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu" },
                values: new object[] { "Lượt", 200000, "Đưa đón sân bay" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV003",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu", "TinhTrang" },
                values: new object[] { "Lần", 50000, "Dọn phòng", "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV004",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu" },
                values: new object[] { "Người", 50000, "Ăn sáng" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV005",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu" },
                values: new object[] { "Xe", 120000, "Thuê xe máy" });

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
                columns: new[] { "NgayDangKy", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3845), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                columns: new[] { "GioiTinh", "NgayDangKy", "TinhTrang" },
                values: new object[] { "Nữ", new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3847), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                columns: new[] { "NgayDangKy", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3850), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                columns: new[] { "GioiTinh", "NgayDangKy", "TinhTrang" },
                values: new object[] { "Nữ", new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3852), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                columns: new[] { "NgayDangKy", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3854), "Ngừng hoạt động" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3712), new DateTime(2021, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3723), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "GioiTinh", "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { "Nữ", new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3733), new DateTime(2022, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3734), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3736), new DateTime(2020, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3737), "Nghỉ việc" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "GioiTinh", "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { "Nữ", new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3739), new DateTime(2018, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3740), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3742), new DateTime(2019, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3742), "Hoạt động" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3885), "Trống" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3887), "Trống" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3889), "Đã đặt" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3890), "Trống" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(3891), "Đã đặt" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4029), "Nội Thất Minh Nhật" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4031), "Cửa Hàng Đồ Gỗ Minh Quốc" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4032), "Cửa Hàng Đồ Gỗ Minh Quốc" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4033), "Đèn trang chí Lan Anh" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 11, 23, 12, 29, 24, 347, DateTimeKind.Local).AddTicks(4034), "Rèm xinh Bmt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NhaSanXuat",
                table: "VatTu");

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 11, 24, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 25, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8714), new DateTime(2023, 11, 27, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 26, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 11, 28, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 27, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 11, 29, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 28, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 11, 30, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV001",
                columns: new[] { "DonViTinh", "GiaTien", "GioBatDauDichVu", "GioKetThucDichVu", "TenDichVu" },
                values: new object[] { "Cái", 50000, new TimeSpan(0, 6, 0, 0, 0), new TimeSpan(0, 22, 0, 0, 0), "Dịch Vụ 1" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV002",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu" },
                values: new object[] { "Cái", 80000, "Dịch Vụ 2" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV003",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu", "TinhTrang" },
                values: new object[] { "Bộ", 120000, "Dịch Vụ 3", "Ngừng hoạt động" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV004",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu" },
                values: new object[] { "Lần sử dụng", 150000, "Dịch Vụ 4" });

            migrationBuilder.UpdateData(
                table: "DichVu",
                keyColumn: "MaDichVu",
                keyValue: "DV005",
                columns: new[] { "DonViTinh", "GiaTien", "TenDichVu" },
                values: new object[] { "Bộ", 200000, "Dịch Vụ 5" });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                columns: new[] { "NgayDangKy", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8547), "Active" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                columns: new[] { "GioiTinh", "NgayDangKy", "TinhTrang" },
                values: new object[] { "Nu", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8552), "Active" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                columns: new[] { "NgayDangKy", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8556), "Inactive" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                columns: new[] { "GioiTinh", "NgayDangKy", "TinhTrang" },
                values: new object[] { "Nu", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8559), "Active" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                columns: new[] { "NgayDangKy", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8562), "Active" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8351), new DateTime(2021, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8366), "Hoat dong" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "GioiTinh", "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { "Nu", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8382), new DateTime(2022, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8383), "Hoat dong" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8387), new DateTime(2020, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8388), "Nghi viec" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "GioiTinh", "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { "Nu", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8393), new DateTime(2018, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8394), "Hoat dong" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8398), new DateTime(2019, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8399), "Hoat dong" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8613), "Trong" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8616), "Trong" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8619), "Da Dat" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8621), "Trong" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                columns: new[] { "NgayTao", "TinhTrang" },
                values: new object[] { new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8623), "Da Dat" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8811));
        }
    }
}
