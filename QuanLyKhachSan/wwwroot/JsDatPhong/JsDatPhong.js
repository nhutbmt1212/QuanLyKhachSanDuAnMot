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
                console.log(hinhthuc);
                if (hinhthuc == 'Ngay') {
                    document.getElementById('giaPhong_PopUpDatPhong').value = data.giaPhongTheoNgay;

                }
                else {
                    document.getElementById('giaPhong_PopUpDatPhong').value = data.giaTheoGio;

                }
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

function openPopupThanhToan() {
    document.getElementById("paymentPopup").style.display = "block";
    document.getElementById("overlayThanhToan").style.display = "block";
}

function closePopupThanhToan() {
    document.getElementById("paymentPopup").style.display = "none";
    document.getElementById("overlayThanhToan").style.display = "none";
}

var arrDichVuDaChon = [];
var counter = -1;
var soLuongdichVu;

document.getElementById('AddThemDichVu').addEventListener('click', ThemDichVu);
function ThemDichVu() {
    counter++;

    var url = '/DatPhong/LayDanhSachDichVu';

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
           
        },
        error: function (error) {
            console.error('Error fetching data:', error);
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
        //document.getElementById(tongTextTenDichVuDaDat).innerText = `Tên dịch vụ: ${dichVuDaChon} | `;
        //tongTextSoLuongDichVuDaDat.innerText = `Số lượng: ${soLuongDichVu}`;
        arrDichVuDaChon[id] = dichVuDaChonTheoId;
    }
}

function XoaSelectDichVu(idSelect) {
    var idTongTheDichVu = 'id_DichVu' + idSelect;
    document.getElementById(idTongTheDichVu).remove();
    arrDichVuDaChon[idSelect] = "";
    document.getElementById('AddThemDichVu').style.display = 'block';
    //xóa text dịch vụ đã chọn
    //var tongTextTenDichVuDaDat = "tongTenDichVuDaDat" + idSelect;
    //var tongTextSoLuongDaDat = "tongSoLuongDichVuDaDat" + idSelect;
    //var breakTongDichVu = "breakDichVu" + idSelect;
    //document.getElementById(tongTextSoLuongDaDat).remove();
    //document.getElementById(tongTextTenDichVuDaDat).remove();
    //document.getElementById(breakTongDichVu).remove();
}

