$(document).ready(function () {
    $("#editedValue_employeeName").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#ErrorEmployeeName").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#ErrorEmployeeName").text("Tên nhân viên không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#ErrorEmployeeName").text("Tên nhân viên chỉ được chứa chữ cái và khoảng trắng.");
        } else if (inputValue.trim()==''){
            $("#ErrorEmployeeName").text("Tên nhân viên không hợp lệ.");
        }
        else {
            $("#ErrorEmployeeName").text("");
        }
    });
    $("#editedValue_email").on("focusout", function () {
        var emailValue = $(this).val();
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (emailValue.length === 0) {
            $("#ErrorEmployeemEmail").text("Email không được để trống.");
        } else if (!isValidEmail(emailValue)) {
            $("#ErrorEmployeemEmail").text("Email không hợp lệ.");
        } else {
            $("#ErrorEmployeemEmail").text("");
        }
    });
    $("#editedValue_address").on("focusout", function () {
        var diaChiValue = $(this).val();

        if (diaChiValue.length < 3) {
            $("#ErrorEmployeemDiaChi").text("Độ dài ít nhất 3 ký tự.");
        } else if (diaChiValue.length === 0) {
            $("#ErrorEmployeemDiaChi").text("Địa chỉ không được để trống.");
        } else {
            $("#ErrorEmployeemDiaChi").text("");
        }
    });
    $("#editedValue_phoneNumber").on("focusout", function () {

        var sdtValue = $(this).val();
        if (sdtValue.length === 0) {
            $("#ErrorEmployeePhoneNumber").text("Số điện thoại không được để trống.");

        } else if (!isValidSDT(sdtValue)) {
            $("#ErrorEmployeePhoneNumber").text("Số điện thoại không hợp lệ.");

        } else {
            $("#ErrorEmployeePhoneNumber").text("");
        }
    });

    $("#editedValue_cccd").on("focusout", function () {
        var cccdValue = $(this).val();
        if (cccdValue.length === 0) {
            $("#ErrorEmployeemCCCD").text("CCCD không được để trống.");

        } else if (!isValidCCCD(cccdValue)) {
            $("#ErrorEmployeemCCCD").text("CCCD không hợp lệ.");

        } else {
            $("#errorEditCCCD").text("CCCD không hợp lệ.");
        }
    });
    $("#editedValue_password").on("focusout", function () {
        var matKhauValue = $(this).val();

        if (matKhauValue.length === 0) {
            $("#ErrorEmployeemPassWord").text("Mật khẩu không được để trống.");
        } else if (matKhauValue.length < 6) {
            $("#ErrorEmployeemPassWord").text("Mật khẩu phải có ít nhất 6 ký tự.");
        } else if (!isValidMatKhau(matKhauValue)) {
            $("#ErrorEmployeemPassWord").text("Mật khẩu phải bao gồm chữ và số.");
        } else {
            $("#ErrorEmployeemPassWord").text("");
        }
    });

    $("#tennhanvien").click(function (event) {
        var inputValue = $("#editedValue_employeeName").val();
        console.log(inputValue);
        if (inputValue.length < 3) {
            $("#ErrorEmployeeName").text("Độ dài ít nhất 3 ký tự.");
            event.preventDefault();  // Ngăn chặn hành động lưu
        } else if (inputValue.length === 0) {
            $("#ErrorEmployeeName").text("Tên nhân viên không được để trống.");
            event.preventDefault();  // Ngăn chặn hành động lưu
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#ErrorEmployeeName").text("Tên nhân viên chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();  // Ngăn chặn hành động lưu
        } else if (inputValue.trim() == '') {
            $("#ErrorEmployeeName").text("Tên nhân viên không hợp lệ.");
            event.preventDefault();  // Ngăn chặn hành động lưu
        } else {
            $("#ErrorEmployeeName").text("");
        }
    });


});

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