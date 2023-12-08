window.onload = function () {
    // Lấy thông tin từ sessionStorage
    document.getElementById('ngaynhan_text').innerText = sessionStorage.getItem('ngayNhanPhong');
    document.getElementById('ngaytra_text').innerText = sessionStorage.getItem('ngayTraPhong');
    document.getElementById('ngay_text').innerText = sessionStorage.getItem('ngayNhanPhongDaTinh');
    document.getElementById('gio_text').innerText = sessionStorage.getItem('gioTraPhongDaTinh');

    //document.getElementById('SoLuongNguoiLonDat_text').innerText = sessionStorage.getItem('slNguoiLonTimKiem');
    //document.getElementById('SoLuongTreEmDat_text').innerText = sessionStorage.getItem('slTreEmTimKiem');
    document.getElementById('maPhong_DatPhong').innerText = sessionStorage.getItem('maPhong');
    document.getElementById('giaTriSoLuongNguoiLonDat').innerText = sessionStorage.getItem('slNguoiLon');
    document.getElementById('giaTriSoLuongTreEmDat').innerText = sessionStorage.getItem('slTreEm');
    document.getElementById('TongTienPhong').innerText = sessionStorage.getItem('tongTienPhong');
    document.getElementById('TongTienDichVuDaDat').innerText = sessionStorage.getItem('tongTienDichVu');
    document.getElementById('TongTien').innerText = parseFloat(document.getElementById('TongTienPhong').innerText) + parseFloat(document.getElementById('TongTienDichVuDaDat').innerText)

    var maPhong = sessionStorage.getItem('maPhong');
    $.ajax({
        type: "GET",
        url: `/TrangChuKhachHang/LayThongTinPhongTheoMaPhong?maPhong=${maPhong}`,
        success: function (result) {
            document.getElementById('loaiPhongDatPhong').innerText = result.qr_LoaiPhong.tenLoaiPhong;
            document.getElementById('giaTheoGioDatPhong').innerText = result.qr_LoaiPhong.giaTheoGio;
            document.getElementById('giaTheoNgayDatPhong').innerText = result.qr_LoaiPhong.giaPhongTheoNgay;
        },
        error: function (error) {
            console.log(error)
        }
    });

    var maDichVu = JSON.parse(sessionStorage.getItem('arrMaDichVu').split(','));
    var soLuongDichVu = JSON.parse(sessionStorage.getItem('arrSoLuongDichVu').split(','));
    
    maDichVu.forEach(ShowDichVu);

    function ShowDichVu(item, index) {
        $.ajax({
            type: "GET",
            url: `/TrangChuKhachHang/LayThongTinDichVu?MaDichVu=${item}`,
            success: function (result) {
                var quantity = soLuongDichVu[index];
                var newDiv = document.createElement('span');
                newDiv.innerHTML = `<strong>Tên:</strong> ` + result.tenDichVu + ` - <strong>Giá:</strong> ` + result.giaTien + ` - <strong>SL:</strong> ` + quantity + `<br/>`;
                document.getElementById('ChonDichVu').appendChild(newDiv);
            },
            error: function (error) {
                console.log(error)
            }
        });
    }
}

$(document).ready(function () {
    $('#DatPhong').on('click', function () {
        // dữ liệu bên khách hàng
        var tenkh = $('#tenkh').val();
        var gioitinh = $('#gioitinh').val();
        var sdt = $('#so-dien-thoai').val();
        var email = $('#email').val();
        var ngaySinh = $('#ngay-sinh').val();
        var diaChi = $('#dia-chi').val();
        var cccd = $('#cccd').val();
        // dự liệu bên đặt phòng
        var ngaynhan = $('#ngaynhan_text').text();
        var ngaytra = $('#ngaytra_text').text();
        var maphong = $('#maPhong_DatPhong').text();
        var soLuongNguoiLon = $('#giaTriSoLuongNguoiLonDat').text();
        var soLuongTreEm = $('#giaTriSoLuongTreEmDat').text();
        var TongTien = $('#TongTien').text();

        var arrSoLuongDichVu = JSON.parse(sessionStorage.getItem('arrSoLuongDichVu'));
        var arrMaDichVu = JSON.parse(sessionStorage.getItem('arrMaDichVu'));
        console.log(arrSoLuongDichVu, arrMaDichVu);

        $.ajax({
            type: 'POST',
            url: `/TrangChuKhachHang/DatPhong`,
            data: {
                TenKhachHang: tenkh,
                GioiTinh: gioitinh,
                sdt: sdt,
                email: email,
                ngaysinh: ngaySinh,
                diachi: diaChi,
                cccd: cccd,
                NgayNhan: ngaynhan,
                NgayTra: ngaytra,
                MaPhong: maphong,
                SoLuongNguoiLon: soLuongNguoiLon,
                SoLuongTreEm: soLuongTreEm,
                TongTien: TongTien,
                arrSoLuongDichVu: arrSoLuongDichVu,
                arrMaDichVu: arrMaDichVu
            },
            success: function (response) {
                console.log(response);
            },
            error: function (error) {
                console.error('Error:', error);
            }
        });

    });
});
