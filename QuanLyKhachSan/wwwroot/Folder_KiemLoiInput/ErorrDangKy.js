$(document).ready(function () {
    $("#inputTenKhachHang").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#erorrInputTenKhachHang").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#erorrInputTenKhachHang").text("Tên khách hàng không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#erorrInputTenKhachHang").text("Tên khách hàng chỉ được chứa chữ cái và khoảng trắng.");
        } else if (inputValue.trim() == "") {
            $("#erorrInputTenKhachHang").text("Tên khách hàng không hợp lệ.");
        }
        else {
            $("#erorrInputTenKhachHang").text("");
        }
    });
    $("#inputFieldEmail").on("focusout", function () {
        var emailValue = $(this).val();
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
        } else if (!emailRegex.test(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
        } else {

            $.ajax({
                url: '/KhachHang/CheckEmail',  // Đường dẫn đến API của bạn
                type: 'GET',
                data: { email: emailValue },
                success: function (data) {
                    if (data.exists) {
                        $("#errorEmail").text("Email đã tồn tại trong hệ thống.");
                    } else {
                        $("#errorEmail").text("");
                    }
                }
            });
        }
    });
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
    $("#inputFileNhapLaiMatKhau").on("focusout", function () {
        var matKhauNhapLaiValue = $(this).val();
        var matKhauValue = document.getElementById("inputFieldMK").value;
        if (matKhauNhapLaiValue != matKhauValue) {
            $("#errorNhapLaiMK").text("Mật khẩu nhập lại không đúng.");
        }
     else {
        $("#errorNhapLaiMK").text("");
    }
    });
    $("#myForm").submit(function (event) {


        var inputValueTenNV = $("#inputTenKhachHang").val();
        if (inputValueTenNV.length === 0) {
            $("#erorrInputTenKhachHang").text("Tên khách hàng không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#erorrInputTenKhachHang").text("Tên hách hàng không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNV.length === 0) {
            $("#erorrInputTenKhachHang").text("Tên hách hàng không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNV)) {
            $("#erorrInputTenKhachHang").text("Tên hách hàng chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }


        var emailValue = $("#inputFieldEmail").val();
        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
            event.preventDefault();
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Địa chỉ email không hợp lệ.");
            event.preventDefault();
        } else if (!isValidEmail(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
            event.preventDefault();
        } else {

            $.ajax({
                url: '/KhachHang/CheckEmail',  // Đường dẫn đến API của bạn
                type: 'GET',
                data: { email: emailValue },
                success: function (data) {
                    if (data.exists) {
                        $("#errorEmail").text("Email đã tồn tại trong hệ thống.");
                        event.preventDefault();
                    } else {
                        $("#errorEmail").text("");
                    }
                }
            });
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

        var NhapLaiMatKhau = document.getElementById("inputFileNhapLaiMatKhau").value;
        if (NhapLaiMatKhau != matKhauValue) {
            $("errorNhapLaiMK").text("Mật khẩu nhập lại không đúng");
            event.preventDefault();
        }


       
    });
});
function isValidEmail(email) {
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}
function isValidMatKhau(matKhau) {
    var matKhauRegex = /^(?=.*[A-Za-z])(?=.*\d).{6,}$/;
    return matKhauRegex.test(matKhau);
}