using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class AllToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    MaDichVu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenDichVu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GiaTien = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GioBatDauDichVu = table.Column<TimeSpan>(type: "time", nullable: false),
                    GioKetThucDichVu = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.MaDichVu);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    MaLoaiPhong = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenLoaiPhong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GiaTheoGio = table.Column<int>(type: "int", nullable: false),
                    GiaPhongTheoNgay = table.Column<int>(type: "int", nullable: false),
                    PhuThuTraMuon = table.Column<int>(type: "int", nullable: false),
                    SoLuongNguoiLon = table.Column<int>(type: "int", nullable: false),
                    SoLuongTreEm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.MaLoaiPhong);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnhNhanVienBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "VatTu",
                columns: table => new
                {
                    MaVatTu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenVatTu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NhaSanXuat = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TinhTrangVatTu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NgayThem = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VatTu", x => x.MaVatTu);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    MaDanhGia = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    BinhLuan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayDanhGia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiemDanhGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => x.MaDanhGia);
                    table.ForeignKey(
                        name: "FK_DanhGia_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    MaPhong = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaLoaiPhong = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.MaPhong);
                    table.ForeignKey(
                        name: "FK_Phong_LoaiPhong_MaLoaiPhong",
                        column: x => x.MaLoaiPhong,
                        principalTable: "LoaiPhong",
                        principalColumn: "MaLoaiPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaDatPhong = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ThoiGianThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    TongTienDichVu = table.Column<int>(type: "int", nullable: false),
                    TongTienPhong = table.Column<int>(type: "int", nullable: false),
                    SoTienThanhToan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "DatPhong",
                columns: table => new
                {
                    MaDatPhong = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    MaPhong = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongNguoiLon = table.Column<int>(type: "int", nullable: false),
                    SoLuongTreEm = table.Column<int>(type: "int", nullable: false),
                    HinhThucDatPhong = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TongTienPhong = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    TinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SoTienTraTruoc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatPhong", x => x.MaDatPhong);
                    table.ForeignKey(
                        name: "FK_DatPhong_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatPhong_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                    table.ForeignKey(
                        name: "FK_DatPhong_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imglink",
                columns: table => new
                {
                    ImageLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaPhong = table.Column<string>(type: "nvarchar(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imglink", x => x.ImageLinkId);
                    table.ForeignKey(
                        name: "FK_imglink_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDichVu",
                columns: table => new
                {
                    MaDichVu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    ThoiGianDichVu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaDatPhong = table.Column<string>(type: "nvarchar(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDichVu", x => new { x.MaDichVu, x.MaKhachHang });
                    table.ForeignKey(
                        name: "FK_ChiTietDichVu_DatPhong_MaDatPhong",
                        column: x => x.MaDatPhong,
                        principalTable: "DatPhong",
                        principalColumn: "MaDatPhong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVu_DichVu_MaDichVu",
                        column: x => x.MaDichVu,
                        principalTable: "DichVu",
                        principalColumn: "MaDichVu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVu_KhachHang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDichVu_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.InsertData(
                table: "DichVu",
                columns: new[] { "MaDichVu", "DonViTinh", "GiaTien", "GioBatDauDichVu", "GioKetThucDichVu", "TenDichVu", "TinhTrang" },
                values: new object[,]
                {
                    { "DV001", "Kg", 20000, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 20, 0, 0, 0), "Giặt ủi", "Hoạt động" },
                    { "DV002", "Lượt", 200000, new TimeSpan(0, 6, 0, 0, 0), new TimeSpan(0, 22, 0, 0, 0), "Đưa đón sân bay", "Hoạt động" },
                    { "DV003", "Lần", 50000, new TimeSpan(0, 6, 0, 0, 0), new TimeSpan(0, 22, 0, 0, 0), "Dọn phòng", "Hoạt động" },
                    { "DV004", "Người", 50000, new TimeSpan(0, 6, 0, 0, 0), new TimeSpan(0, 22, 0, 0, 0), "Ăn sáng", "Hoạt động" },
                    { "DV005", "Xe", 120000, new TimeSpan(0, 6, 0, 0, 0), new TimeSpan(0, 22, 0, 0, 0), "Thuê xe máy", "Hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "MaKhachHang", "CCCD", "DiaChi", "Email", "GioiTinh", "MatKhau", "NgayDangKy", "NgaySinh", "SoDienThoai", "TenKhachHang", "TinhTrang" },
                values: new object[,]
                {
                    { "KH001", "123456789012", "123 Nguyen Van X, Quan 1, TP.HCM", "khachhang1@example.com", "Nam", "password1", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1630), new DateTime(1992, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "Nguyen Van X", "Hoạt động" },
                    { "KH002", "987654321098", "456 Tran Thi Y, Quan 2, TP.HCM", "khachhang2@example.com", "Nữ", "password2", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1633), new DateTime(1995, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "987654321", "Tran Thi Y", "Hoạt động" },
                    { "KH003", "111223344055", "789 Le Van Z, Quan 3, TP.HCM", "khachhang3@example.com", "Nam", "password3", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1636), new DateTime(1988, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "111223344", "Le Van Z", "Hoạt động" },
                    { "KH004", "555666777044", "101 Pham Thi K, Quan 4, TP.HCM", "khachhang4@example.com", "Nữ", "password4", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1638), new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "555666777", "Pham Thi K", "Hoạt động" },
                    { "KH005", "999888777033", "202 Hoang Van M, Quan 5, TP.HCM", "khachhang5@example.com", "Nam", "password5", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1640), new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "999888777", "Hoang Van M", "Ngừng hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "LoaiPhong",
                columns: new[] { "MaLoaiPhong", "GiaPhongTheoNgay", "GiaTheoGio", "PhuThuTraMuon", "SoLuongNguoiLon", "SoLuongTreEm", "TenLoaiPhong" },
                values: new object[,]
                {
                    { "LP0001", 100000, 50000, 20000, 1, 0, "Phòng Đơn" },
                    { "LP0002", 150000, 80000, 25000, 2, 1, "Phòng Đôi" },
                    { "LP0003", 200000, 120000, 30000, 4, 2, "Phòng Gia Đình" },
                    { "LP0004", 250000, 150000, 35000, 3, 1, "Phòng Suite" },
                    { "LP0005", 300000, 200000, 40000, 2, 0, "Phòng VIP" }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "MaNhanVien", "AnhNhanVienBase64", "CCCD", "ChucVu", "DiaChi", "Email", "GioiTinh", "MatKhau", "NgayDangKy", "NgaySinh", "NgayVaoLam", "SoDienThoai", "TenNhanVien", "TinhTrang" },
                values: new object[,]
                {
                    { "NV001", "UploadImage\\profileStaff.jpg", "123456789012", "Quản lý", "123 Nguyen Van A, Quan 1, TP.HCM", "nhanvien1@example.com", "Nam", "password1", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1509), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1518), "123456789", "Nguyen Van A", "Hoạt động" },
                    { "NV002", "UploadImage\\profileStaff2.jpg", "987654321098", "Nhân viên", "456 Tran Thi B, Quan 2, TP.HCM", "nhanvien2@example.com", "Nữ", "password2", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1526), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1526), "987654321", "Tran Thi B", "Hoạt động" },
                    { "NV003", "UploadImage\\profileStaff3.jpg", "111223344055", "Nhân viên", "789 Le Van C, Quan 3, TP.HCM", "nhanvien3@example.com", "Nam", "password3", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1529), new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1530), "111223344", "Le Van C", "Nghỉ việc" },
                    { "NV004", "UploadImage\\profileStaff4.jpg", "555666777044", "Quản lý", "101 Pham Thi D, Quan 4, TP.HCM", "nhanvien4@example.com", "Nữ", "password4", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1532), new DateTime(1988, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1533), "555666777", "Pham Thi D", "Hoạt động" },
                    { "NV005", "UploadImage\\profileStaff5.webp", "999888777033", "Nhân viên", "202 Hoang Van E, Quan 5, TP.HCM", "nhanvien5@example.com", "Nam", "password5", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1535), new DateTime(1980, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1536), "999888777", "Hoang Van E", "Hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "VatTu",
                columns: new[] { "MaVatTu", "NgayThem", "NhaSanXuat", "TenVatTu", "TinhTrangVatTu" },
                values: new object[,]
                {
                    { "VT001", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1730), "Nội Thất Minh Nhật", "Giường", "." },
                    { "VT002", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1731), "Cửa Hàng Đồ Gỗ Minh Quốc", "Bàn", "." },
                    { "VT003", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1733), "Cửa Hàng Đồ Gỗ Minh Quốc", "Ghế", "." },
                    { "VT004", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1734), "Đèn trang chí Lan Anh", "Đèn ngủ", "." },
                    { "VT005", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1735), "Rèm xinh Bmt", "Rèm", "." }
                });

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "MaPhong", "MaLoaiPhong", "NgayTao", "TinhTrang" },
                values: new object[,]
                {
                    { "P00001", "LP0001", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1670), "Đang hoạt động" },
                    { "P00002", "LP0002", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1672), "Đang hoạt động" },
                    { "P00003", "LP0003", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1673), "Đang hoạt động" },
                    { "P00004", "LP0004", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1674), "Đang hoạt động" },
                    { "P00005", "LP0005", new DateTime(2023, 12, 13, 16, 17, 33, 266, DateTimeKind.Local).AddTicks(1675), "Đang hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "imglink",
                columns: new[] { "ImageLinkId", "MaPhong", "Url" },
                values: new object[,]
                {
                    { 1, "P00001", "Deluxe_fomxmd_horizontal.webp" },
                    { 2, "P00001", "Deluxe2_y1oap9_horizontal.webp" },
                    { 3, "P00002", "Deluxe3_5wufjk_horizontal.webp" },
                    { 4, "P00002", "DeluxePremium3_nbft54_horizontal.webp" },
                    { 5, "P00003", "HLC-64_gr3tad_horizontal_kd7412_horizontal.webp" },
                    { 6, "P00003", "HLC-65_162rzy_horizontal_68gd8e_horizontal.webp" },
                    { 7, "P00003", "HLC-71_gx38pc_horizontal_atp0eq_horizontal.webp" },
                    { 8, "P00003", "HLC-72_7i5du6_horizontal_4ka00z_horizontal.webp" },
                    { 9, "P00004", "HLC-75_ueo7hb_horizontal_cichzd_horizontal.webp" },
                    { 10, "P00004", "HLC-77_bun0l5_horizontal_7rl43c_horizontal.webp" },
                    { 11, "P00004", "HLC-90_z82lws_horizontal_scaf5o_horizontal.webp" },
                    { 12, "P00004", "HLC-92_g5s1jd_horizontal_2sxis1_horizontal.webp" },
                    { 13, "P00005", "HLC-101_fjad9s_horizontal_v4iia9_horizontal.webp" },
                    { 14, "P00005", "HLC-108_xzs4v9_horizontal_uhmq5c_horizontal.webp" },
                    { 15, "P00005", "HLC-112_dv5czy_horizontal_qliyr2_horizontal.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_MaDatPhong",
                table: "ChiTietDichVu",
                column: "MaDatPhong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_MaKhachHang",
                table: "ChiTietDichVu",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_MaNhanVien",
                table: "ChiTietDichVu",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhongVatTu_MaPhong",
                table: "ChiTietPhongVatTu",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_MaKhachHang",
                table: "DanhGia",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaKhachHang",
                table: "DatPhong",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaNhanVien",
                table: "DatPhong",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaPhong",
                table: "DatPhong",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_imglink_MaPhong",
                table: "imglink",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_MaLoaiPhong",
                table: "Phong",
                column: "MaLoaiPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDichVu");

            migrationBuilder.DropTable(
                name: "ChiTietPhongVatTu");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "imglink");

            migrationBuilder.DropTable(
                name: "DatPhong");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "VatTu");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "LoaiPhong");
        }
    }
}
