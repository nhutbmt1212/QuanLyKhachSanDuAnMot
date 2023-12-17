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
            $("#loaiPhong-" + maPhong).text(data.tenLoaiPhong);

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
    var slNgLonDatPhong = document.getElementById('slNguoiLonDatPhong-' + MaPhong).value;
    var slTreEmDatPhong = document.getElementById('slTreEmDatPhong-' + MaPhong).value;

    var node = `
    <span id="maPhongDatPhong"> Mã phòng: <strong id="maPhong_DatPhong">${MaPhong}</strong> </span>
    <br id="break1"/>
    <span id="loaiPhongDatPhong">${LoaiPhong}</span>
    <br id="break2"/>
    <span id="giaTheoGioDatPhong">Giá theo giờ: ${giaTheoGio}</span> <span id="giaTheoNgayDatPhong">Giá theo ngày: ${giaTheoNgay}</span>
    <br id="break3"/>
    <span id="SoLuongNguoiLonDatPhong">Số lượng người lớn ở: <span id="giaTriSoLuongNguoiLonDat">${slNgLonDatPhong}</span></span> <span id="soLuongTreEmDatPhong">Số lượng trẻ em ở: <span id="giaTriSoLuongTreEmDat">${slTreEmDatPhong}</span></span>
    <br id="break4"/>
    <button class="btn btn-outline-warning huy_datPhong_DatPhong" onclick="HuyDatPhong()" id="huy_dat_phong"><i class="bi bi-x-lg"></i>  Hủy</button>
    `;
    $("#Infor_Phong_Chon").html(node);

    var ngayDat = document.getElementById('ngay_text').innerText;
    var gioDat = document.getElementById('gio_text').innerText;
    var tongCongTienDatPhong = (ngayDat * giaTheoNgay) + (gioDat * giaTheoGio);
    document.getElementById('TongTienPhong').innerText = tongCongTienDatPhong;
    TinhTongTienDatPhong();
}
document.getElementById('btn_DatPhong').addEventListener('click', DatPhongKhachSan);
function DatPhongKhachSan() {
    var divPhong = document.getElementById('Infor_Phong_Chon')
    if (/^\s*$/.test(divPhong.innerHTML)) {
        alert('Bạn chưa chọn phòng để đặt');
    } else {
        console.log(divPhong.innerHTML);
    }
    TinhTongTienDatPhong();
}
function HuyDatPhong() {
    var MaPhong = document.getElementById('maPhong_DatPhong').innerText;

    document.getElementById('maPhongDatPhong').remove();
    document.getElementById('loaiPhongDatPhong').remove();
    document.getElementById('giaTheoGioDatPhong').remove();
    document.getElementById('giaTheoNgayDatPhong').remove();
    document.getElementById('SoLuongNguoiLonDatPhong').remove();
    document.getElementById('soLuongTreEmDatPhong').remove();
    document.getElementById('huy_dat_phong').remove();
    document.getElementById('break1').remove();
    document.getElementById('break2').remove();
    document.getElementById('break3').remove();
    document.getElementById('break4').remove();
    document.getElementById('TongTienPhong').innerText = "0";
    TinhTongTienDatPhong();

}
window.onload = function () {
    // Lấy ngày và giờ hiện tại
    var currentDate = new Date();
    currentDate.setHours(currentDate.getHours() + 2);
    // Đặt giá trị min cho ô input Ngày Nhận và Ngày Trả
    document.getElementById('ipt_NgayNhan').min = formatDate(currentDate);
    document.getElementById('ipt_NgayTra').min = formatDate(currentDate);

    // Đặt giá trị mặc định cho ô input Ngày Nhận và Ngày Trả
    document.getElementById('ipt_NgayNhan').value = formatDate(currentDate);
    document.getElementById('ipt_NgayTra').value = formatDate(currentDate);

    console.log(currentDate);
}

// Hàm chuyển đổi đối tượng Date thành chuỗi ngày/tháng/năm giờ:phút
function formatDate(date) {
    var day = date.getDate();
    var month = date.getMonth() + 1; // Lưu ý: getMonth trả về số tháng từ 0 đến 11
    var year = date.getFullYear();
    var hours = date.getHours();
    var minutes = date.getMinutes();

    // Định dạng số đẹp hơn (thêm 0 nếu cần)
    day = day < 10 ? '0' + day : day;
    month = month < 10 ? '0' + month : month;
    hours = hours < 10 ? '0' + hours : hours;
    minutes = minutes < 10 ? '0' + minutes : minutes;

    return year + '-' + month + '-' + day + 'T' + hours + ':' + minutes;
}

document.getElementById('TimKiemPhong').onclick = function () {
    var ngayNhan = document.getElementById('ipt_NgayNhan').value;
    var ngayTra = document.getElementById('ipt_NgayTra').value;
    var slNgLon = document.getElementById('SlNguoiLon').value;
    var slTreEm = document.getElementById('SlTreEm').value;
    var reportPhong = document.getElementById('Report_Phong');
    var room_infor = document.getElementById('room-infor');

    var ngayNhanValidate = new Date(document.getElementById('ipt_NgayNhan').value);
    var ngayTraValidate = new Date(document.getElementById('ipt_NgayTra').value);
    var chenhlechthoigian = ngayTraValidate - ngayNhanValidate;
    var chenhlechgio = chenhlechthoigian / (1000 * 60 * 60);
    var ngayNhanValidate = new Date(ngayNhan);
    
    var now = new Date();

    if (ngayNhanValidate < now) {
        document.getElementById('Error_NgayNhan').textContent = 'Ngày nhận phải lớn hơn ngày giờ hiện tại';
        return;
    } else {
        document.getElementById('Error_NgayNhan').textContent = '';
    }

    if (chenhlechgio <= 3) {
        document.getElementById('Error_NgayTra').textContent = "Thời gian đặt phòng phải lớn hơn 3 giờ";
        return;
    } else {
        document.getElementById('Error_NgayTra').textContent = '';
    }
 
     if (ngayNhan == "") {
        alert('Bạn chưa chọn ngày nhận');
    }
    else if (ngayTra == "") {
        alert('Bạn chưa chọn ngày trả');
    }
    else {
        $.ajax({
            type: "GET",
            url: `/TrangChuKhachHang/TimKiemPhong?NgayNhanPhong=${ngayNhan}&NgayTraPhong=${ngayTra}&SoLuongNguoiLon=${slNgLon}&SoLuongTreEm=${slTreEm}`,
            success: function (result) {
                var maPhongDaDatList = result.maPhongDaDatList.map(r => r.trim().toUpperCase());
                var PhongKhongdieuKien = result.qr_PhongKhongDatTieuChuan.map(r => r.trim().toUpperCase());
                console.log(maPhongDaDatList, PhongKhongdieuKien);
                $('.room-detail').each(function () {
                    var maPhong = $(this).find('h3').text().split('-')[0].trim().toUpperCase();                    console.log(maPhong);// Convert to uppercase and trim
                    if (maPhongDaDatList.includes(maPhong) || PhongKhongdieuKien.includes(maPhong)) {
                        $(this).hide();
                        reportPhong.style.display = "none";
                        room_infor.style.display = "block";
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

                    else {
                        $(this).show();
                        reportPhong.style.display = "none";
                        room_infor.style.display = "block";
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
                });

                if ($('.room-detail:visible').length == 0) {
                    room_infor.style.display = "none";
                    reportPhong.style.display = "block";
                }

            },

            error: function (error) {
                console.log(error);
            }
        });




    }
}
var arrDichVuDaChon = [];
var counter = -1;
var soLuongdichVu;

document.getElementById('AddThemDichVu').addEventListener('click', ThemDichVu);
function ThemDichVu() {
    counter++;

    var url = '/TrangChuKhachHang/LayDanhSachDichVu';

    $.ajax({
        url: url,
        type: 'GET',
        success: function (data) {
            var options = '';

            $.each(data, function (index, itemDichVu) {
                if (!arrDichVuDaChon.includes(itemDichVu.maDichVu)) {
                    options += `<option value="${itemDichVu.maDichVu}" class="optionChonDichVu">${itemDichVu.tenDichVu} - ${itemDichVu.giaTien}/ ${itemDichVu.donViTinh}</option>`;
                }

            });

            var node = `
                <div class="row" id="id_DichVu${counter}">
                    <div class="col-lg-7" style="margin-bottom:5px;">
                        <select class="form-select w-100" id="themdichvuselect${counter}" onchange="DichVuDaChon(${counter})" >
                            ${options}
                        </select>
                    </div>
                    <div class="col-lg-3">
                        <input type="number" class="form-control w-100" id="soLuongDichVu${counter}" onchange="ThayDoiSoLuongDichVu(${counter})" min="1" value="1">
                    </div>
                    <div class="col-2">
                        <button id="XoaSelectDichVu${counter}" class="btn btn-outline-danger" onclick="XoaSelectDichVu(${counter})">
                            <i class="bi bi-trash3"></i>
                        </button>
                    </div>
                </div>
            `;

            $('#ChonDichVu').append(node);
            var dichVuDaChonTheoId = document.getElementById('themdichvuselect' + counter).value;
            arrDichVuDaChon[counter] = dichVuDaChonTheoId;

            $('#themdichvuselect' + counter).focus(function () {
                // Lặp qua tất cả các option
                $(this).find('.optionChonDichVu').each(function () {
                    // Nếu giá trị option nằm trong mảng arrDichVuDaChon, ẩn option đó
                    if (arrDichVuDaChon.includes($(this).val())) {
                        $(this).hide();
                    } else {
                        $(this).show();
                    }
                });
            });
            if (arrDichVuDaChon.filter(function (e) { return e }).length == data.length) {
                document.getElementById('AddThemDichVu').style.display = 'none';

            }
            var dichVuDaChon = document.getElementById('themdichvuselect' + counter).value;
            var soLuongDichVu = document.getElementById('soLuongDichVu' + counter).value;
            var nodeServices = `<br id="breakDichVu${counter}"/><span id="tongTenDichVuDaDat${counter}">Tên dịch vụ: ${dichVuDaChon} | </span><span id="tongSoLuongDichVuDaDat${counter}">Số lượng: ${soLuongDichVu}</span>`;
            $('#TongDichVuDaDat').append(nodeServices);
            //mảng để tính tiền
            TinhTienDichVu();
        },
        error: function (error) {
            console.error('Error fetching data:', error);
        }
    });



}
function TinhTienDichVu() {
    var ThanhTienMaDichVu = [];
    var arrSoLuongDichVu = [];
    $('span[id^="tongTenDichVuDaDat"]').each(function () {
        ThanhTienMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
    });
    $('span[id^="tongSoLuongDichVuDaDat"]').each(function () {
        arrSoLuongDichVu.push($(this).text().split(": ")[1]);
    });
    $.ajax({
        url: '/TrangChuKhachHang/TinhTienDichVu',
        type: 'POST',
        data: { 'arrMaDichVu': ThanhTienMaDichVu, 'arrSoLuongDichVu': arrSoLuongDichVu },
        traditional: true,
        success: function (result) {
            document.getElementById('TongTienDichVuDaDat').innerText = result;
            TinhTongTienDatPhong();
        },
        error: function (xhr, status, error) {
        }
    });
}


function DichVuDaChon(id) {

    var dichVuDaChonTheoId = document.getElementById('themdichvuselect' + id).value;
    if (arrDichVuDaChon[id] == "") {
        console.log("mảng rỗng")
    }
    else {

        var dichVuDaChon = document.getElementById('themdichvuselect' + id).value;
        var soLuongDichVu = document.getElementById('soLuongDichVu' + id).value;

        var tongTextTenDichVuDaDat = "tongTenDichVuDaDat" + id;
        var tongTextSoLuongDichVuDaDat = document.getElementById("tongSoLuongDichVuDaDat" + id);
        document.getElementById(tongTextTenDichVuDaDat).innerText = `Tên dịch vụ: ${dichVuDaChon} | `;
        tongTextSoLuongDichVuDaDat.innerText = `Số lượng: ${soLuongDichVu}`;
        arrDichVuDaChon[id] = dichVuDaChonTheoId;
        TinhTienDichVu();
    }
}

function ThayDoiSoLuongDichVu(id) {
    var SoLuongDichVuDaThayDoi = document.getElementById('soLuongDichVu' + id).value;
    var tongTextSoLuongDichVuDaDat = document.getElementById("tongSoLuongDichVuDaDat" + id);
    tongTextSoLuongDichVuDaDat.innerText = `Số lượng: ${SoLuongDichVuDaThayDoi}`;
    TinhTienDichVu();
}
function XoaSelectDichVu(idSelect) {
    var idTongTheDichVu = 'id_DichVu' + idSelect;
    document.getElementById(idTongTheDichVu).remove();
    arrDichVuDaChon[idSelect] = "";
    document.getElementById('AddThemDichVu').style.display = 'block';
    //xóa text dịch vụ đã chọn
    var tongTextTenDichVuDaDat = "tongTenDichVuDaDat" + idSelect;
    var tongTextSoLuongDaDat = "tongSoLuongDichVuDaDat" + idSelect;
    var breakTongDichVu = "breakDichVu" + idSelect;
    document.getElementById(tongTextSoLuongDaDat).remove();
    document.getElementById(tongTextTenDichVuDaDat).remove();
    document.getElementById(breakTongDichVu).remove();
    TinhTienDichVu();
}
$(document).ready(function () {
    $('.room-detail').each(function () {
        var roomElement = $(this);
        var maPhong = roomElement.data('room-id');

        $.ajax({
            url: '/TrangChuKhachHang/SlideAnhPhong',
            type: 'GET',
            data: { maPhong: maPhong },
            success: function (data) {
                if (data && data.length > 0) {
                    roomElement.find('.slider').data('images', data);
                    updateImage(roomElement.find('.slider'));
                }
            },
            error: function (error) {
                console.log('Error:', error);
            }
        });

        roomElement.find('.next').on('click', function () {
            var slider = roomElement.find('.slider');
            var currentIndex = slider.data('current-index');
            var images = slider.data('images');
            if (currentIndex < images.length - 1) {
                slider.data('current-index', currentIndex + 1);
            } else {
                slider.data('current-index', 0);
            }
            updateImage(slider);
        });

        roomElement.find('.prev').on('click', function () {
            var slider = roomElement.find('.slider');
            var currentIndex = slider.data('current-index');
            var images = slider.data('images');
            if (currentIndex > 0) {
                slider.data('current-index', currentIndex - 1);
            } else {
                slider.data('current-index', images.length - 1);
            }
            updateImage(slider);
        });
        setInterval(function AutoNextSlider() {
            var slider = roomElement.find('.slider');
            var currentIndex = slider.data('current-index');
            var images = slider.data('images');
            if (currentIndex < images.length - 1) {
                slider.data('current-index', currentIndex + 1);
            } else {
                slider.data('current-index', 0);
            }
            updateImage(slider);
        }, 10000);

    });
});
function updateImage(slider) {
    var currentIndex = slider.data('current-index');
    var images = slider.data('images');
    var imageUrl = images[currentIndex];
    slider.find('.img_detail_room').attr('src', '/UploadImage/' + imageUrl);
}
function TinhTongTienDatPhong() {
    var TongTienPhong = parseFloat(document.getElementById('TongTienPhong').innerText);
    var TongTienDichVu = parseInt(document.getElementById('TongTienDichVuDaDat').innerText);
    console.log(TongTienPhong, TongTienDichVu);
    document.getElementById('TongTien').innerText = TongTienPhong + TongTienDichVu;
};

document.getElementById('btn_DatPhong').addEventListener('click', DatPhongKhachSan);
function DatPhongKhachSan() {
    var divPhong = document.getElementById('Infor_Phong_Chon')
    if (/^\s*$/.test(divPhong.innerHTML)) {
        alert('Bạn chưa chọn phòng để đặt');
    } else {
        var ngayNhanPhong = document.getElementById('ngaynhan_text').innerText;
        sessionStorage.setItem('ngayNhanPhong', ngayNhanPhong);

        var ngayTraPhong = document.getElementById('ngaytra_text').innerText;
        sessionStorage.setItem('ngayTraPhong', ngayTraPhong);

        var TinhNgay = document.getElementById('ngay_text').innerText;
        sessionStorage.setItem('ngayNhanPhongDaTinh', TinhNgay);

        var TinhGio = document.getElementById('gio_text').innerText;
        sessionStorage.setItem('gioTraPhongDaTinh', TinhGio);

        var soLuongNguoiLonTimKiem = document.getElementById('SoLuongNguoiLonDat_text').innerText;
        var soLuongTreEmTimKiem = document.getElementById('SoLuongTreEmDat_text').innerText;
        sessionStorage.setItem('slNguoiLonTimKiem', soLuongNguoiLonTimKiem);
        sessionStorage.setItem('slTreEmTimKiem', soLuongTreEmTimKiem);

        var maPhong = document.getElementById('maPhong_DatPhong').innerText;
        sessionStorage.setItem('maPhong', maPhong);

        var slNguoiLonDat = document.getElementById('giaTriSoLuongNguoiLonDat').innerText;
        sessionStorage.setItem('slNguoiLon', slNguoiLonDat);

        var slTreEmDat = document.getElementById('giaTriSoLuongTreEmDat').innerText;
        sessionStorage.setItem('slTreEm', slTreEmDat);

        var ThanhTienMaDichVu = [];
        var arrSoLuongDichVu = [];

        $('span[id^="tongTenDichVuDaDat"]').each(function () {
            ThanhTienMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
        });

        $('span[id^="tongSoLuongDichVuDaDat"]').each(function () {
            arrSoLuongDichVu.push($(this).text().split(": ")[1]);
        });

        sessionStorage.setItem('arrMaDichVu', JSON.stringify(ThanhTienMaDichVu));
        sessionStorage.setItem('arrSoLuongDichVu', JSON.stringify(arrSoLuongDichVu));

        var tongTienPhong = document.getElementById('TongTienPhong').innerText;
        var tongTienDichVu = document.getElementById('TongTienDichVuDaDat').innerText;

        sessionStorage.setItem('tongTienPhong', tongTienPhong);
        sessionStorage.setItem('tongTienDichVu', tongTienDichVu);

        window.location.href = '/TrangChuKhachHang/ThongTinDatPhong';
    }

}




// xem vật tư


function XemVatTu(button) {
    var detailsContainer = $(button).closest('li').find('.details-container');
    var overlay = $(button).closest('li').find('.overlay');

    detailsContainer.show();
    overlay.show();
}

function DongXemVatTu(button) {
    var detailsContainer = $(button).closest('li').find('.details-container');
    var overlay = $(button).closest('li').find('.overlay');

    detailsContainer.hide();
    overlay.hide();
}




//lướt xuống tìm kiếm phòng
document.addEventListener("DOMContentLoaded", function () {
    var scrollLinks = document.querySelectorAll('.smooth-scroll');

    scrollLinks.forEach(function (link) {
        link.addEventListener('click', function (e) {
            e.preventDefault();

            var targetId = this.getAttribute('href').substring(1);
            var targetElement = document.getElementById(targetId);

            if (targetElement) {
                var offset = targetElement.offsetTop;

                window.scrollTo({
                    top: offset,
                    behavior: 'smooth'
                });
            }
        });
    });
});