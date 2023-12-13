

// quên mật khẩu

$(document).ready(function () {
    var confirmationCode; 

    $("#btnGuiMail").on("click", function () {
        var email = $("#emailQuenMk").val();

        $.ajax({
            type: "POST",
            url: "/Access/GuiMail",
            data: { Email: email },
            success: function (response) {
                if (response.success) {
                    confirmationCode = response.confirmationCode;

                    $("#confirmationSection").show();
                    alert("Email đã được gửi thành công!");
                } else {
                    alert("Gửi email không thành công. Vui lòng thử lại!");
                }
            },
            error: function () {
                alert("Đã có lỗi xảy ra khi gửi yêu cầu.");
            }
        });
    });

    $("#btnXacNhan").on("click", function () {
        var MaXacNhanInput = $("#confirmationCode").val();

        console.log("MaXacNhanInput:", MaXacNhanInput);
        console.log("confirmationCode:", confirmationCode);

        if (MaXacNhanInput === confirmationCode) {
            console.log('Đúng');
            $('#PasswordSection').show();
        } else {
            console.log('Sai');
            alert("Mã xác nhận sai. Vui lòng thử lại!");
        }
    });
    $("#btn_LuuMatKhau").on("click", function () {
        var email = $("#emailQuenMk").val();
        var password = $("#passwordMoi").val();
        var confirmPassword = $("#confirmPasswordMoi").val();

        if (password === confirmPassword) {
            sendNewPassword(email, password);
        } else {
            alert("Mật khẩu mới không khớp. Vui lòng nhập lại!");
        }
    });

    function sendNewPassword(email, password) {
        $.ajax({
            type: "POST",
            url: "/Access/QuenMatKhau", 
            data: { Email: email, NewPassword: password },
            success: function (response) {
            
                alert("Mật khẩu đã được cập nhật thành công!");
                location.reload();
            },
            error: function () {
                alert("Đã có lỗi xảy ra khi gửi yêu cầu.");
            }
        });
    }
});
