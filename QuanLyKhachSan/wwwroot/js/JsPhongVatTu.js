function ThemVatTu() {
    var maPhong = $('#inputFieldChonPhong').val();
    var maVatTu = $('#inputFieldChonVatTu').val();
    var soLuong = $('#inputFieldSoLuong').val();
    $.ajax({
        type: 'POST',
        url: '/ChiTietPhongVatTu/ThemVatTuVaoPhong',
        data: {
            'MaPhong': maPhong,
            'MaVatTu': maVatTu,
            'SoLuong': soLuong
        },
        success: function () {
            alert('Thêm thành công');
        },
        error: function () {
        }
    });
}
var btn_them = document.getElementById('btn_themPhong');
function SuaVatTu(btn, maPhong, maVatTu, soLuong, tinhTrang) {
    document.getElementById("myForm").style.display = "none";
    btn_them.style.display = 'block';
    document.getElementById("myFormEdit").style.display = "block";
    $('#inputEditMaPhong').val(maPhong);
    $('#inputEditMaVatTu').val(maVatTu);
    $('#inputEditSoLuong').val(soLuong);
    $('#inputEditTinhTrang').val(tinhTrang);
}

function SuaVatTuPhong() {
    var maPhong=  $('#inputEditMaPhong').val();
    var maVatTu=  $('#inputEditMaVatTu').val();
    var soLuong=  $('#inputEditSoLuong').val();
    var tinhTrang = $('#inputEditTinhTrang').val();
    $.ajax({
        type: "POST",
        url: "/ChiTietPhongVatTu/SuaPhongVatTu",
        data: {
            'MaPhong': maPhong,
            'MaVatTu': maVatTu,
            'SoLuong': soLuong,
            'TinhTrang': tinhTrang
        },
         success: function (data) {
            // Xử lý phản hồi thành công từ server
            // data có thể chứa thông tin phản hồi từ server (nếu có)

            // Ví dụ: Hiển thị thông báo thành công
            alert('Sửa thành công');

            // Cập nhật giao diện hoặc thực hiện các bước khác (nếu cần)
        },
        error: function (error) {
            // Xử lý lỗi khi gửi yêu cầu đến server
            // error chứa thông tin lỗi từ server (nếu có)

            // Ví dụ: Hiển thị thông báo lỗi
            alert('Đã xảy ra lỗi. Vui lòng thử lại.');

            // Thực hiện các bước khác tùy thuộc vào nhu cầu
        }
    });

}

function XoaVatTuPhong(MaVatTu, MaPhong) {
    
    $.ajax({
        type: "POST",
        url: "/ChiTietPhongVatTu/XoaPhongVatTu",
        data: {
            'MaPhong': MaPhong,
            'MaVatTu': MaVatTu
        },
        success: function (data) {
          
            alert('Xóa thành công');

        },
        error: function (error) {
        
            alert('Đã xảy ra lỗi. Vui lòng thử lại.');
        }
    });
}