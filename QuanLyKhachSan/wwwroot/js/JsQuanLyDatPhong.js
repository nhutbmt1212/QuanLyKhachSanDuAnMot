function closeForm() {
    document.getElementById('myForm').style.display = 'none';

}
var arrDichVuDaChon = [];
var counter = -1;

document.getElementById('AddThemDichVu').addEventListener('click', ThemDichVu);

function ThemDichVu() {
    counter++;


    var TongMaDichVu = [];
    $('span[id^="tongTenDichVuDaDat"]').each(function () {
        TongMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
    });
    var url = '/TrangChuKhachHang/LayDanhSachDichVu';
    $.ajax({
        url: url,
        type: 'GET',
        success: function (data) {
            var options = '';
            $.each(data, function (index, itemDichVu) {
                if (!arrDichVuDaChon.includes(itemDichVu.maDichVu) && !TongMaDichVu.includes(itemDichVu.maDichVu)) {
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

            if (data.length == arrDichVuDaChon.length) {
                document.getElementById('AddThemDichVu').style.display = 'none';
            }
            //cộng 1 là khi thêm mới 1 dịch vụ. Tự động cộng và truyền tham số.
            var dem = TongMaDichVu.length + 1;
            console.log(dem);
            DemSlDichVu(dem);
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
            TinhTongTienPhong();
        },
        error: function (xhr, status, error) {
            console.error('Error calculating service charges:', error);
        }
    });
}

function DichVuDaChon(id) {
    var dichVuDaChonTheoId = document.getElementById('themdichvuselect' + id).value;

    if (arrDichVuDaChon[id] == "") {
        console.log("Mảng rỗng");
    } else {
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

function HienThiThongTinDatPhong(MaDatPhong) {
    arrDichVuDaChon = [];
    document.getElementById("myForm").style.display = "block";
    $.ajax({
        type: "POST",
        url: '/QuanLyDatPhong/LayThongTinDatPhong',
        data: { 'MaDatPhong': MaDatPhong },
        success: function (result) {
            $('#TongTienDichVuDaDat').text(0);
            $('#inputFieldMaDatPhong').val(result.qr_DatPhong.maDatPhong);
            $('#inputFieldMaPhong').val(result.qr_DatPhong.maPhong);
            $('#inputFieldMaKhachHang').val(result.qr_DatPhong.maKhachHang);
            $('#inputFieldNgayNhan').val(result.qr_DatPhong.ngayNhan);
            $('#inputFieldNgayTra').val(result.qr_DatPhong.ngayTra);
            $('#inputFieldSoLuongNguoiLon').val(result.qr_DatPhong.soLuongNguoiLon);
            $('#inputFieldSoLuongTreEm').val(result.qr_DatPhong.soLuongTreEm);
            $('#inputFieldHinhThucDatPhong').val(result.qr_DatPhong.hinhThucDatPhong);
            $('#inputFieldTongTienPhong').val(result.qr_DatPhong.tongTienPhong);
            $('#inputFieldMaNhanVien').val(result.qr_DatPhong.maNhanVien);
            $('#inputFieldKhachTraTruoc').val(result.qr_DatPhong.soTienTraTruoc);
            $('#inputFieldTinhTrang').val(result.qr_DatPhong.tinhTrang);


            TinhTongTienPhong();
            XemChiTietDichVu(MaDatPhong);

        },
        error: function () {

        }
    });
}
function XemChiTietDichVu(MaDatPhong) {
    $.ajax({
        type: 'POST',
        url: '/QuanLyDatPhong/LayThongTinDichVu',
        data: { 'MaDatPhong': MaDatPhong },
        success: function (result) {
            $('#ChonDichVu').empty();
            $('#TongDichVuDaDat').empty();
            document.getElementById('AddThemDichVu').style.display = 'block';

            if (result.qr_DichVuChiTiet != "") {



                var dem = [];
                $.each(result.qr_DichVuChiTiet, function (index, item) {
                    dem.push(1);
                    // Call ThemDichVuEdit with the parameters
                    ThemDichVuEdit(item.maDichVu, item.soLuong);
                    DemSlDichVu(dem.length);
                });
            }

        },
        error: function () {
        }
    });
}

var arrDichVuDaChonedit = [];
var counteredit = 999; // Assuming this is defined somewhere in your code

function ThemDichVuEdit(maDichVu, soLuong) {
    var arrDichVuDaChonedit = [];
    var countedit = ++counteredit;

    var url = '/TrangChuKhachHang/LayDanhSachDichVu';

    $.ajax({
        url: url,
        type: 'GET',
        success: function (data) {


            var options = '';
            var TongMaDichVu = [];
            $('span[id^="tongTenDichVuDaDat"]').each(function () {
                TongMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
            });

            $.each(data, function (index, itemDichVu) {
                if (!TongMaDichVu.includes(itemDichVu.maDichVu)) {
                    var isSelected = arrDichVuDaChonedit.includes(itemDichVu.maDichVu);
                    options += `<option value="${itemDichVu.maDichVu}" class="optionChonDichVu" ${isSelected ? 'selected' : ''}>${itemDichVu.tenDichVu} - ${itemDichVu.giaTien}/ ${itemDichVu.donViTinh}</option>`;
                }
            });


            var node = `
                <div class="row" id="id_DichVu${countedit}">
                    <div class="col-lg-7" style="margin-bottom:5px;">
                        <select class="form-control w-100" id="themdichvuselect${countedit}" onchange="DichVuDaChon(${countedit})">
                            ${options}
                        </select>
                    </div>
                    <div class="col-lg-3">
                        <input type="number" class="form-control w-100" id="soLuongDichVu${countedit}" onchange="ThayDoiSoLuongDichVu(${countedit})" min="1" value="${soLuong}">
                    </div>
                    <div class="col-2">
                        <button id="XoaSelectDichVu${countedit}" class="btn btn-outline-danger" onclick="XoaSelectDichVu(${countedit})">
                            <i class="bi bi-trash3"></i>
                        </button>
                    </div>
                </div>
            `;

            $('#ChonDichVu').append(node);

            var dichVuSelect = $('#themdichvuselect' + countedit);
            dichVuSelect.val(maDichVu);

            arrDichVuDaChonedit.push(maDichVu);


            dichVuSelect.focus(function () {
                var TongMaDichVu = [];
                $('span[id^="tongTenDichVuDaDat"]').each(function () {
                    TongMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
                });

                $(this).find('.optionChonDichVu').each(function () {
                    if (TongMaDichVu.includes($(this).val())) {
                        $(this).hide();
                    } else {
                        $(this).show();
                    }
                });
            });

            if (arrDichVuDaChonedit.length == data.length) {
                $('#AddThemDichVu').hide();
            }
            var nodeServices = `<br id="breakDichVu${countedit}"/><span id="tongTenDichVuDaDat${countedit}">Tên dịch vụ: ${maDichVu} | </span><span id="tongSoLuongDichVuDaDat${countedit}">Số lượng: ${soLuong}</span>`;
            $('#TongDichVuDaDat').append(nodeServices);
            TinhTienDichVu();
        },
        error: function (error) {
            console.error('Error fetching data:', error);
        }
    });


}

function DemSlDichVu(dem) {


    $.ajax({
        type: "POST",
        url: '/QuanLyDatPhong/TongDichVu',
        success: function (result) {
            if (result == dem) {
                document.getElementById('AddThemDichVu').style.display = 'none';

            }
            else {
                document.getElementById('AddThemDichVu').style.display = 'block';

            }

        },
        error: function () {
            console.log('error');
        }
    });
}
function SuaDatPhong() {
    var TongMaDichVu = [];
    $('span[id^="tongTenDichVuDaDat"]').each(function () {
        TongMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
    });
    console.log(TongMaDichVu);
}

$(document).ready(function () {
    // Attach the change event to the input fields
    $('#inputFieldNgayNhan, #inputFieldNgayTra, #inputFieldHinhThucDatPhong').change(function () {
        TinhTongTienPhong(); // Call the function when any of the input fields change
    });
});

function TinhTongTienPhong() {
    console.log(1);
    var MaPhong = document.getElementById('inputFieldMaPhong').value;
    var hinhThuc = document.getElementById('inputFieldHinhThucDatPhong').value;
    var ngayNhanPhong = new Date(document.getElementById('inputFieldNgayNhan').value);
    var ngayTraPhong = new Date(document.getElementById('inputFieldNgayTra').value);
    var duration = 0;
    if (hinhThuc === 'Ngay') {
        duration = (ngayTraPhong - ngayNhanPhong) / (1000 * 60 * 60 * 24);
    } else {
        duration = (ngayTraPhong - ngayNhanPhong) / (1000 * 60 * 60);
    }
    $.ajax({
        type: 'POST',
        url: '/QuanLyDatPhong/TinhTienPhong',
        data: {
            'MaPhong': MaPhong
        },
        success: function (result1) {
            var giaPhong;
            if (hinhThuc === 'Ngày') {
                giaPhong = result1.qr_LoaiPhong.giaPhongTheoNgay;
            }
            else {
                giaPhong = result1.qr_LoaiPhong.giaTheoGio;

            }
            var totalAmount = giaPhong * duration;

            document.getElementById('TongTienPhong').innerText = totalAmount.toFixed(2);

            var TongTienDichVuElement = document.getElementById('TongTienDichVuDaDat');
            var TongTienDichVu = parseFloat(TongTienDichVuElement.innerText);

            var tongTienElement = document.getElementById('TongTien');

            var sum = totalAmount + TongTienDichVu;

            tongTienElement.innerText = sum.toFixed(2);
        },
        error: function () {
            console.log('error');
        }
    });
}

function SuaDatPhong() {

    var ThanhTienMaDichVu = [];
    var arrSoLuongDichVu = [];

    $('span[id^="tongTenDichVuDaDat"]').each(function () {
        ThanhTienMaDichVu.push($(this).text().split(": ")[1].split(" | ")[0]);
    });

    $('span[id^="tongSoLuongDichVuDaDat"]').each(function () {
        arrSoLuongDichVu.push($(this).text().split(": ")[1]);
    });

    var maDatPhongValue = $('#inputFieldMaDatPhong').val();
    var maPhongValue = $('#inputFieldMaPhong').val();
    var maKhachHangValue = $('#inputFieldMaKhachHang').val();
    var ngayNhanValue = $('#inputFieldNgayNhan').val();
    var ngayTraValue = $('#inputFieldNgayTra').val();
    var soLuongNguoiLonValue = $('#inputFieldSoLuongNguoiLon').val();
    var soLuongTreEmValue = $('#inputFieldSoLuongTreEm').val();
    var hinhThucDatPhongValue = $('#inputFieldHinhThucDatPhong').val();
    var maNhanVienValue = $('#inputFieldMaNhanVien').val();
    var khachTraTruocValue = $('#inputFieldKhachTraTruoc').val();
    var tongtienPhongValue = $('#TongTienPhong').text();
    var tinhTrangValue = $('#inputFieldTinhTrang').val();
    validateNgayTra().then(function (result) {
        if (!result) {
            console.log("Validation failed");
            return;
        }
        else {
            $.ajax({
                type: 'POST',
                url: '/QuanLyDatPhong/suaDatPhong',
                data: {
                    'ThanhTienMaDichVu': ThanhTienMaDichVu,
                    'arrSoLuongDichVu': arrSoLuongDichVu,
                    'maDatPhongValue': maDatPhongValue,
                    'maPhongValue': maPhongValue,
                    'maKhachHangValue': maKhachHangValue,
                    'ngayNhanValue': ngayNhanValue,
                    'ngayTraValue': ngayTraValue,
                    'soLuongNguoiLonValue': soLuongNguoiLonValue,
                    'soLuongTreEmValue': soLuongTreEmValue,
                    'hinhThucDatPhongValue': hinhThucDatPhongValue,
                    'maNhanVienValue': maNhanVienValue,
                    'khachTraTruocValue': parseInt(khachTraTruocValue),
                    'tongtienPhongValue': parseInt(tongtienPhongValue),
                    'tinhTrangValue': tinhTrangValue

                },
                success: function (response) {
                    // Xử lý khi yêu cầu thành công

                },
                error: function (error) {
                    // Xử lý khi có lỗi xảy ra
                    console.log(error);
                }
            });
        }
    }).catch(function (error) {
        console.log("Validation failed");
    });
 }
    



function XoaDatPhong(MaDatPhong) {
    $.ajax({
        type: "POST",
        url: '/QuanLyDatPhong/HuyDatPhong',
        data: { 'MaDatPhong': MaDatPhong },
        success: function () {

        },
        error: function () {
            console.log('lỗi');
        }

    });
}
function validateNgayTra() {
    return new Promise((resolve, reject) => {
        var today = new Date();
        var maDatPhong = document.getElementById('inputFieldMaDatPhong');
        var ngayNhan = document.getElementById('inputFieldNgayNhan').value;
        var ngayTra = document.getElementById('inputFieldNgayTra').value;
        var maPhong = $('#inputFieldMaPhong').text();
        var chenhlechthoigian = ngayTra - ngayNhan;
        var chenhlechgio = chenhlechthoigian / (1000 * 60 * 60);
        if (ngayNhan < today) {
            document.getElementById('errorNgayNhan').textContent = 'Ngày nhận phải lớn hơn hoặc bằng giờ hiện tại';
            reject(false);
        }
        else if (chenhlechgio <= 3) {
            document.getElementById('errorNgayTra').textContent = "Thời gian đặt phòng phải lớn hơn 3 giờ";
            reject(false);
        }
        else {
            $.ajax({
                type: 'POST',
                url: '/QuanLyDatPhong/KiemTraNgayNhanVaTra',
                data: {
                    'NgayNhan': ngayNhan,
                    'NgayTra': ngayTra,
                    'MaPhong': maPhong,
                    'MaDatPhong': maDatPhong
                },
                success: function (result) {
                    if (result != null) {
                        document.getElementById('errorNgayNhan').textContent = result;
                        document.getElementById('errorNgayTra').textContent = result;
                        reject(false);
                    }
                    else {
                        document.getElementById('errorNgayNhan').textContent = "";
                        document.getElementById('errorNgayTra').textContent = "";
                        resolve(true);
                    }
                },
                error: function () {
                    console.log('lỗi');
                    reject(false);
                }
            });
        }
    });
}
