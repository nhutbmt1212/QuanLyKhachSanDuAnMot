$(document).ready(function () {
    $("#inputFieldTenKH").on("focusout", function () {
        var inputValue = $(this).val();
        console.log(inputValue);
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
   
    $("#inputFieldEmail").on("focusout", function () {
        var emailValue = $(this).val();
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        console.log(emailValue);
        if (emailValue.length === 0) {
            $("#errorEmail").text("Email không được để trống.");
        } else if (!emailRegex.test(emailValue)) {
            $("#errorEmail").text("Email không hợp lệ.");
        } else {

            $.ajax({
                url: '/TrangChuKhachHang/CheckEmail',  // Đường dẫn đến API của bạn
                type: 'GET',
                data: { email: emailValue },
                success: function (data) {
                    if (data.exists) {
                        $("#errorEmail").text("Email đã tồn tại.");
                    } else {
                        $("#errorEmail").text("");
                    }
                }
            });
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
    
    // Bắt sự kiện khi người dùng rời khỏi ô input số điện thoại
    $("#inputFieldSDT").on("focusout", function () {
        var sdtValue = $(this).val();
        console.log(sdtValue);
        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
        } else if (!isValidSDT(sdtValue)) {
            $("#errorSDT").text("Số điện thoại không hợp lệ.");
        } else {
            $.ajax({
                type: 'POST',
                url: '/TrangChuKhachHang/CheckSoDienThoai',  // Đường dẫn đến API của bạn
                data: { sodienthoai: sdtValue },
                success: function (data) {
                    if (data.exists) {
                        $("#errorSDT").text("Số điện thoại đã tồn tại.");
                    } else {
                        $("#errorSDT").text("");
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            });
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
            // Gửi yêu cầu đến API để kiểm tra CCCD
            $.ajax({
                url: '/TrangChuKhachHang/CheckCCCD',  // Đường dẫn đến API của bạn
                type: 'GET',
                data: { cccd: cccdValue },
                success: function (data) {
                    if (data.exists) {
                        $("#errorCCCD").text("CCCD đã tồn tại.");
                    } else {
                        $("#errorCCCD").text("");
                    }
                }
            });
        }
    });


  

    // Bắt sự kiện khi người dùng rời khỏi ô input mật khẩu
   
    // Bắt sự kiện khi người dùng rời khỏi ô input ngày sinh
    $("#inputFieldNgaySinh").on("focusout", function () {
        var ngaySinhValue = $(this).val();

        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
        } else if (!isValidNgaySinh(ngaySinhValue)) {
            $("#errorNgaySinh").text("Ngày sinh không hợp lệ.");
        } else if (!isOldEnough(ngaySinhValue)) {
            $("#errorNgaySinh").text("Khách hàng phải đủ 18 tuổi trở lên.");
        } else {
            $("#errorNgaySinh").text("");
        }
    });
    









    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {


        var inputValueTenNV = $("#inputFieldTenKH").val();
        if (inputValueTenNV.length === 0) {
            $("#errorTenKH").text("Tên nhân viên không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorTenKH").text("Tên nhân viên không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNV.length === 0) {
            $("#errorTenKH").text("Tên nhân viên không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNV)) {
            $("#errorTenKH").text("Tên nhân viên chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }


        var emailValue = $("#inputFieldEmail").val();
        var emailExists = false;
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
                url: '/TrangChuKhachHang/CheckEmail',
                type: 'GET',
                data: { email: emailValue },
                async: false,
                success: function (data) {
                    if (data.exists) {
                        $("#errorEmail").text("Email đã tồn tại .");
                        emailExists = true;
                    }
                }
            });

            if (emailExists) {
                event.preventDefault();
            }
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
        var sdtExists = false;
        if (sdtValue.length === 0) {
            $("#errorSDT").text("Số điện thoại không được để trống.");
            event.preventDefault();
        } else if (!isValidSDT(sdtValue)) {
            $("#errorSDT").text("Số điện thoại không hợp lệ.");
            event.preventDefault();
        } else {
            $.ajax({
                url: '/TrangChuKhachHang/CheckSoDienThoai',
                type: 'GET',
                data: { sodienthoai: sdtValue },
                async: false,
                success: function (data) {
                    if (data.exists) {
                        $("#errorSDT").text("Số điện thoại đã tồn tại trong hệ thống.");
                        sdtExists = true;
                    } else {
                        $("#errorSDT").text("");
                    }
                },
                error: function (error) {
                    console.error(error);
                }
            });

            if (sdtExists) {
                event.preventDefault();
            }
        }




        var cccdValue = $("#inputFieldCCCD").val();
        var cccdExists = false; // Khởi tạo biến ở đây
        if (cccdValue.length === 0) {
            $("#errorCCCD").text("CCCD không được để trống.");
            event.preventDefault();
        } else if (!isValidCCCD(cccdValue)) {
            $("#errorCCCD").text("CCCD không hợp lệ.");
            event.preventDefault();
        } else {
            // Gửi yêu cầu đến API để kiểm tra CCCD
            $.ajax({
                url: '/TrangChuKhachHang/CheckCCCD',  // Đường dẫn đến API của bạn
                type: 'GET',
                data: { cccd: cccdValue },
                success: function (data) {
                    if (data.exists) {
                        cccdExists = true;
                        $("#errorCCCD").text("CCCD đã tồn tại trong hệ thống.");
                    } else {
                        $("#errorCCCD").text("");
                    }
                }
            });
            if (cccdExists) {
                event.preventDefault();
            }
        }



       
        var ngaySinhValue = $("#inputFieldNgaySinh").val();
        if (ngaySinhValue.length === 0) {
            $("#errorNgaySinh").text("Ngày sinh không được để trống.");
            event.preventDefault();
        } else if (!isValidNgaySinh(ngaySinhValue)) {
            $("#errorNgaySinh").text("Ngày sinh không hợp lệ.");
            event.preventDefault();
        } else if (!isOldEnough(ngaySinhValue)) {
            $("#errorNgaySinh").text("Khách hàng phải đủ 18 tuổi trở lên.");
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

        if (age > 18 || (age === 18 && today.getMonth() > ngaySinhDate.getMonth())) {
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