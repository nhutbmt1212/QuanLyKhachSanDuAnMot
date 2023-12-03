window.onload = function () {
    //lấy thông tin từ localstorage
    document.getElementById('ngaynhan_text').innerText = localStorage.getItem('ngayNhanPhong');
    document.getElementById('ngaytra_text').innerText = localStorage.getItem('ngayTraPhong');
    document.getElementById('ngay_text').innerText = localStorage.getItem('ngayNhanPhongDaTinh');
    document.getElementById('gio_text').innerText = localStorage.getItem('gioTraPhongDaTinh');

    document.getElementById('SoLuongNguoiLonDat_text').innerText = localStorage.getItem('slNguoiLonTimKiem');
    document.getElementById('SoLuongTreEmDat_text').innerText = localStorage.getItem('slTreEmTimKiem');
    document.getElementById('maPhong_DatPhong').innerText = localStorage.getItem('maPhong');
    document.getElementById('giaTriSoLuongNguoiLonDat').innerText = localStorage.getItem('slNguoiLon');
    document.getElementById('giaTriSoLuongTreEmDat').innerText = localStorage.getItem('slTreEm');
    document.getElementById('TongTienPhong').innerText = localStorage.getItem('tongTienPhong');
    document.getElementById('TongTienDichVuDaDat').innerText = localStorage.getItem('tongTienDichVu');
    document.getElementById('TongTien').innerText = parseFloat(document.getElementById('TongTienPhong').innerText) + parseFloat(document.getElementById('TongTienDichVuDaDat').innerText)
    var maPhong = localStorage.getItem('maPhong');
    $.ajax({
        type: "GET",
        url: `/TrangChuKhachHang/LayThongTinPhongTheoMaPhong?maPhong=${maPhong}`,
        success: function (result) {
            document.getElementById('loaiPhongDatPhong').innerText = 'Loại phòng: ' + result.qr_LoaiPhong.tenLoaiPhong;
            document.getElementById('giaTheoGioDatPhong').innerText = 'Giá theo giờ: ' + result.qr_LoaiPhong.giaTheoGio;
            document.getElementById('giaTheoNgayDatPhong').innerText = 'Giá theo ngày: ' + result.qr_LoaiPhong.giaPhongTheoNgay;

        },
        error: function (error) {
            conssole.log(error)
        }


    });
    var maDichVu = localStorage.getItem('arrMaDichVu').split(',');
    var soLuongDichVu = localStorage.getItem('arrSoLuongDichVu').split(',');

    maDichVu.forEach(ShowDichVu);

    function ShowDichVu(item, index) {


      
        $.ajax({
            type: "GET",
            url: `/TrangChuKhachHang/LayThongTinDichVu?MaDichVu=${item}`,
            success: function (result) {
                var quantity = soLuongDichVu[index];
                var newDiv = document.createElement('div');
                newDiv.innerHTML = 'Tên dịch vụ: ' + result.tenDichVu + ', Đơn giá: ' + result.giaTien + ', Số Lượng: ' + quantity;
                document.getElementById('ChonDichVu').appendChild(newDiv);

                console.log(result)
            },
            error: function (error) {
                console.log(error)
            }
        });
      

    }





}

