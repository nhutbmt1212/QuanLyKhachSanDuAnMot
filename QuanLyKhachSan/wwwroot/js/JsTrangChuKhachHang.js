
    $(document).ready(function () {
        $('.room-type').each(function () {
            var maPhong = $(this).attr('id');
            fetchRoomType(maPhong, this);
        });
        });

    function fetchRoomType(maPhong, element) {
        $.ajax({
            url: '/TrangChuKhachHang/LayLoaiPhong',
            type: 'GET',
            data: { maPhong: maPhong },
            success: function (data) {
                $(".loaiPhong").text(data.tenLoaiPhong);
                $("#loaiPhong-" + maPhong).text("Loại phòng: " + data.tenLoaiPhong);

                $("#price-" + maPhong).text("Giá theo giờ: " + data.giaTheoGio + "  |  " + "Giá theo ngày: " + data.giaPhongTheoNgay);
                $("#soLuongNguoi-" + maPhong).text("Số lượng người lớn: " + data.soLuongNguoiLon + "  |  " + "Số lượng trẻ em: " + data.soLuongTreEm);
                $("#phuThuTraMuon-" + maPhong).text("Phụ thu trả muộn: " + data.phuThuTraMuon + "/1 ngày");


            }
        });
}
function DatPhong(MaPhong) {
    var LoaiPhong = document.getElementById('loaiPhong-' + MaPhong).innerText;
    var a = `<span> Mã phòng: <strong>${MaPhong}</strong> </span>
    <br/>
    <span>${LoaiPhong}</span>
    `;
    $("#Infor_Phong_Chon").html(a);
    
}

window.onload = function () {
    var now = new Date();
    var year = now.getFullYear();
    var month = now.getMonth() + 1;
    var day = now.getDate();
    var hour = now.getHours();
    var minute = now.getMinutes();
    var datemin = year + "-" + month + "-" + day + "T" + hour + ":" + minute;
    var ngayNhan = document.getElementById('ipt_NgayNhan');
    var ngayTra = document.getElementById('ipt_NgayTra');
    ngayNhan.setAttribute('min', datemin);
    ngayTra.setAttribute('min', datemin);
}

document.getElementById('TimKiemPhong').onclick = function () {
    var ngayNhan = document.getElementById('ipt_NgayNhan').value;
    var ngayTra = document.getElementById('ipt_NgayTra').value;
    document.getElementById('ngaynhan_text').innerHTML = ngayNhan;
    document.getElementById('ngaytra_text').innerHTML = ngayTra;
    var soluongNguoiO = document.getElementById('sophong').value;
    var ngayNhancal = new Date(document.getElementById('ipt_NgayNhan').value);
    var ngayTracal = new Date(document.getElementById('ipt_NgayTra').value);

    var soGio = Math.abs(ngayTracal - ngayNhancal) / 3600000 ;
    var soNgay = Math.round(soGio / 24);
    var soGioLe = soGio % 24;

    document.getElementById('SoLuongNguoiDat_text').innerHTML = soluongNguoiO;
    document.getElementById('ngay_text').innerHTML = soNgay;
    document.getElementById('gio_text').innerHTML = soGioLe;
    
}

