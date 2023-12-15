

   



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
                    // TongTienDatPhong();
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
    document.getElementById("myForm").style.display = "block";
    $.ajax({
        type: "POST",
        url: '/QuanLyDatPhong/LayThongTinDatPhong',
        data: { 'MaDatPhong': MaDatPhong },
        success: function (result) {
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
                    DemSlDichVu(dem);
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

            $.each(data, function (index, itemDichVu) {
                var isSelected = arrDichVuDaChonedit.includes(itemDichVu.maDichVu);
                options += `<option value="${itemDichVu.maDichVu}" class="optionChonDichVu" ${isSelected ? 'selected' : ''}>${itemDichVu.tenDichVu} - ${itemDichVu.giaTien}/ ${itemDichVu.donViTinh}</option>`;
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
                $(this).find('.optionChonDichVu').each(function () {
                    if (arrDichVuDaChonedit.includes($(this).val())) {
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

            //if (data.length == arrDichVuDaChonedit.length) {
            //    document.getElementById('AddThemDichVu').style.display = 'none';
            //}

         
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
            console.log(result, dem.length);
            if (result == dem.length) {
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