using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class VatTuAndChiTietPhongVatTuToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VatTu",
                columns: table => new
                {
                    MaVatTu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenVatTu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TinhTrangVatTu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NgayThem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTu", x => x.MaVatTu);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhongVatTu",
                columns: table => new
                {
                    MaVatTu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaPhong = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhongVatTu", x => new { x.MaVatTu, x.MaPhong });
                    table.ForeignKey(
                        name: "FK_ChiTietPhongVatTu_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhongVatTu_VatTu_MaVatTu",
                        column: x => x.MaVatTu,
                        principalTable: "VatTu",
                        principalColumn: "MaVatTu",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Quản lý", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8351), new DateTime(2021, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Nhân viên", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8382), new DateTime(2022, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Nhân viên", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8387), new DateTime(2020, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Quản lý", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8393), new DateTime(2018, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Nhân viên", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8398), new DateTime(2019, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.InsertData(
                table: "VatTu",
                columns: new[] { "MaVatTu", "NgayThem", "TenVatTu", "TinhTrangVatTu" },
                values: new object[,]
                {
                    { "VT001", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8803), "Giường", "." },
                    { "VT002", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8806), "Bàn", "." },
                    { "VT003", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8808), "Ghế", "." },
                    { "VT004", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8809), "Đèn ngủ", "." },
                    { "VT005", new DateTime(2023, 11, 23, 10, 48, 56, 314, DateTimeKind.Local).AddTicks(8811), "Rèm", "." }
                });

            migrationBuilder.InsertData(
                table: "ChiTietPhongVatTu",
                columns: new[] { "MaPhong", "MaVatTu", "SoLuong", "TinhTrang" },
                values: new object[,]
                {
                    { "P001", "VT001", 2, "Đang sử dụng" },
                    { "P001", "VT002", 2, "Đang sử dụng" },
                    { "P001", "VT003", 2, "Đang sử dụng" },
                    { "P001", "VT004", 2, "Đang sử dụng" },
                    { "P001", "VT005", 2, "Tạm ngừng" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhongVatTu_MaPhong",
                table: "ChiTietPhongVatTu",
                column: "MaPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhongVatTu");

            migrationBuilder.DropTable(
                name: "VatTu");

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
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Quan ly", new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5416), new DateTime(2021, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Nhan vien", new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Nhan vien", new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5442), new DateTime(2020, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Quan ly", new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5447), new DateTime(2018, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "ChucVu", "NgayDangKy", "NgayVaoLam" },
                values: new object[] { "Nhan vien", new DateTime(2023, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5452), new DateTime(2019, 11, 19, 15, 45, 49, 208, DateTimeKind.Local).AddTicks(5452) });

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
        }
    }
}
