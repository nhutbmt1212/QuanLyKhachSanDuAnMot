window.onload = function () {
    // Lấy thông tin từ sessionStorage
    document.getElementById('ngaynhan_text').innerText = sessionStorage.getItem('ngayNhanPhong');
    document.getElementById('ngaytra_text').innerText = sessionStorage.getItem('ngayTraPhong');
    document.getElementById('ngay_text').innerText = sessionStorage.getItem('ngayNhanPhongDaTinh');
    document.getElementById('gio_text').innerText = sessionStorage.getItem('gioTraPhongDaTinh');

    //document.getElementById('SoLuongNguoiLonDat_text').innerText = sessionStorage.getItem('slNguoiLonTimKiem');
    //document.getElementById('SoLuongTreEmDat_text').innerText = sessionStorage.getItem('slTreEmTimKiem');
    document.getElementById('maPhong_DatPhong').innerText = sessionStorage.getItem('maPhong');
    document.getElementById('giaTriSoLuongNguoiLonDat').innerText = sessionStorage.getItem('slNguoiLon');
    document.getElementById('giaTriSoLuongTreEmDat').innerText = sessionStorage.getItem('slTreEm');
    document.getElementById('TongTienPhong').innerText = sessionStorage.getItem('tongTienPhong');
    document.getElementById('TongTienDichVuDaDat').innerText = sessionStorage.getItem('tongTienDichVu');
    document.getElementById('TongTien').innerText = parseFloat(document.getElementById('TongTienPhong').innerText) + parseFloat(document.getElementById('TongTienDichVuDaDat').innerText)

    var maPhong = sessionStorage.getItem('maPhong');
    $.ajax({
        type: "GET",
        url: `/TrangChuKhachHang/LayThongTinPhongTheoMaPhong?maPhong=${maPhong}`,
        success: function (result) {
            document.getElementById('loaiPhongDatPhong').innerText = result.qr_LoaiPhong.tenLoaiPhong;
            document.getElementById('giaTheoGioDatPhong').innerText = result.qr_LoaiPhong.giaTheoGio;
            document.getElementById('giaTheoNgayDatPhong').innerText = result.qr_LoaiPhong.giaPhongTheoNgay;
        },
        error: function (error) {
            console.log(error)
        }
    });

    var maDichVu = JSON.parse(sessionStorage.getItem('arrMaDichVu').split(','));
    var soLuongDichVu = JSON.parse(sessionStorage.getItem('arrSoLuongDichVu').split(','));
    
    maDichVu.forEach(ShowDichVu);

    function ShowDichVu(item, index) {
        $.ajax({
            type: "GET",
            url: `/TrangChuKhachHang/LayThongTinDichVu?MaDichVu=${item}`,
            success: function (result) {
                var quantity = soLuongDichVu[index];
                var newDiv = document.createElement('span');
                newDiv.innerHTML = `<strong>Tên:</strong> ` + result.tenDichVu + ` - <strong>Giá:</strong> ` + result.giaTien + ` - <strong>SL:</strong> ` + quantity + `<br/>`;
                document.getElementById('ChonDichVu').appendChild(newDiv);
            },
            error: function (error) {
                console.log(error)
            }
        });
    }
}

function validateName() {
    var tenkh = $('#inputFieldTenKH').val();
    // Regex for alphabets (including Vietnamese), spaces only
    var regexName = /^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểẾỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừễỄễỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸýỳỷỹỵ\s]*$/;

    if (tenkh == "") {
        $('#errorTenKH').text('');
        $('#errorTenKH').text('Tên khách hàng không được bỏ trống');
        return false;
    }

    // Convert the name to uppercase before testing it against the regex
    if (!regexName.test(tenkh.toUpperCase())) {
        $('#errorTenKH').text('');
        $('#errorTenKH').text('Tên khách hàng không được chứa số hoặc kí tự đặc biệt');
        return false;
    } else {
        $('#errorTenKH').text('');
        return true;
    }
}


function validatePhoneNumber() {
    var sdt = $('#inputFieldSDT').val();
    var regexPhone = /^[0-9]{10}$/; // Regex for 10 digits
    if (sdt == "") {
        $('#errorSDT').text('Số điện thoại không được bỏ trống');
        return false;
    }
    if (!regexPhone.test(sdt)) {
        $('#errorSDT').text('Số điện thoại phải có đúng 10 chữ số');
        return false;
    }
    if (sdt.charAt(0) != '0') {
        $('#errorSDT').text('Số điện thoại phải bắt đầu bằng số 0');
        return false;
    } else {
       
        $("#errorSDT").text("");
        return true;
    }
}


function checkPhoneNumber(sdt) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/KhachHang/CheckSoDienThoai',
            data: { sodienthoai: sdt },
            type: 'GET',
            success: function (response) {
                resolve(!response.exists);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}


function validateEmail() {
    var email = $('#inputFieldEmail').val();
    var regexEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/; // Regex for a basic email format
    if (email == "") {
        $('#errorEmail').text('Email không được bỏ trống');
        return false;
    }
    if (!regexEmail.test(email)) {
        $('#errorEmail').text('Email không đúng định dạng');
        return false;
    } else {
        
                $("#errorEmail").text("");
        return true;
    }
}

function checkEmail(email) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/KhachHang/CheckEmail',
            data: { email: email },
            type: 'GET',
            success: function (response) {
                resolve(!response.exists);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function validateCCCD() {
    var cccd = $('#inputFieldCCCD').val();
    var regexCCCD = /^[0-9]{12}$/; // Regex for 12 digits
    if (cccd == "") {
        $('#errorCCCD').text('CCCD không được bỏ trống');
        return false;
    }
    if (!regexCCCD.test(cccd)) {
        $('#errorCCCD').text('CCCD phải có đúng 12 chữ số');
        return false;
    } else {
    
                $("#errorCCCD").text("");
        return true;
    }
}

function checkCCCD(cccd) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: '/KhachHang/CheckCCCD',
            data: { cccd: cccd },
            type: 'GET',
            success: function (response) {
                resolve(!response.exists);
            },
            error: function (error) {
                reject(error);
            }
        });
    });
}

function validateNgaySinh() {
    var ngaySinh = $('#inputFieldNgaySinh').val();
    if (ngaySinh == "") {
        $('#errorNgaySinh').text('Bạn chưa chọn ngày sinh');
        return false;
    }
    // Add your logic for checking if ngaySinh is valid according to your requirements
    // Example: Check if the user is at least 16 years old
    var birthDate = new Date(ngaySinh);
    var currentDate = new Date();
    var age = currentDate.getFullYear() - birthDate.getFullYear();
    if (age == "") {
        $('#errorNgaySinh').text('');
        $('#errorNgaySinh').text('Bạn chưa chọn ngày sinh');
    }
    if (age < 18) {
        $('#errorNgaySinh').text('');
        $('#errorNgaySinh').text('Bạn phải có ít nhất 18 tuổi để đặt phòng');
        return false;
    } else {
        $('#errorNgaySinh').text('');
        return true;
    }
}

function validateDiaChi() {
    var diaChi = $('#inputFieldDiaChi').val();
    if (diaChi == "") {
        $('#errorDiaChi').text('');
        $('#errorDiaChi').text('Địa chỉ không được bỏ trống');
        return false;
    } else {
        $('#errorDiaChi').text('');
        return true;
    }
}

$(document).ready(function () {
    $('#DatPhong').on('click', function (event) {
        if (!validateName() || !validatePhoneNumber() || !validateEmail() || !validateCCCD() || !validateNgaySinh() || !validateDiaChi()) {
            event.preventDefault();
            return;
        }
        else {
            var tenkh = $('#inputFieldTenKH').val();
            var gioitinh = $('#gioitinh').val();
            var sdt = $('#inputFieldSDT').val();
            var email = $('#inputFieldEmail').val();
            var ngaySinh = $('#inputFieldNgaySinh').val();
            var diaChi = $('#inputFieldDiaChi').val();
            var cccd = $('#inputFieldCCCD').val();
            // dự liệu bên đặt phòng
            var ngaynhan = $('#ngaynhan_text').text();
            var ngaytra = $('#ngaytra_text').text();
            var maphong = $('#maPhong_DatPhong').text();
            var soLuongNguoiLon = $('#giaTriSoLuongNguoiLonDat').text();
            var soLuongTreEm = $('#giaTriSoLuongTreEmDat').text();
            var TongTien = $('#TongTien').text();

            var arrSoLuongDichVu = JSON.parse(sessionStorage.getItem('arrSoLuongDichVu'));
            var arrMaDichVu = JSON.parse(sessionStorage.getItem('arrMaDichVu'));
            $.ajax({
                type: 'POST',
                url: `/TrangChuKhachHang/DatPhong`,
                data: {
                    TenKhachHang: tenkh,
                    GioiTinh: gioitinh,
                    sdt: sdt,
                    email: email,
                    ngaysinh: ngaySinh,
                    diachi: diaChi,
                    cccd: cccd,
                    NgayNhan: ngaynhan,
                    NgayTra: ngaytra,
                    MaPhong: maphong,
                    SoLuongNguoiLon: soLuongNguoiLon,
                    SoLuongTreEm: soLuongTreEm,
                    TongTien: TongTien,
                    arrSoLuongDichVu: arrSoLuongDichVu,
                    arrMaDichVu: arrMaDichVu
                },
                success: function (response) {
                    alert('Đặt phòng thành công');
                    console.log('AJAX request successful');
                    console.log(response);

                    // Check if the response indicates success
                    if (response.success) {
                        console.log('Redirecting to /TrangChuKhachHang/Index');

                        // Check if there is a redirectTo value in the response
                        if (response.redirectTo) {
                            window.location.href = response.redirectTo;
                        } else {
                            console.error('Redirect URL not provided in the response');
                        }
                    } else {
                        console.error('Booking failed:', response.message);
                    }
                },
                error: function (error) {
                    console.error('Error:', error);
                }
            });
        }
    });
});


