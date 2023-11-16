using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class AddTableAndDataToDb : Migration
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
                    GioDichVu = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
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
                    TenDangNhap = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
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
                    TinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AnhPhong = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
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
                name: "ChiTietDichVu",
                columns: table => new
                {
                    MaDichVu = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    ThoiGianDichVu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDichVu", x => new { x.MaDichVu, x.MaKhachHang });
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
                        principalColumn: "MaNhanVien",
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
                    MaNhanVien = table.Column<string>(type: "nvarchar(6)", nullable: false),
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
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatPhong_Phong_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DichVu",
                columns: new[] { "MaDichVu", "DonViTinh", "GiaTien", "GioDichVu", "TenDichVu", "TinhTrang" },
                values: new object[,]
                {
                    { "DV001", "Cái", 50000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8247), "Dịch Vụ 1", "Hoạt động" },
                    { "DV002", "Cái", 80000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8248), "Dịch Vụ 2", "Hoạt động" },
                    { "DV003", "Bộ", 120000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8250), "Dịch Vụ 3", "Ngừng hoạt động" },
                    { "DV004", "Lần sử dụng", 150000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8251), "Dịch Vụ 4", "Hoạt động" },
                    { "DV005", "Bộ", 200000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8252), "Dịch Vụ 5", "Hoạt động" }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "MaKhachHang", "CCCD", "DiaChi", "GioiTinh", "MatKhau", "NgayDangKy", "NgaySinh", "SoDienThoai", "TenKhachHang", "TinhTrang" },
                values: new object[,]
                {
                    { "KH001", "123456789012", "123 Nguyen Van X, Quan 1, TP.HCM", "Nam", "password1", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8127), new DateTime(1992, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456789", "Nguyen Van X", "Active" },
                    { "KH002", "987654321098", "456 Tran Thi Y, Quan 2, TP.HCM", "Nu", "password2", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8130), new DateTime(1995, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "987654321", "Tran Thi Y", "Active" },
                    { "KH003", "111223344055", "789 Le Van Z, Quan 3, TP.HCM", "Nam", "password3", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8132), new DateTime(1988, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "111223344", "Le Van Z", "Inactive" },
                    { "KH004", "555666777044", "101 Pham Thi K, Quan 4, TP.HCM", "Nu", "password4", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8134), new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "555666777", "Pham Thi K", "Active" },
                    { "KH005", "999888777033", "202 Hoang Van M, Quan 5, TP.HCM", "Nam", "password5", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8136), new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "999888777", "Hoang Van M", "Active" }
                });

            migrationBuilder.InsertData(
                table: "LoaiPhong",
                columns: new[] { "MaLoaiPhong", "GiaPhongTheoNgay", "GiaTheoGio", "PhuThuTraMuon", "SoLuongNguoiLon", "SoLuongTreEm", "TenLoaiPhong" },
                values: new object[,]
                {
                    { "LP001", 100000, 50000, 20000, 1, 0, "Phòng Đơn" },
                    { "LP002", 150000, 80000, 25000, 2, 1, "Phòng Đôi" },
                    { "LP003", 200000, 120000, 30000, 4, 2, "Phòng Gia Đình" },
                    { "LP004", 250000, 150000, 35000, 3, 1, "Phòng Suite" },
                    { "LP005", 300000, 200000, 40000, 2, 0, "Phòng VIP" }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "MaNhanVien", "AnhNhanVienBase64", "CCCD", "ChucVu", "DiaChi", "Email", "GioiTinh", "MatKhau", "NgayDangKy", "NgaySinh", "NgayVaoLam", "SoDienThoai", "TenDangNhap", "TenNhanVien", "TinhTrang" },
                values: new object[,]
                {
                    { "NV001", "Base64Image1", "123456789012", "Quan ly", "123 Nguyen Van A, Quan 1, TP.HCM", "nhanvien1@example.com", "Nam", "password1", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8012), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8021), "123456789", "user1", "Nguyen Van A", "Hoat dong" },
                    { "NV002", "Base64Image2", "987654321098", "Nhan vien", "456 Tran Thi B, Quan 2, TP.HCM", "nhanvien2@example.com", "Nu", "password2", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8030), new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8031), "987654321", "user2", "Tran Thi B", "Hoat dong" },
                    { "NV003", "Base64Image3", "111223344055", "Nhan vien", "789 Le Van C, Quan 3, TP.HCM", "nhanvien3@example.com", "Nam", "password3", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8034), new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8035), "111223344", "user3", "Le Van C", "Nghi viec" },
                    { "NV004", "Base64Image4", "555666777044", "Quan ly", "101 Pham Thi D, Quan 4, TP.HCM", "nhanvien4@example.com", "Nu", "password4", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8037), new DateTime(1988, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8038), "555666777", "user4", "Pham Thi D", "Hoat dong" },
                    { "NV005", "Base64Image5", "999888777033", "Nhan vien", "202 Hoang Van E, Quan 5, TP.HCM", "nhanvien5@example.com", "Nam", "password5", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8040), new DateTime(1980, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8041), "999888777", "user5", "Hoang Van E", "Hoat dong" }
                });

            migrationBuilder.InsertData(
                table: "ChiTietDichVu",
                columns: new[] { "MaDichVu", "MaKhachHang", "MaNhanVien", "SoLuong", "ThoiGianDichVu", "TrangThai" },
                values: new object[,]
                {
                    { "DV001", "KH001", "NV001", 2, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8331), "Hoàn thành" },
                    { "DV002", "KH002", "NV002", 1, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8333), "Chưa hoàn thành" },
                    { "DV003", "KH003", "NV003", 3, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8334), "Hoàn thành" },
                    { "DV004", "KH004", "NV004", 2, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8336), "Chưa hoàn thành" },
                    { "DV005", "KH005", "NV005", 1, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8337), "Hoàn thành" }
                });

            migrationBuilder.InsertData(
                table: "DanhGia",
                columns: new[] { "MaDanhGia", "BinhLuan", "DiemDanhGia", "MaKhachHang", "NgayDanhGia" },
                values: new object[,]
                {
                    { "DG001", "Dịch vụ tốt, phòng sạch sẽ.", 5, "KH001", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8314) },
                    { "DG002", "Không hài lòng với dịch vụ nhân viên.", 2, "KH002", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8316) },
                    { "DG003", "Phòng ốc quá ồn ào, không yên tĩnh.", 3, "KH003", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8317) },
                    { "DG004", "Dịch vụ và phòng ốc đều rất tốt.", 5, "KH004", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8318) },
                    { "DG005", "Giá cả hợp lý, nhân viên nhiệt tình.", 4, "KH005", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8319) }
                });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "MaHoaDon", "MaDatPhong", "MaNhanVien", "SoTienThanhToan", "ThoiGianThanhToan", "TongTienDichVu", "TongTienPhong" },
                values: new object[,]
                {
                    { "HD001", "DP001", "NV001", 150000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8262), 50000, 100000 },
                    { "HD002", "DP002", "NV002", 230000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8264), 80000, 150000 },
                    { "HD003", "DP003", "NV003", 320000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8266), 120000, 200000 },
                    { "HD004", "DP004", "NV004", 400000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8267), 150000, 250000 },
                    { "HD005", "DP005", "NV005", 500000, new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8268), 200000, 300000 }
                });

            migrationBuilder.InsertData(
                table: "Phong",
                columns: new[] { "MaPhong", "AnhPhong", "MaLoaiPhong", "NgayTao", "TinhTrang" },
                values: new object[,]
                {
                    { "P001", new byte[] { 1, 2, 3 }, "LP001", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8174), "Trong" },
                    { "P002", new byte[] { 4, 5, 6 }, "LP002", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8194), "Trong" },
                    { "P003", new byte[] { 7, 8, 9 }, "LP003", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8197), "Da Dat" },
                    { "P004", new byte[] { 10, 11, 12 }, "LP004", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8201), "Trong" },
                    { "P005", new byte[] { 13, 14, 15 }, "LP005", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8203), "Da Dat" }
                });

            migrationBuilder.InsertData(
                table: "DatPhong",
                columns: new[] { "MaDatPhong", "HinhThucDatPhong", "MaKhachHang", "MaNhanVien", "MaPhong", "NgayNhan", "NgayTra", "SoLuongNguoiLon", "SoLuongTreEm", "SoTienTraTruoc", "TinhTrang", "TongTienPhong" },
                values: new object[,]
                {
                    { "DP001", "Trực tuyến", "KH001", "NV001", "P001", new DateTime(2023, 11, 16, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8282), new DateTime(2023, 11, 17, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8283), 2, 1, 50000, "Đã xác nhận", 100000 },
                    { "DP002", "Điện thoại", "KH002", "NV002", "P002", new DateTime(2023, 11, 18, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 11, 20, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8290), 1, 0, 80000, "Đã xác nhận", 150000 },
                    { "DP003", "Trực tiếp", "KH003", "NV003", "P003", new DateTime(2023, 11, 19, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8293), new DateTime(2023, 11, 21, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8293), 3, 2, 120000, "Đã xác nhận", 200000 },
                    { "DP004", "Trực tuyến", "KH004", "NV004", "P004", new DateTime(2023, 11, 20, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8295), new DateTime(2023, 11, 22, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8296), 2, 0, 150000, "Đã xác nhận", 250000 },
                    { "DP005", "Điện thoại", "KH005", "NV005", "P005", new DateTime(2023, 11, 21, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 11, 23, 18, 25, 0, 548, DateTimeKind.Local).AddTicks(8298), 1, 1, 200000, "Đã xác nhận", 300000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_MaKhachHang",
                table: "ChiTietDichVu",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDichVu_MaNhanVien",
                table: "ChiTietDichVu",
                column: "MaNhanVien");

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
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "DatPhong");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiPhong");
        }
    }
}
