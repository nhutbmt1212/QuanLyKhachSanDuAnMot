$(document).ready(function () {
    // Bắt sự kiện khi người dùng click vào ô input mã nhân viên
    $("#inputFieldMaNV").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 5) {
            $("#errorMaNV").text("Độ dài ít nhất 5 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorMaNV").text("Mã nhân viên không được để trống.");
        } else if (/[^a-zA-Z0-9]/.test(inputValue)) {
            $("#errorMaNV").text("Mã nhân viên không được chứa ký tự đặc biệt hoặc khoảng trắng.");
        } else {
            $("#errorMaNV").text("");
        }
    });

    // Bắt sự kiện khi người dùng click vào ô input tên nhân viên
    $("#inputFieldTenNV").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTenNV").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTenNV").text("Tên nhân viên không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTenNV").text("Tên nhân viên chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTenNV").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input email
    $("#inputFieldEmail").on("focusout", function () {
        var emailValue = $(this).val();
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
        } else {
            $("#errorEmail").text("");
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

    // Bắt sự kiện khi người dùng rời khỏi ô input tên đăng nhập
    $("#inputFieldTenDangNhap").on("focusout", function () {
        var tendangnhapValue = $(this).val();

        if (tendangnhapValue.length === 0) {
            $("#errorTenDangNhap").text("Tên đăng nhập không được để trống.");
        }
        else if (tendangnhapValue.length < 5) {
            $("#errorTenDangNhap").text("Độ dài ít nhất 5 ký tự.");
        } else if (!isValidTenDangNhap(tendangnhapValue)) {
            $("#errorTenDangNhap").text("Tên đăng nhập không hợp lệ.");
        } else {
            $("#errorTenDangNhap").text("");
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

    // Bắt sự kiện khi người dùng rời khỏi ô input ngày vào làm
    $("#inputFieldNgayVaoLam").on("focusout", function () {
        var ngayVaoLamValue = $(this).val();

        if (ngayVaoLamValue.length === 0) {
            $("#errorNgayVaoLam").text("Ngày vào làm không được để trống.");
        } else if (!isValidNgayVaoLam(ngayVaoLamValue)) {
            $("#errorNgayVaoLam").text("Ngày vào làm không hợp lệ.");
        } else if (isGreaterThan7Days(ngayVaoLamValue)) {
            $("#errorNgayVaoLam").text("Ngày vào làm không được lớn hơn ngày hiện tại quá 7 ngày.");
        } else {
            $("#errorNgayVaoLam").text("");
        }
    });

    // Bắt sự kiện khi người dùng chọn ảnh
    $("#formFile").on("change", function () {
        var fileInput = $(this)[0];

        if (!fileInput.files.length) {
            $("#errorAnh").text("Vui lòng chọn một ảnh.");
        } else {
            $("#errorAnh").text("");
        }
    });








    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {
        var inputValueMaNV = $("#inputFieldMaNV").val();
        if (inputValueMaNV.length === 0) {
            $("#errorMaNV").text("Mã nhân viên không được để trống.");
            // Ngăn chặn submit nếu có lỗi
            event.preventDefault();
        }


        var inputValueTenNV = $("#inputFieldTenNV").val();
        if (inputValueTenNV.length === 0) {
            $("#errorTenNV").text("Tên nhân viên không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorTenNV").text("Tên nhân viên không được chứa toàn khoảng trắng.");
            event.preventDefault();
        }


        var emailValue = $("#inputFieldEmail").val();
        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
            event.preventDefault();
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Địa chỉ email không hợp lệ.");
            event.preventDefault();
        }

        var diaChiValue = $("#inputFieldDiaChi").val();
        if (diaChiValue.length === 0) {
            $("#errorDiaChi").text("Địa chỉ không được để trống.");
            event.preventDefault();
        } else if (diaChiValue.trim() === "") {
            $("#errorDiaChi").text("Địa chỉ không được chứa toàn khoảng trắng.");
            event.preventDefault();
        }

        var tendangnhapValue = $("#inputFieldTenDangNhap").val();
        if (tendangnhapValue.length === 0) {
            $("#errorTenDangNhap").text("Tên đăng nhập không được để trống.");
            event.preventDefault();
        }

        var sdtValue = $("#inputFieldSDT").val();
        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
            event.preventDefault();
        }

        var cccdValue = $("#inputFieldCCCD").val();
        if (cccdValue.length === 0) {
            $("#errorCCCD").text("CCCD không được để trống.");
            event.preventDefault();
        }

        var matKhauValue = $("#inputFieldMK").val();
        if (matKhauValue.length === 0) {
            $("#errorMK").text("Mật khẩu không được để trống.");
            event.preventDefault();
        }

        var ngaySinhValue = $("#inputFieldNgaySinh").val();
        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
            event.preventDefault();
        }

        var ngayVaoLamValue = $("#inputFieldNgayVaoLam").val();
        if (ngayVaoLamValue.length === 0) {
            $("#errorNgayVaoLam").text("Ngày vào làm không được để trống.");
            event.preventDefault();
        }

        var fileInput = $("#formFile")[0];
        if (!fileInput.files.length) {
            $("#errorAnh").text("Vui lòng chọn một ảnh.");
            event.preventDefault();
        }
    });








    // Hàm kiểm tra địa chỉ email hợp lệ
    function isValidEmail(email) {
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return emailRegex.test(email);
    }

    // Hàm kiểm tra tên đăng nhập hợp lệ
    function isValidTenDangNhap(tenDangNhap) {
        var regex = /^[a-zA-Z0-9]+$/;
        return regex.test(tenDangNhap);
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

    // Hàm kiểm tra ngày vào làm hợp lệ
    function isValidNgayVaoLam(ngayVaoLam) {
        var ngayVaoLamRegex = /^\d{4}-\d{2}-\d{2}$/;
        return ngayVaoLamRegex.test(ngayVaoLam);
    }

    // Hàm kiểm tra ngày vào làm không được lớn hơn ngày hiện tại quá 7 ngày
    function isGreaterThan7Days(ngayVaoLam) {
        var ngayVaoLamDate = new Date(ngayVaoLam);
        var today = new Date();
        var differenceInDays = (ngayVaoLamDate - today) / (1000 * 60 * 60 * 24);

        return differenceInDays > 7;
    }
});