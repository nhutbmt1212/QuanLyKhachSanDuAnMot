using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class AddToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnhNhanVienBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNguoiSuDung = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTaoTaiKhoan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LuuMatKhau = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.TenDangNhap);
                });

            migrationBuilder.InsertData(
                table: "TaiKhoan",
                columns: new[] { "TenDangNhap", "Email", "GioiTinh", "LuuMatKhau", "MatKhau", "NgaySinh", "NgayTaoTaiKhoan", "SoDienThoai", "TenNguoiSuDung" },
                values: new object[,]
                {
                    { "admin", "admin123@gmai.com", "Nam", false, "admin", new DateTime(2004, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 13, 15, 28, 38, 118, DateTimeKind.Local).AddTicks(2728), "0394858697", "Trương Minh Nhựt" },
                    { "user", "user123@gmai.com", "Nam", false, "user", new DateTime(2004, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 13, 15, 28, 38, 118, DateTimeKind.Local).AddTicks(2746), "0394858697", "Trương Minh Nhựt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}
