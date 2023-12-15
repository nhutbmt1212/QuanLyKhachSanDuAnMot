
        var btn_them = document.getElementById('btn_suaPhong');
        btn_them.addEventListener('click', openForm);
        function openForm() {
            document.getElementById("myForm").style.display = "block";
            
        }



        var arrDichVuDaChon = [];
        var counter = -1;

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
                    console.log(result)
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
