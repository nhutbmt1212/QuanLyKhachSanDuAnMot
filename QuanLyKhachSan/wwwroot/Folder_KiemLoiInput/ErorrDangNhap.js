$(document).ready(function () {
    
    $("#inputFieldEmail").on("focusout", function () {
        var emailValue = $(this).val();
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
        } else if (!emailRegex.test(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
        } else {
            $("#errorEmail").text(" ");
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
  
    $("#emailQuenMk").on("focusout", function () {
        var emailValue = $(this).val();
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (emailValue.length === 0) {
            $("#errorQuenMatKhauEmail").text("Email không được để trống.");
        } else if (!emailRegex.test(emailValue)) {
            $("#errorQuenMatKhauEmail").text("Email không hợp lệ.");
        } else {
            $.ajax({
                url: '/Access/CheckEmail',  // Đường dẫn đến API của bạn
                type: 'GET',
                data: { email: emailValue },
                success: function (data) {
                    if (data.exists) {
                        ("#errorQuenMatKhauEmail").text("");

                    } else {
                        $
                        $("#errorQuenMatKhauEmail").text("Email không tồn tại trong hệ thống.");
                    }
                }
            });
        } 
    });
    $("#passwordMoi").on("focusout", function () {
        var matKhauValue = $(this).val();

        if (matKhauValue.length === 0) {
            $("#erorrPassWordMoi").text("Mật khẩu không được để trống.");
        } else if (matKhauValue.length < 6) {
            $("#erorrPassWordMoi").text("Mật khẩu phải có ít nhất 6 ký tự.");
        } else if (!isValidMatKhau(matKhauValue)) {
            $("#erorrPassWordMoi").text("Mật khẩu phải bao gồm chữ và số.");
        } else {
            $("#erorrPassWordMoi").text("");
        }
    });
    $("#confirmPasswordMoi").on("focusout", function () {
        var matKhauValue = $(this).val();
        var matkhaucu = document.getElementById("passwordMoi").value;
        if (matkhaucu != matKhauValue) {
            $("#erorrComfỉmPassWordMoi").text("Mật khẩu nhập lại không đúng.");
        }
        else {
            $("#erorrComfỉmPassWordMoi").text("");
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