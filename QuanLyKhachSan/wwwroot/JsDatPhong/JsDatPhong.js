document.addEventListener('DOMContentLoaded', function () {
    const optionsContainers = document.querySelectorAll('.options-container');

    optionsContainers.forEach(container => {
        const optionsBtn = container.querySelector('.options-btn');
        const optionsMenu = container.querySelector('.options-menu');

        optionsBtn.addEventListener('click', function (event) {
            event.stopPropagation();

            optionsContainers.forEach(otherContainer => {
                if (otherContainer !== container) {
                    otherContainer.querySelector('.options-menu').style.display = 'none';
                }
            });

            optionsMenu.style.display = optionsMenu.style.display === 'block' ? 'none' : 'block';
        });

        document.addEventListener('click', function () {
            optionsMenu.style.display = 'none';
        });
    });
});

function showSearchBar(MaPhong) {
    document.getElementById("popupOverlay").style.display = "flex";
    var maPhong = document.getElementById('MaPhong_PopUp_DatPhong').innerText = MaPhong;
    $.ajax({
        url: '/DatPhong/LayThongTinPhong', 
        type: 'GET',
        data: { maPhong: maPhong },
        success: function (data) {
            console.log(data);
            document.getElementById('MaLoaiPhong_PopUpDatPhong').value = data.qr_LoaiPhong.tenLoaiPhong;
            document.getElementById('giaPhong_PopUpDatPhong').value = data.qr_LoaiPhong.giaTheoGio;
            document.getElementById('SoNgLonToiDaPopUp_DatPhong').innerText = data.qr_LoaiPhong.soLuongNguoiLon;
            document.getElementById('SoTreEmToiDaPopUp_DatPhong').innerText = data.qr_LoaiPhong.soLuongTreEm;

            document.getElementById('hinhThuc_PopUpDatPhong').onchange = function () {
                var hinhthuc = document.getElementById('hinhThuc_PopUpDatPhong').value;
                if (hinhthuc == 'Ngay') {
                    document.getElementById('giaPhong_PopUpDatPhong').value = data.qr_LoaiPhong.giaPhongTheoNgay;
                }
                else {
                    document.getElementById('giaPhong_PopUpDatPhong').value = data.qr_LoaiPhong.giaTheoGio;

                }
                TinhTongTienPhong();
             
            }

        },
        error: function (error) {
            console.error(error);
        }
    });
    document.getElementById('ngayNhanPhong_PopUpDatPhong').min = new Date().toISOString().slice(0, 16);
    document.getElementById('ngayTraPhong_PopUpDatPhong').min = new Date().toISOString().slice(0, 16);

    document.getElementById('ngayNhanPhong_PopUpDatPhong').value = new Date().toISOString().slice(0, 16);
    document.getElementById('ngayTraPhong_PopUpDatPhong').value = new Date().toISOString().slice(0, 16);


}

function showForm() {
    var formPopup = document.getElementById("formPopup");
    formPopup.style.display = "block";

    var closeButton = document.createElement("i");
    closeButton.className = "fa fa-times close-icon";
    closeButton.onclick = function () {
        formPopup.style.display = "none";
    };

    formPopup.appendChild(closeButton);
}

function closeForm() {
    document.getElementById("formPopup").style.display = "none";
}

function closePopup() {
    document.getElementById("popupOverlay").style.display = "none";
}

function openPopupThanhToan(maPhong) {
    document.getElementById("paymentPopup").style.display = "block";
    document.getElementById("overlayThanhToan").style.display = "block";
    document.getElementById('MaPhong_ThanhToan').innerHTML = maPhong;

    // Gọi AJAX với tham số mã phòng
    $.ajax({
        url: "/DatPhong/LayThanhToanMaDatPhong",
        data: { maPhong: maPhong }, // Truyền tham số mã phòng vào request
        type: "GET", // Hoặc "POST" tùy thuộc vào cấu hình của server
        success: function (result) {
            console.log(result);
            document.getElementById('maDatPhongThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.maDatPhong;
            document.getElementById('soLuongNguoiLonThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.soLuongNguoiLon;
            document.getElementById('soLuongTreEmThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.soLuongTreEm;
            document.getElementById('thoiGianNhanThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.ngayNhan;
            document.getElementById('thoiGianTraThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.ngayTra;
            document.getElementById('tenKhachHangThanhToan_PopUp').innerHTML = result.qr_MaKhachHangTheoMaDatPhong.tenKhachHang;
            document.getElementById('soDienThoaiThanhToan_PopUp').innerHTML = result.qr_MaKhachHangTheoMaDatPhong.soDienThoai;
            document.getElementById('tongTienThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.tongTienPhong;
            document.getElementById('giaTheoGioThanhToan_PopUp').innerHTML = result.qr_LoaiPhongTheoMaPhong.giaTheoGio;
            document.getElementById('giaTheoNgayThanhToan_PopUp').innerHTML = result.qr_LoaiPhongTheoMaPhong.giaPhongTheoNgay;
            document.getElementById('loaiPhongThanhToan_PopUp').innerHTML = result.qr_LoaiPhongTheoMaPhong.tenLoaiPhong;
            document.getElementById('hinhThucDatPhongThanhToan_PopUp').innerHTML = result.qr_MaDatPhongTheoNgayGioHienTai.hinhThucDatPhong;
            var table = document.querySelector('.table');
            var hinhThuc = result.qr_MaDatPhongTheoNgayGioHienTai.hinhThucDatPhong;
            var ngayNhanPhong = new Date(result.qr_MaDatPhongTheoNgayGioHienTai.ngayNhan);
            var ngayTraPhong = new Date(result.qr_MaDatPhongTheoNgayGioHienTai.ngayTra);
            var duration = 0;
            var giaPhong = 0;
            if (hinhThuc === 'Ngay') {
                duration = (ngayTraPhong - ngayNhanPhong) / (1000 * 60 * 60 * 24);
                giaPhong = result.qr_LoaiPhongTheoMaPhong.giaPhongTheoNgay;
            } else {
                duration = (ngayTraPhong - ngayNhanPhong) / (1000 * 60 * 60);
                giaPhong = result.qr_LoaiPhongTheoMaPhong.giaTheoGio;
            }
            var tongTienPhong = giaPhong * duration;
            document.getElementById('tongTienPhongThanhToan_PopUp').innerText = tongTienPhong;
          
            while (table.rows.length > 1) {
                table.deleteRow(1);
            }
            var tongTienDichVu = 0;
            for (var i = 0; i < result.qr_DichVuTheoMaDatPhong.length; i++) {
                var service = result.qr_DichVuTheoMaDatPhong[i];
                var row = table.insertRow(-1);
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                var cell5 = row.insertCell(4);
                var cell6 = row.insertCell(5);
                cell1.innerHTML = i + 1; 
                cell2.innerHTML = service.maDichVu; 
                cell3.innerHTML = service.tenDichVu; 
                cell4.innerHTML = service.soLuong;
                cell5.innerHTML = service.giaTien; 
                cell6.innerHTML = service.thanhTien; 
                tongTienDichVu += service.thanhTien;
            }
          
            document.getElementById('tongTienDichVu_PopUp').innerText = tongTienDichVu;
            var soTienKhachDaTra = result.qr_MaDatPhongTheoNgayGioHienTai.soTienTraTruoc;
            document.getElementById('soTienKhachDaTra_PopUp').innerText = soTienKhachDaTra;
            var TongTienDatPhong = (parseFloat(tongTienDichVu) + parseFloat(tongTienPhong)) - parseFloat(soTienKhachDaTra);
            document.getElementById('tongTienThanhToan_PopUp').innerText = TongTienDatPhong;
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });
}
function closePopupThanhToan() {
    document.getElementById("paymentPopup").style.display = "none";
    document.getElementById("overlayThanhToan").style.display = "none";
}
var arrDichVuDaChon=[];
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
                        <select class="form-control w-100" id="themdichvuselect${counter}" onchange="DichVuDaChon(${counter})">
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
                $(this).find('.optionChonDichVu').each(function () {
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
            TongTienDatPhong();
            
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
    var tongTextTenDichVuDaDat = "tongTenDichVuDaDat" + idSelect;
    var tongTextSoLuongDaDat = "tongSoLuongDichVuDaDat" + idSelect;
    var breakTongDichVu = "breakDichVu" + idSelect;
    document.getElementById(tongTextSoLuongDaDat).remove();
    document.getElementById(tongTextTenDichVuDaDat).remove();
    document.getElementById(breakTongDichVu).remove();
    TinhTienDichVu();
}
document.addEventListener("DOMContentLoaded", function () {
    document.getElementById('hinhThuc_PopUpDatPhong').addEventListener('change', updateTotal);
    document.getElementById('ngayNhanPhong_PopUpDatPhong').addEventListener('change', updateTotal);
    document.getElementById('ngayTraPhong_PopUpDatPhong').addEventListener('change', updateTotal);
    function updateTotal() {
        TinhTongTienPhong();
        
    }

});
function TinhTongTienPhong() {
    var hinhThuc = document.getElementById('hinhThuc_PopUpDatPhong').value;
    var ngayNhanPhong = new Date(document.getElementById('ngayNhanPhong_PopUpDatPhong').value);
    var ngayTraPhong = new Date(document.getElementById('ngayTraPhong_PopUpDatPhong').value);
    var duration = 0;
    if (hinhThuc === 'Ngay') {
        duration = (ngayTraPhong - ngayNhanPhong) / (1000 * 60 * 60 * 24);
    } else {
        duration = (ngayTraPhong - ngayNhanPhong) / (1000 * 60 * 60);
    }
    var giaPhong = parseFloat(document.getElementById('giaPhong_PopUpDatPhong').value);
    var totalAmount = giaPhong * duration;
    document.getElementById('TongTienPhong').innerHTML = totalAmount.toFixed(2);
    TongTienDatPhong();
}
function TongTienDatPhong() {
    var tongTienPhong = parseFloat(document.getElementById('TongTienPhong').innerHTML);
    var tongTienDichVu = parseFloat(document.getElementById('TongTienDichVuDaDat').innerHTML);
    var TongTienDatPhong = tongTienPhong + tongTienDichVu;
    document.getElementById('TongTien').innerHTML = TongTienDatPhong;
}

document.getElementById('NhanPhong_PopUp').addEventListener('click', DatPhong);
function DatPhong() {
    if (!validateMaKhachHang() || !validateNgayNhan() || !validateNgayTra() || !validateTongNguoiLon() || !validateTongTreEm() || !validateKhachTraTruoc() || !checkErrors() ) {
        console.log("Other validations failed");
        return;
    } else {
        console.log("Validation passed! Submitting data...");

    var ThanhTienMaDichVu = [];
    var arrSoLuongDichVu = [];
    $('span[id^="tongTenDichVuDaDat"]').each(function () {
        ThanhTienMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
    });
    $('span[id^="tongSoLuongDichVuDaDat"]').each(function () {
        arrSoLuongDichVu.push($(this).text().split(": ")[1]);
    });
    var maKhachHangDatPhong = document.getElementById('MaKhachHangDatPhong').value;
    var maKhachHang = maKhachHangDatPhong.split('|')[0].trim();
    var hinhThuc = document.getElementById('hinhThuc_PopUpDatPhong').value;
    var ngayNhan = document.getElementById('ngayNhanPhong_PopUpDatPhong').value;
    var ngayTra = document.getElementById('ngayTraPhong_PopUpDatPhong').value;
    var tongNguoiLon = document.getElementById('tongNguoiLon').value;
    var tongTreEm = document.getElementById('tongTreEm').value;
    var tongTienPhong = document.getElementById('TongTien').innerText;
    var khachTraTruoc = document.getElementById('khachTraTruoc').value;
    var maPhong = document.getElementById('MaPhong_PopUp_DatPhong').innerText;
    $.ajax({
        url: '/DatPhong/DatPhongNhanh',
        type: 'POST',
        data: {
            'arrMaDichVu': ThanhTienMaDichVu,
            'arrSoLuongDichVu': arrSoLuongDichVu,
            'maKhachHang': maKhachHang,
            'hinhThuc': hinhThuc,
            'ngayNhan': ngayNhan,
            'ngayTra': ngayTra,
            'tongNguoiLon': tongNguoiLon,
            'tongTreEm': tongTreEm,
            'tongCong': tongTienPhong,
            'soTienTraTruoc': khachTraTruoc,
            'maPhong': maPhong
        },
        traditional: true,
        success: function (result) {
            window.location.href = '/DatPhong/Index';
        },
        error: function (xhr, status, error) {
        }
    });
    }
}
function ThanhToan() {
    var maDatPhong = document.getElementById('maDatPhongThanhToan_PopUp').innerText;
    var tongTienDichVu = document.getElementById('tongTienPhongThanhToan_PopUp').innerText;
    var tongTienPhong = document.getElementById('tongTienDichVu_PopUp').innerText;
    var soTienThanhToan = document.getElementById('tongTienThanhToan_PopUp').innerText;
    $.ajax({
        url: '/DatPhong/ThanhToanPhong',
        type: 'GET',
        data: {
            'MaDatPhong': maDatPhong,
            'TongTienDichVu': tongTienDichVu,
            'TongTienPhong': tongTienPhong,
            'SoTienThanhToan': soTienThanhToan
        },
        traditional: true,
        success: function (result) {
            window.location.href = '/DatPhong/Index';
        },
        error: function (xhr, status, error) {
        }
    });
}

function TimKiemTatCa() {
    document.getElementById('TimKiemTatCa').classList = "btn btn-light active";
    document.getElementById('TimKiemTrong').classList = "btn btn-light ";
    document.getElementById('TimKiemDaDat').classList = "btn btn-light ";
}
function TimKiemTrong() {
    document.getElementById('TimKiemTatCa').classList = "btn btn-light ";
    document.getElementById('TimKiemTrong').classList = "btn btn-light active";
    document.getElementById('TimKiemDaDat').classList = "btn btn-light ";
} function TimKiemDaDat() {
    document.getElementById('TimKiemTatCa').classList = "btn btn-light ";
    document.getElementById('TimKiemTrong').classList = "btn btn-light ";
    document.getElementById('TimKiemDaDat').classList = "btn btn-light active";
}
//kiểm lỗi 
function validateMaKhachHang() {
    var maKhachHangDatPhong = document.getElementById('MaKhachHangDatPhong').value;
    var maKhachHang = maKhachHangDatPhong.split('|')[0].trim();
    if (maKhachHang == "") {
        document.getElementById('errorKhachHang').textContent = 'Bạn chưa chọn khách hàng';
        return false;
    } else {
        document.getElementById('errorKhachHang').textContent = '';
        return true;
    }
}

function validateNgayNhan() {
    var ngayNhan = new Date(document.getElementById('ngayNhanPhong_PopUpDatPhong').value);
    var now = new Date();
    if (ngayNhan < now) {
        document.getElementById('errorNgayNhan').textContent = 'Ngày nhận phải lớn hơn hoặc bằng giờ hiện tại';
        return false;
    } else {
        document.getElementById('errorNgayNhan').textContent = '';
        return true;
    }
}

function validateNgayTra() {
    var ngayNhan = new Date(document.getElementById('ngayNhanPhong_PopUpDatPhong').value);
    var ngayTra = new Date(document.getElementById('ngayTraPhong_PopUpDatPhong').value);
    var chenhlechthoigian = ngayTra - ngayNhan;
    var chenhlechgio = chenhlechthoigian / (1000 * 60 * 60);
    if (chenhlechgio <= 3) {
        document.getElementById('errorNgayTra').textContent = "Thời gian đặt phòng phải lớn hơn 3 giờ";
        return false;
    } else {
        document.getElementById('errorNgayTra').textContent = '';
        return true;
    }
}
function validateTongNguoiLon() {
    var tongNguoiLon = document.getElementById('tongNguoiLon').value;
    var soLuongNguoiLonToiDa = document.getElementById('SoNgLonToiDaPopUp_DatPhong').innerText;
    var regex = /^[0-9]*$/; // Regex for numbers only
    if (tongNguoiLon == "") {
        document.getElementById('errorTongSoNguoiLon').textContent = '';
        document.getElementById('errorTongSoNguoiLon').textContent = 'Tổng số người lớn không được bỏ trống';
        return false;
    } else if (!regex.test(tongNguoiLon)) {
        document.getElementById('errorTongSoNguoiLon').textContent = '';
        document.getElementById('errorTongSoNguoiLon').textContent = 'Tổng số người lớn phải là số';
        return false;
    } else if (tongNguoiLon > soLuongNguoiLonToiDa) {
        document.getElementById('errorTongSoNguoiLon').textContent = '';
        document.getElementById('errorTongSoNguoiLon').textContent = 'Số lượng người lớn trong phòng đã vượt mức tối đa';
        return false;
    } else {
        document.getElementById('errorTongSoNguoiLon').textContent = '';
        return true;
    }
}

function validateTongTreEm() {
    var tongTreEm = document.getElementById('tongTreEm').value;
    var soLuongTreEmToiDa = document.getElementById('SoTreEmToiDaPopUp_DatPhong').innerText;
    var regex = /^[0-9]*$/; // Regex for numbers only
    if (tongTreEm == "") {
       document.getElementById('errorTongSoTreEm').textContent = '';

        document.getElementById('errorTongSoTreEm').textContent = 'Tổng số trẻ em không được bỏ trống';
        return false;
    } else if (!regex.test(tongTreEm)) {
        document.getElementById('errorTongSoTreEm').textContent = '';

        document.getElementById('errorTongSoTreEm').textContent = 'Tổng số trẻ em phải là số';
        return false;
    } else if (tongTreEm > soLuongTreEmToiDa) {
        document.getElementById('errorTongSoTreEm').textContent = '';

        document.getElementById('errorTongSoTreEm').textContent = 'Số lượng trẻ em trong phòng đã vượt mức tối đa';
        return false;
    } else {
        document.getElementById('errorTongSoTreEm').textContent = '';
        return true;
    }
}



function validateKhachTraTruoc() {
    var khachTraTruoc = document.getElementById('khachTraTruoc').value;
    var regex = /^[0-9]*$/; // Regex for numbers only
    if (khachTraTruoc == "" || !regex.test(khachTraTruoc)) {
        document.getElementById('errorKhachTraTruoc').textContent = 'Khách trả trước không được để trống và phải là số';
        return false;
    } else {
        document.getElementById('errorKhachTraTruoc').textContent = '';
        return true;
    }
}
async function checkErrors() {
    let ngayNhan = document.getElementById('ngayNhanPhong_PopUpDatPhong').value;
    let ngayTra = document.getElementById('ngayTraPhong_PopUpDatPhong').value;
    let maPhong = document.getElementById('MaPhong_PopUp_DatPhong').textContent;

    console.log(ngayNhan, ngayTra, maPhong);

    $.ajax({
        url: '/DatPhong/CheckNgayDatPhong',
        type: 'POST',
       
        data: {
            ngayNhanMoi: ngayNhan,
            ngayTraMoi: ngayTra,
            maPhongMoi: maPhong
        },
        success: function (datPhongTrung) {
            console.log(datPhongTrung);
            if (!datPhongTrung) {
                alert("Có");
                return false; // Có người đã đặt phòng
            } else {
                alert("Không");
                return true; // Không có ai đặt phòng
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error('HTTP error', textStatus);
            return false;
        }
    });


}








