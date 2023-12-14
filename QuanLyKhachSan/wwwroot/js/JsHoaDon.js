function closePopup() {
    document.getElementById('popup').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}

function XemChiTietHoaDon(MaHoaDon) {

    document.getElementById('popup').style.display = 'block';
    document.getElementById('overlay').style.display = 'block';

    document.getElementById('MaHoaDon_ChiTiet').textContent = MaHoaDon;

    // lay full thông tin đặt phòng
    $.ajax({
        type:'POST',
        url: '/HoaDon/LayThongTinHoaDon',
        data: { 'MaHoaDon': MaHoaDon },
        success: function (result) {
            console.log(result);
            $('#MaDatPhong_ChiTiet').text(result.qr_DatPhong.maDatPhong);
            $('#MaPhong_ChiTiet').text(result.qr_Phong.maPhong);
            $('#MaKhachHang_ChiTiet').text(result.qr_KhachHang.maKhachHang);
            $('#TenKhachHang_ChiTiet').text(result.qr_KhachHang.tenKhachHang);
            $('#SoLuongNguoiLon_ChiTiet').text(result.qr_LoaiPhong.soLuongNguoiLon + " người lớn - " + result.qr_LoaiPhong.soLuongTreEm + " trẻ em");
            $('#HinhThucDatPhong_ChiTiet').text(result.qr_DatPhong.hinhThucDatPhong);
            $('#CCCD_ChiTiet').text(result.qr_KhachHang.cccd);
            $('#SoDienThoai_ChiTiet').text(result.qr_KhachHang.soDienThoai);

        },
        error: function () {

        }

    });

}