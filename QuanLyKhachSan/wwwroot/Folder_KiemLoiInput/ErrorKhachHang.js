$(document).ready(function () {
    // Bắt sự kiện khi người dùng click vào ô input mã nhân viên
    $("#inputFieldMaKH").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 5) {
            $("#errorMaKH").text("Độ dài ít nhất 5 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorMaKH").text("Mã khách hàng không được để trống.");
        } else if (/[^a-zA-Z0-9]/.test(inputValue)) {
            $("#errorMaKH").text("Mã khách hàng không được chứa ký tự đặc biệt hoặc khoảng trắng.");
        } else {
            $("#errorMaKH").text("");
        }
    });

    // Bắt sự kiện khi người dùng click vào ô input tên khách hàng
    $("#inputFieldTenKH").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTenKH").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTenKH").text("Tên khách hàng không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTenKH").text("Tên khách hàng chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTenKH").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input số điện thoại
    $("#inputFieldSDT").on("focusout", function () {
        var sdtValue = $(this).val();

        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
        } else if (!isValidSDT(sdtValue)) {
            $("#errorSDT").text("Số điện thoại không hợp lệ.");
        } else {
            $("#errorSDT").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input địa chỉ
    $("#inputFieldDiaChi").on("focusout", function () {
        var diaChiValue = $(this).val();

        if (diaChiValue.length < 3) {
            $("#errorDiaChi").text("Độ dài ít nhất 3 ký tự.");
        } else if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
        } else {
            $("#errorDiaChi").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input CCCD
    $("#inputFieldCCCD").on("focusout", function () {
        var cccdValue = $(this).val();

        if (cccdValue.length === 0) {
            $("#errorCCCD").text("CCCD không được để trống.");
        } else if (!isValidCCCD(cccdValue)) {
            $("#errorCCCD").text("CCCD không hợp lệ.");
        } else {
            $("#errorCCCD").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input ngày sinh
    $("#inputFieldNgaySinh").on("focusout", function () {
        var ngaySinhValue = $(this).val();

        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
        } else if (!isValidNgaySinh(ngaySinhValue)) {
            $("#errorNgaySinh").text("Ngày sinh không hợp lệ.");
        } else if (!isOldEnough(ngaySinhValue)) {
            $("#errorNgaySinh").text("Nhân viên phải đủ 15 tuổi trở lên.");
        } else {
            $("#errorNgaySinh").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input email
    $("#inputFieldEmail").on("focusout", function () {
        var emailValue = $(this).val();

        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
        } else {
            $("#errorEmail").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input mật khẩu
    $("#inputFieldMK").on("focusout", function () {
        var matKhauValue = $(this).val();

        if (matKhauValue.length === 0) {
            $("#errorMK").text("Mật khẩu không được để trống.");
        } else if (matKhauValue.length < 6) {
            $("#errorMK").text("Mật khẩu phải có ít nhất 6 ký tự.");
        } else if (!isValidMatKhau(matKhauValue)) {
            $("#errorMK").text("Mật khẩu phải bao gồm chữ và số.");
        } else {
            $("#errorMK").text("");
        }
    });










    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {
        var inputValueMaKH = $("#inputFieldMaKH").val();
        if (inputValueMaKH.length === 0) {
            $("#errorMaKH").text("Mã khách hàng không được để trống.");
            // Ngăn chặn submit nếu có lỗi
            event.preventDefault();
        } else if (inputValueMaKH.length === 0) {
            $("#errorMaKH").text("Mã khách hàng không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-Z0-9]/.test(inputValueMaKH)) {
            $("#errorMaKH").text("Mã khách hàng không được chứa ký tự đặc biệt hoặc khoảng trắng.");
            event.preventDefault();
        }


        var inputValueTenKH = $("#inputFieldTenKH").val();
        if (inputValueTenKH.length === 0) {
            $("#errorTenKH").text("Tên khách hàng không được để trống.");
            event.preventDefault();
        } else if (inputValueTenKH.trim() === "") {
            $("#errorTenKH").text("Tên khách hàng không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenKH.length === 0) {
            $("#errorTenKH").text("Tên khách hàng không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenKH)) {
            $("#errorTenKH").text("Tên khách hàng chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }


        var emailValue = $("#inputFieldEmail").val();
        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
            event.preventDefault();
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
            event.preventDefault();
        } 

        var diaChiValue = $("#inputFieldDiaChi").val();
        if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
            event.preventDefault();
        } else if (diaChiValue.trim() === "") {
            $("#errorDiaChi").text("Địa chỉ không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
            event.preventDefault();
        }

        var sdtValue = $("#inputFieldSDT").val();
        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
            event.preventDefault();
        } else if (!isValidSDT(sdtValue)) {
            $("#errorSDT").text("Số điện thoại không hợp lệ.");
            event.preventDefault();
        }

        var cccdValue = $("#inputFieldCCCD").val();
        if (cccdValue.length === 0) {
            $("#errorCCCD").text("CCCD không được để trống.");
            event.preventDefault();
        } else if (!isValidCCCD(cccdValue)) {
            $("#errorCCCD").text("CCCD không hợp lệ.");
            event.preventDefault();
        } 

        var matKhauValue = $("#inputFieldMK").val();
        if (matKhauValue.length === 0) {
            $("#errorMK").text("Mật khẩu không được để trống.");
            event.preventDefault();
        } else if (matKhauValue.length < 6) {
            $("#errorMK").text("Mật khẩu phải có ít nhất 6 ký tự.");
            event.preventDefault();
        } else if (!isValidMatKhau(matKhauValue)) {
            $("#errorMK").text("Mật khẩu phải bao gồm chữ và số.");
            event.preventDefault();
        }

        var ngaySinhValue = $("#inputFieldNgaySinh").val();
        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
            event.preventDefault();
        } else if (!isValidNgaySinh(ngaySinhValue)) {
            $("#errorNgaySinh").text("Ngày sinh không hợp lệ.");
            event.preventDefault();
        } else if (!isOldEnough(ngaySinhValue)) {
            $("#errorNgaySinh").text("Nhân viên phải đủ 15 tuổi trở lên.");
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

        if (age > 15 || (age === 15 && today.getMonth() > ngaySinhDate.getMonth())) {
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