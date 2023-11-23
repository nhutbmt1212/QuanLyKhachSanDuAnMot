
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

                $("#pricetheogio-" + maPhong).text(data.giaTheoGio);
                $("#pricetheongay-" + maPhong).text(data.giaPhongTheoNgay);

                $("#soLuongNguoi-" + maPhong).text("Số lượng người lớn: " + data.soLuongNguoiLon + "  |  " + "Số lượng trẻ em: " + data.soLuongTreEm);
                $("#phuThuTraMuon-" + maPhong).text("Phụ thu trả muộn: " + data.phuThuTraMuon + "/1 ngày");


            }
        });
}
function DatPhong(MaPhong) {
    var LoaiPhong = document.getElementById('loaiPhong-' + MaPhong).innerText;
    var giaTheoGio = document.getElementById('pricetheogio-' + MaPhong).innerText;
    var giaTheoNgay = document.getElementById('pricetheongay-' + MaPhong).innerText;

    var node = `
    <span id="maPhongDatPhong"> Mã phòng: <strong>${MaPhong}</strong> </span>
    <br id="break1"/>
    <span id="loaiPhongDatPhong">${LoaiPhong}</span>
    <br id="break2"/>
    <span id="giaTheoGioDatPhong">Giá theo giờ: ${giaTheoGio}</span> <span id="giaTheoNgayDatPhong">Giá theo ngày: ${giaTheoNgay}</span>
    <br id="break3"/>
    <button class="btn btn-outline-warning huy_datPhong_DatPhong" onclick="HuyDatPhong()" id="huy_dat_phong"><i class="bi bi-x-lg"></i>  Hủy</button>
   
    `;
    $("#Infor_Phong_Chon").html(node);
    var ngayDat = document.getElementById('ngay_text').innerText;
    var gioDat = document.getElementById('gio_text').innerText;
    var tongCongTienDatPhong = (ngayDat * giaTheoNgay) + (gioDat * giaTheoGio);
    document.getElementById('TongTien').innerText = tongCongTienDatPhong +" VND";
    
}
function HuyDatPhong() {
    document.getElementById('maPhongDatPhong').remove();
    document.getElementById('loaiPhongDatPhong').remove();
    document.getElementById('giaTheoGioDatPhong').remove();
    document.getElementById('giaTheoNgayDatPhong').remove();
    document.getElementById('huy_dat_phong').remove();
    document.getElementById('break1').remove();
    document.getElementById('break2').remove();
    document.getElementById('break3').remove();
    document.getElementById('TongTien').innerText = "0 VND";

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

