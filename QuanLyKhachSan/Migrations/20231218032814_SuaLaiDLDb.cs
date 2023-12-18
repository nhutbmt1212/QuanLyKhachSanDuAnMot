using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class SuaLaiDLDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "Quận 3, TP.HCM", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3240), "0123456789", "Nguyễn Văn Hải" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "456 Thủ dầu một, Bình Dương", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3243), "0987654321", "Trần Thị Hà" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                columns: new[] { "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3245), "0111223344", "Lê Văn Thái" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "101 Từ Liêm, Hà Nội", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3247), "0555666777", "Phạm Thị Thanh" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "Gia Lai", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3250), "0999888777", "Hoàng Văn Thanh" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "222 Quận 1, TP.HCM", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3015), new DateTime(2021, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3032), "0123456789", "Nguyễn Văn A" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "328 Quận 2, TP.HCM", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3046), new DateTime(2022, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3046), "0987654321", "Trần Thị B" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien", "TinhTrang" },
                values: new object[] { "120 Hà Huy Tập, BMT", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3049), new DateTime(2020, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3050), "0111223344", "Lê Văn C", "Đã nghỉ việc" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "101 Phạm Hùng, BMT", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3053), new DateTime(2018, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3053), "0555666777", "Phạm Thị D" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "Hà Nội", new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3056), new DateTime(2019, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3056), "0999888777", "Hoàng Văn E" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00006",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00007",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00008",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00009",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00010",
                column: "NgayTao",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(4360), "Đèn trang trí Lan Anh" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 18, 10, 28, 14, 27, DateTimeKind.Local).AddTicks(4362));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "123 Nguyen Van X, Quan 1, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8770), "123456789", "Nguyen Van X" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "456 Tran Thi Y, Quan 2, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8773), "987654321", "Tran Thi Y" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                columns: new[] { "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8775), "111223344", "Le Van Z" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "101 Pham Thi K, Quan 4, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8777), "555666777", "Pham Thi K" });

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                columns: new[] { "DiaChi", "NgayDangKy", "SoDienThoai", "TenKhachHang" },
                values: new object[] { "202 Hoang Van M, Quan 5, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8779), "999888777", "Hoang Van M" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "123 Nguyen Van A, Quan 1, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8656), new DateTime(2021, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8664), "123456789", "Nguyen Van A" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "456 Tran Thi B, Quan 2, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8673), new DateTime(2022, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8674), "987654321", "Tran Thi B" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien", "TinhTrang" },
                values: new object[] { "789 Le Van C, Quan 3, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8676), new DateTime(2020, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8677), "111223344", "Le Van C", "Nghỉ việc" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "101 Pham Thi D, Quan 4, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8679), new DateTime(2018, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8680), "555666777", "Pham Thi D" });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "DiaChi", "NgayDangKy", "NgayVaoLam", "SoDienThoai", "TenNhanVien" },
                values: new object[] { "202 Hoang Van E, Quan 5, TP.HCM", new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8682), new DateTime(2019, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8682), "999888777", "Hoang Van E" });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00001",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00002",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00003",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00004",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00005",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00006",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00007",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00008",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00009",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P00010",
                column: "NgayTao",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT001",
                column: "NgayThem",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT002",
                column: "NgayThem",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT003",
                column: "NgayThem",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT004",
                columns: new[] { "NgayThem", "NhaSanXuat" },
                values: new object[] { new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8932), "Đèn trang thí Lan Anh" });

            migrationBuilder.UpdateData(
                table: "VatTu",
                keyColumn: "MaVatTu",
                keyValue: "VT005",
                column: "NgayThem",
                value: new DateTime(2023, 12, 17, 17, 44, 10, 96, DateTimeKind.Local).AddTicks(8933));
        }
    }
}
