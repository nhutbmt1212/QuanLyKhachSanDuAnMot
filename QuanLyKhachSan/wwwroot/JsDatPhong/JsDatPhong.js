function showSearchBar(MaPhong) {
    document.getElementById("popupOverlay").style.display = "flex";
    console.log(MaPhong);
    var maPhong = document.getElementById('MaPhong_PopUp_DatPhong').innerText = MaPhong;
    $.ajax({
        url: '/DatPhong/LayThongTinPhong', 
        type: 'GET',
        data: { maPhong: maPhong },
        success: function (data) {
            console.log(data);
            document.getElementById('MaLoaiPhong_PopUpDatPhong').value = data.tenLoaiPhong;
            document.getElementById('giaPhong_PopUpDatPhong').value = data.giaTheoGio;
            document.getElementById('hinhThuc_PopUpDatPhong').onchange = function () {
                var hinhthuc = document.getElementById('hinhThuc_PopUpDatPhong').value;
                if (hinhthuc == 'Ngay') {
                    document.getElementById('giaPhong_PopUpDatPhong').value = data.giaPhongTheoNgay;

                }
                else {
                    document.getElementById('giaPhong_PopUpDatPhong').value = data.giaTheoGio;

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
            var table = document.querySelector('.table');
            while (table.rows.length > 1) {
                table.deleteRow(1);
            }
            for (var i = 0; i < result.qr_DichVuTheoMaDatPhong.length; i++) {
                var service = result.qr_DichVuTheoMaDatPhong[i];

                // Add a new row
                var row = table.insertRow(-1);

                // Add cells with relevant data
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);
                var cell5 = row.insertCell(4);
                var cell6 = row.insertCell(5);

                // Populate cells with data
                cell1.innerHTML = i + 1; // Row number
                cell2.innerHTML = service.maDichVu; // Service code
                cell3.innerHTML = service.tenDichVu; // Replace with actual service name
                cell4.innerHTML = service.soLuong; // Replace with actual quantity
                cell5.innerHTML = service.giaTien;
                cell6.innerHTML = "Total Amount"; 
                console.log(service)
            }
        },
        error: function (xhr, status, error) {
            // Xử lý lỗi nếu có
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
                        <select class="form-control w-100" id="themdichvuselect${counter}" onchange="DichVuDaChon(${counter})" >
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
    console.log(tongTienPhong, khachTraTruoc);
    // Gửi AJAX request
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
            console.log(result)
        },
        error: function (xhr, status, error) {
        }
    });
}