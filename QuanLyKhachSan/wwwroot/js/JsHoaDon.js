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
            $('#MaDatPhong_ChiTiet').text(result.datPhong.maDatPhong);
            $('#MaPhong_ChiTiet').text(result.phong.maPhong);
            $('#MaKhachHang_ChiTiet').text(result.khachHang.maKhachHang);
            $('#TenKhachHang_ChiTiet').text(result.khachHang.tenKhachHang);
            $('#SoLuongNguoiLon_ChiTiet').text(result.loaiPhong.soLuongNguoiLon + " người lớn - " + result.loaiPhong.soLuongTreEm + " trẻ em");
            $('#HinhThucDatPhong_ChiTiet').text(result.datPhong.hinhThucDatPhong);
            $('#CCCD_ChiTiet').text(result.khachHang.cccd);
            $('#SoDienThoai_ChiTiet').text(result.khachHang.soDienThoai);
            $('#Email_ChiTiet').text(result.khachHang.email);
            $('#LoaiPhong_ChiTiet').text(result.loaiPhong.tenLoaiPhong);
            if ($('#HinhThucDatPhong_ChiTiet').text() == "Gio") {
                $('#GiaPhong_ChiTiet').text(result.loaiPhong.giaTheoGio);
            }
            else {
                $('#GiaPhong_ChiTiet').text(result.loaiPhong.giaPhongTheoNgay);
            }

            $('#ThoiGianNhanPhong_ChiTiet').text(result.datPhong.ngayNhan);
            $('#ThoiGianTraPhong_ChiTiet').text(result.datPhong.ngayTra);


            $('#TongTien_ChiTiet').text(result.datPhong.tongTienPhong);
            XemChiTietDichVu(MaHoaDon); 


        },
        error: function () {

        }

    });

}

function XemChiTietDichVu(MaHoaDon) {
    $.ajax({
        type: 'POST',
        url: '/HoaDon/LayThongTinDichVu',
        data: { 'MaHoaDon': MaHoaDon },
        success: function (result) {
            console.log(result);
            var dichVuChiTietTable = $('#DichVuCon');

            dichVuChiTietTable.empty();

            result.dichVuChiTiet.forEach(function (item) {
                console.log(item)
                var row = '<tr>' +
                    '<td>' + item.maDichVu + '</td>' +
                    '<td>' + item.dichVu.tenDichVu + '</td>' +
                    '<td>' + item.dichVu.giaTien + '</td>' +
                    '<td>' + item.soLuong + '</td>' +
                    '</tr>';

                dichVuChiTietTable.append(row);
            });

          
        },
        error: function () {
        }
    });
}