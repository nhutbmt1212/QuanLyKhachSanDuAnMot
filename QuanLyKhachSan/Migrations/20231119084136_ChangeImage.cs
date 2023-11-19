using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyKhachSan.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnhPhong",
                table: "Phong");

            migrationBuilder.CreateTable(
                name: "ImageLink",
                columns: table => new
                {
                    ImageLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongMaPhong = table.Column<string>(type: "nvarchar(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLink", x => x.ImageLinkId);
                    table.ForeignKey(
                        name: "FK_ImageLink_Phong_PhongMaPhong",
                        column: x => x.PhongMaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong");
                });

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(652), new DateTime(2023, 11, 20, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(660), new DateTime(2023, 11, 23, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 22, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 11, 24, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(666), new DateTime(2023, 11, 25, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 24, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 11, 26, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(430), new DateTime(2021, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(450), new DateTime(2022, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(455), new DateTime(2020, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(459), new DateTime(2018, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(463), new DateTime(2019, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                column: "NgayTao",
                value: new DateTime(2023, 11, 19, 15, 41, 35, 867, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.CreateIndex(
                name: "IX_ImageLink_PhongMaPhong",
                table: "ImageLink",
                column: "PhongMaPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageLink");

            migrationBuilder.AddColumn<byte[]>(
                name: "AnhPhong",
                table: "Phong",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV001", "KH001" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV002", "KH002" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV003", "KH003" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV004", "KH004" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "ChiTietDichVu",
                keyColumns: new[] { "MaDichVu", "MaKhachHang" },
                keyValues: new object[] { "DV005", "KH005" },
                column: "ThoiGianDichVu",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG001",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG002",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG003",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG004",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "DanhGia",
                keyColumn: "MaDanhGia",
                keyValue: "DG005",
                column: "NgayDanhGia",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP001",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4154), new DateTime(2023, 11, 19, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP002",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 20, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4162), new DateTime(2023, 11, 22, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP003",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 21, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 11, 23, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP004",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4167), new DateTime(2023, 11, 24, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "DatPhong",
                keyColumn: "MaDatPhong",
                keyValue: "DP005",
                columns: new[] { "NgayNhan", "NgayTra" },
                values: new object[] { new DateTime(2023, 11, 23, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 25, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD001",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD002",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD003",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD004",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "HoaDon",
                keyColumn: "MaHoaDon",
                keyValue: "HD005",
                column: "ThoiGianThanhToan",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH001",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH002",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH003",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH004",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "KhachHang",
                keyColumn: "MaKhachHang",
                keyValue: "KH005",
                column: "NgayDangKy",
                value: new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV001",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3925), new DateTime(2021, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV002",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3943), new DateTime(2022, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV003",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3946), new DateTime(2020, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV004",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3949), new DateTime(2018, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "NhanVien",
                keyColumn: "MaNhanVien",
                keyValue: "NV005",
                columns: new[] { "NgayDangKy", "NgayVaoLam" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3952), new DateTime(2019, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P001",
                columns: new[] { "AnhPhong", "NgayTao" },
                values: new object[] { new byte[] { 1, 2, 3 }, new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P002",
                columns: new[] { "AnhPhong", "NgayTao" },
                values: new object[] { new byte[] { 4, 5, 6 }, new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P003",
                columns: new[] { "AnhPhong", "NgayTao" },
                values: new object[] { new byte[] { 7, 8, 9 }, new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P004",
                columns: new[] { "AnhPhong", "NgayTao" },
                values: new object[] { new byte[] { 10, 11, 12 }, new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Phong",
                keyColumn: "MaPhong",
                keyValue: "P005",
                columns: new[] { "AnhPhong", "NgayTao" },
                values: new object[] { new byte[] { 13, 14, 15 }, new DateTime(2023, 11, 18, 16, 32, 16, 287, DateTimeKind.Local).AddTicks(4108) });
        }
    }
}
