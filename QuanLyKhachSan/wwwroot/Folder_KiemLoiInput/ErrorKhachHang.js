$(document).ready(function () {

    // Bắt sự kiện khi người dùng click vào ô input tên khách hàng
    $("#inputFieldTenKH").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTenKH").text("Độ dài ít nhất 3 ký tự.");
            on.preventDefault();
        } else if (inputValue.length === 0) {
            $("#errorTenKH").text("Tên khách hàng không được để trống.");
            on.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTenKH").text("Tên khách hàng chỉ được chứa chữ cái và khoảng trắng.");
            on.preventDefault();
        } else {
            $("#errorTenKH").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input số điện thoại
    $("#inputFieldSDT").on("focusout", function () {
        var sdtValue = $(this).val();

        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
            on.preventDefault();
        } else if (!isValidSDT(sdtValue)) {
            $("#errorSDT").text("Số điện thoại không hợp lệ.");
            on.preventDefault();
        } else {
            // Gọi AJAX để kiểm tra 
            $.ajax({
                url: '/KhachHang/CheckSoDienThoai',
                data: { sodienthoai: sdtValue },
                type: 'GET',
                success: function (response) {
                    if (response.exists) {
                        $("#errorSDT").text("Số điện thoại đã tồn tại.");
                        on.preventDefault();
                    } else {
                        $("#errorSDT").text("");
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            }
            );
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input địa chỉ
    $("#inputFieldDiaChi").on("focusout", function () {
        var diaChiValue = $(this).val();

        if (diaChiValue.length < 3) {
            $("#errorDiaChi").text("Độ dài ít nhất 3 ký tự.");
            on.preventDefault();
        } else if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
            on.preventDefault();
        } else {
            $("#errorDiaChi").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input CCCD
    $("#inputFieldCCCD").on("focusout", function () {
        var cccdValue = $(this).val();

        if (cccdValue.length === 0) {
            $("#errorCCCD").text("CCCD không được để trống.");
            on.preventDefault();
        } else if (!isValidCCCD(cccdValue)) {
            $("#errorCCCD").text("CCCD không hợp lệ.");
            on.preventDefault();
        } else {
            // Gọi AJAX để kiểm tra email
            $.ajax({
                url: '/KhachHang/CheckCCCD',
                data: { cccd: cccdValue },
                type: 'GET',
                success: function (response) {
                    if (response.exists) {
                        $("#errorCCCD").text("CCCD đã tồn tại.");
                        on.preventDefault();
                    } else {
                        $("#errorCCCD").text("");
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            }
            );
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input ngày sinh
    $("#inputFieldNgaySinh").on("focusout", function () {
        var ngaySinhValue = $(this).val();

        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
            on.preventDefault();
        } else if (!isValidNgaySinh(ngaySinhValue)) {
            $("#errorNgaySinh").text("Ngày sinh không hợp lệ.");
            on.preventDefault();
        } else if (!isOldEnough(ngaySinhValue)) {
            $("#errorNgaySinh").text("Khách hàng phải đủ 18 tuổi trở lên.");
            on.preventDefault();
        } else {
            $("#errorNgaySinh").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input email
    $("#inputFieldEmail").on("focusout", function () {
        var emailValue = $(this).val();

        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
            on.preventDefault();

        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
            on.preventDefault();

        } else {

            // Gọi AJAX để kiểm tra email
            $.ajax({
                url: '/KhachHang/CheckEmail',
                data: { email: emailValue },
                type: 'GET',
                success: function (response) {
                    if (response.exists) {
                        $("#errorEmail").text("Email đã tồn tại.");
                        on.preventDefault();
                    } else {
                        $("#errorEmail").text("");
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            }
            );
        }
    })
        ;
    $("#DatPhong").on("click", function (event) {


        var inputValueTenNV = $("#inputFieldTenNV").val();
        if (inputValueTenNV.length === 0) {
            $("#errorTenNV").text("Tên nhân viên không được để trống.");
            on.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorTenNV").text("Tên nhân viên không được chứa toàn khoảng trắng.");
            on.preventDefault();
        } else if (inputValueTenNV.length === 0) {
            $("#errorTenNV").text("Tên nhân viên không được để trống.");
            on.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNV)) {
            $("#errorTenNV").text("Tên nhân viên chỉ được chứa chữ cái và khoảng trắng.");
            on.preventDefault();
        }


        var emailValue = $("#inputFieldEmail").val();
        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
            on.preventDefault();
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Địa chỉ email không hợp lệ.");
            on.preventDefault();
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
            on.preventDefault();
        }

        var diaChiValue = $("#inputFieldDiaChi").val();
        if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
            on.preventDefault();
        } else if (diaChiValue.trim() === "") {
            $("#errorDiaChi").text("Địa chỉ không được chứa toàn khoảng trắng.");
            on.preventDefault();
        } else if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
            on.preventDefault();
        }



        var sdtValue = $("#inputFieldSDT").val();
        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
            on.preventDefault();
        } else if (!isValidSDT(sdtValue)) {
            $("#errorSDT").text("Số điện thoại không hợp lệ.");
            event.preventDefault();
        }

        var cccdValue = $("#inputFieldCCCD").val();
        if (cccdValue.length === 0) {
            $("#errorCCCD").text("CCCD không được để trống.");
            on.preventDefault();
        } else if (!isValidCCCD(cccdValue)) {
            $("#errorCCCD").text("CCCD không hợp lệ.");
            on.preventDefault();
        }



        var ngaySinhValue = $("#inputFieldNgaySinh").val();
        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
            on.preventDefault();
        } else if (!isValidNgaySinh(ngaySinhValue)) {
            $("#errorNgaySinh").text("Ngày sinh không hợp lệ.");
            on.preventDefault();
        } else if (!isOldEnough(ngaySinhValue)) {
            $("#errorNgaySinh").text("Khách hàng phải đủ 18 tuổi trở lên.");
            on.preventDefault();
        }
        var hasError = $("#errorTenNV").text() !== "" || $("#errorEmail").text() !== "" || $("#errorDiaChi").text() !== "" || $("#errorSDT").text() !== "" || $("#errorCCCD").text() !== "" || $("#errorNgaySinh").text() !== "";

        if (!hasError) {
            // Nếu không có lỗi, thực hiện hành động đặt phòng
            // ...
        }
        else {
            event.preventDefault();
        }
    });






    // Hàm kiểm tra địa chỉ email hợp lệ
    function isValidEmail(email) {
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return emailRegex.test(email);
    }


    // Hàm kiểm tra số điện thoại hợp lệ
    function isValidSDT(sdt) {
        var sdtRegex = /^0\d{9}$/;
        return sdtRegex.test(sdt);
    }

    // Hàm kiểm tra CCCD hợp lệ
    function isValidCCCD(cccd) {
        var cccdRegex = /^\d{9,12}$/;
        return cccdRegex.test(cccd);
    }

    // Hàm kiểm tra mật khẩu hợp lệ
    function isValidMatKhau(matKhau) {
        var matKhauRegex = /^(?=.*[A-Za-z])(?=.*\d).{6,}$/;
        return matKhauRegex.test(matKhau);
    }

    // Hàm kiểm tra ngày sinh hợp lệ
    function isValidNgaySinh(ngaySinh) {
        var ngaySinhRegex = /^\d{4}-\d{2}-\d{2}$/;
        return ngaySinhRegex.test(ngaySinh);
    }

    // Hàm kiểm tra nhân viên đủ 15 tuổi trở lên
    function isOldEnough(ngaySinh) {
        var ngaySinhDate = new Date(ngaySinh);
        var today = new Date();
        var age = today.getFullYear() - ngaySinhDate.getFullYear();

        if (age > 18 || (age === 18 && today.getMonth() > ngaySinhDate.getMonth())) {
            return true;
        } else {
            return false;
        }
    }


    // Hàm kiểm tra ngày vào làm không được lớn hơn ngày hiện tại quá 7 ngày
    function isGreaterThan7Days(ngayVaoLam) {
        var ngayVaoLamDate = new Date(ngayVaoLam);
        var today = new Date();
        var differenceInDays = (ngayVaoLamDate - today) / (1000 * 60 * 60 * 24);

        return differenceInDays > 7;
    }
});