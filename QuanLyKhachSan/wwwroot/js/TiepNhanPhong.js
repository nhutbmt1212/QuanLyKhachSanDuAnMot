function openPopup(maDatPhong) {
    $.ajax({
        url: '/TiepNhanDatPhong/GetReservationDetails',
        type: 'GET',
        data: { maDatPhong: maDatPhong },
        success: function (data) {
            document.getElementById('popup').style.display = 'block';
            document.getElementById('overlay').style.display = 'block';
            populatePopupWithData(data);
            getChiTietDichVu(maDatPhong);
        },
        error: function (error) {
            console.error('Error fetching reservation details:', error);
        }
    });
}
function populatePopupWithData(data) {
    console.log(data);
    document.getElementById('MaDatPhong_ChiTiet').innerText = data.maDatPhong;
    document.getElementById('MaPhong_ChiTiet').innerText = data.maPhong;
    document.getElementById('MaKhachHang_ChiTiet').innerText = data.maKhachHang;
    document.getElementById('TenKhachHang_ChiTiet').innerText = data.khachHang.tenKhachHang;
    document.getElementById('SoLuongNguoiLon_ChiTiet').innerText = data.soLuongNguoiLon + ' người lớn - ' + data.soLuongTreEm + ' trẻ em';
    document.getElementById('HinhThucDatPhong_ChiTiet').innerText = data.hinhThucDatPhong;
    document.getElementById('CCCD_ChiTiet').innerText = data.khachHang.cccd;
    document.getElementById('SoDienThoai_ChiTiet').innerText = data.khachHang.soDienThoai;
    document.getElementById('Email_ChiTiet').innerText = data.khachHang.email;

    document.getElementById('LoaiPhong_ChiTiet').innerText = data.phong.loaiPhong.tenLoaiPhong;
    document.getElementById('GiaPhong_ChiTiet').innerText = data.phong.loaiPhong.giaPhongTheoNgay;
    document.getElementById('ThoiGianNhanPhong_ChiTiet').innerText = data.ngayNhan;
    document.getElementById('ThoiGianTraPhong_ChiTiet').innerText = data.ngayTra;
    document.getElementById('TongTien_ChiTiet').innerText = data.tongTienPhong;
}
function getChiTietDichVu(maDatPhong) {
    $.ajax({
        url: '/TiepNhanDatPhong/GetServiceItems',
        type: 'GET',
        data: { maDatPhong: maDatPhong },
        success: function (data) {
            populateServiceItems(data);
        },
        error: function () {
            console.error('Error retrieving service items.');
        }
    });
}
function populateServiceItems(serviceItems) {
    console.log(serviceItems);
    if (serviceItems) {
        var serviceItemsList = '<ul>';
        serviceItems.forEach(function (item) {
            serviceItemsList += '<li>' + item.tenDichVu + ' - Số lượng: ' + item.soLuong + ' - Giá: ' + item.giaTien + '</li>';
        });
        serviceItemsList += '</ul>';

        document.getElementById('DichVuDiKem_ChiTiet').innerHTML = serviceItemsList;
    } else {
        console.error('Service items data is null or undefined.');
    }
}
function closePopup() {
    document.getElementById('popup').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}
function chapNhanDatPhong() {
    var maDatPhong = document.getElementById('MaDatPhong_ChiTiet').innerText;
    // Gửi yêu cầu AJAX để chấp nhận đặt phòng
    $.ajax({
        url: '/TiepNhanDatPhong/ChapNhanDatPhong',
        type: 'POST',
        data: { maDatPhong: maDatPhong },
        success: function () {
            window.location.href = '/TiepNhanDatPhong/Index';
        },
        error: function (error) {
            console.error('Lỗi khi chấp nhận đặt phòng:', error);
        }
    });
}

function nhanPhongChiTiet(maDatPhong) {
    // Gửi yêu cầu AJAX để chấp nhận đặt phòng
    $.ajax({
        url: '/TiepNhanDatPhong/ChapNhanDatPhong',
        type: 'POST',
        data: { maDatPhong: maDatPhong },
        success: function () {
            window.location.href = '/TiepNhanDatPhong/Index';
        },
        error: function (error) {
            console.error('Lỗi khi chấp nhận đặt phòng:', error);
        }
    });
}

function huyDatPhongChiTiet(maDatPhong) {
    // Gửi yêu cầu AJAX để chấp nhận đặt phòng
    $.ajax({
        url: '/TiepNhanDatPhong/HuyDatPhong',
        type: 'POST',
        data: { maDatPhong: maDatPhong },
        success: function () {
            window.location.href = '/TiepNhanDatPhong/Index';
        },
        error: function (error) {
            console.error('Lỗi khi chấp nhận đặt phòng:', error);
        }
    });
}
function huyDatPhong() {
    var maDatPhong = document.getElementById('MaDatPhong_ChiTiet').innerText;
    // Gửi yêu cầu AJAX để chấp nhận đặt phòng
    $.ajax({
        url: '/TiepNhanDatPhong/HuyDatPhong',
        type: 'POST',
        data: { maDatPhong: maDatPhong },
        success: function () {
            window.location.href = '/TiepNhanDatPhong/Index';
        },
        error: function (error) {
            console.error('Lỗi khi chấp nhận đặt phòng:', error);
        }
    });
}