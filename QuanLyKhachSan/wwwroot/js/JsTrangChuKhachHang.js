
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
    document.getElementById('TongTien').innerText = tongCongTienDatPhong + " VND";



}
document.getElementById('btn_DatPhong').addEventListener('click', DatPhongKhachSan);
function DatPhongKhachSan() {
    var divPhong = document.getElementById('Infor_Phong_Chon')
    if (divPhong.innerHTML == "") {
        alert('Bạn chưa chọn phòng để đặt');
    }
    else {
        console.log(divPhong.innerHTML);

    }
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

    document.getElementById('ipt_NgayNhan').min = new Date().toISOString().slice(0, 16);
    document.getElementById('ipt_NgayTra').min = new Date().toISOString().slice(0, 16);
}

document.getElementById('TimKiemPhong').onclick = function () {
    var ngayNhan = document.getElementById('ipt_NgayNhan').value;
    var ngayTra = document.getElementById('ipt_NgayTra').value;
    var slNgLon = document.getElementById('SlNguoiLon').value;
    var slTreEm = document.getElementById('SlTreEm').value;
    if (ngayNhan == "" || ngayTra == "") {
        alert("Chựa chọn ngày nhận kìa");
    }
    else if (slNgLon == "" || slTreEm == "") {
        alert("Bạn chưa chọn số lượng kìa");
    }
    else {

        document.getElementById('ngaynhan_text').innerHTML = ngayNhan;
        document.getElementById('ngaytra_text').innerHTML = ngayTra;
        var ngayNhancal = new Date(document.getElementById('ipt_NgayNhan').value);
        var ngayTracal = new Date(document.getElementById('ipt_NgayTra').value);

        var soGio = Math.abs(ngayTracal - ngayNhancal) / 3600000;
        var soNgay = Math.round(soGio / 24);
        var soGioLe = soGio % 24;

        document.getElementById('ngay_text').innerHTML = soNgay;
        document.getElementById('gio_text').innerHTML = soGioLe;
        document.getElementById('SoLuongNguoiLonDat_text').innerHTML = slNgLon;
        document.getElementById('SoLuongTreEmDat_text').innerHTML = slTreEm;
        document.getElementById('btn_DatPhong').style.display = 'block';
        

    }


}
var counter = 0;

document.getElementById('AddThemDichVu').addEventListener('click', ThemDichVu);

function ThemDichVu() {
    counter++;

    var node = `
    <div class="row">
    <div class="col-8">
        <select class="form-select w-100" id="themdichvuselect${counter}">
            <option>1</option>
            <option>2</option>
            <option>3</option>
        </select>
        </div>
            <div class="col-4">

        <button id="XoaSelectDichVu${counter}" class="btn btn-outline-danger" onclick="XoaSelectDichVu(${counter})"><i class="bi bi-trash3"></i></button>
        </div>
</div>
    `;

    $('#ChonDichVu').append(node);
}
function XoaSelectDichVu(idSelect) {
    var idSelectThemDichvu = "themdichvuselect" + idSelect;
    var idbtnXoaDichvu = "XoaSelectDichVu" + idSelect;
    document.getElementById(idSelectThemDichvu).remove();
    document.getElementById(idbtnXoaDichvu).remove();
}

