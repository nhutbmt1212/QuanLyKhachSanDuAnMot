$(document).ready(function () {
    // Bắt sự kiện khi người dùng click vào ô input mã nhân viên
    $("#inputFieldMaP").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 5) {
            $("#errorMaP").text("Độ dài ít nhất 5 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorMaP").text("Mã phòng không được để trống.");
        } else if (/[^a-zA-Z0-9]/.test(inputValue)) {
            $("#errorMaP").text("Mã phòng không được chứa ký tự đặc biệt hoặc khoảng trắng.");
        } else {
            $("#errorMaP").text("");
        }
    });
    // Bắt sự kiện khi người dùng thay đổi giá trị của select
    $("#inputFieldChonLP").on("change", function () {
        // Lấy giá trị từ select
        var selectedValue = $(this).val();

        // Kiểm tra điều kiện và hiển thị thông báo lỗi
        if (selectedValue === "") {
            $("#errorChonLP").text("Vui lòng chọn tên một loại phòng.");
        } else {
            $("#errorChonLP").text("");
        }
    });
    $("#inputEditChonLP").on("change", function () {
        // Lấy giá trị từ select
        var selectedValue = $(this).val();

        // Kiểm tra điều kiện và hiển thị thông báo lỗi
        if (selectedValue === "") {
            $("#errorEditChonLP").text("Vui lòng chọn tên một loại phòng.");
        } else {
            $("#errorEditChonLP").text("");
        }
    });
    // Bắt sự kiện khi người dùng rời khỏi ô input ngày vào làm
    $("#inputFieldNgayTao").on("focusout", function () {
        var ngayTaoValue = $(this).val();

        if (ngayTaoValue.length === 0) {
            $("#errorNgayTao").text("Ngày tạo không được để trống.");
        } else if (!isValidNgayTao(ngayTaoValue)) {
            $("#errorNgayTao").text("Ngày tạo không hợp lệ.");
        } else if (isGreaterThan7Days(ngayTaoValue)) {
            $("#errorNgayTao").text("Ngày tạo không được lớn hơn ngày hiện tại quá 7 ngày.");
        } else {
            $("#errorNgayTao").text("");
        }
    });
    $("#inputEditNgayTao").on("focusout", function () {
        var ngayTaoValue = $(this).val();

        if (ngayTaoValue.length === 0) {
            $("#errorEditNgayTao").text("Ngày tạo không được để trống.");
        } else if (!isValidNgayTao(ngayTaoValue)) {
            $("#errorEditNgayTao").text("Ngày tạo không hợp lệ.");
        } else if (isGreaterThan7Days(ngayTaoValue)) {
            $("#errorEditNgayTao").text("Ngày tạo không được lớn hơn ngày hiện tại quá 7 ngày.");
        } else {
            $("#errorEditNgayTao").text("");
        }
    });
    $("#inputEditTinhTrang").on("focusout", function () {
        var TinhTrangValue = $(this).val();

        if (TinhTrangValue.length === 0) {
            $("#errorEditTinhTrang").text("Ngày tạo không được để trống.");
        } else if (!isValidTinhTrang(TinhTrangValue)) {
            $("#errorEditTinhTrang").text("Ngày tạo không hợp lệ.");
        } else {
            $("#errorEditTinhTrang").text("");
        }
        
    });
    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {
        var inputValueMaLP = $("#inputFieldMaP").val();
        if (inputValueMaLP.length === 0) {
            $("#errorMaP").text("Mã phòng không được để trống.");
            // Ngăn chặn submit nếu có lỗi
            event.preventDefault();
        } else if (/[^a-zA-Z0-9]/.test(inputValueMaLP)) {
            $("#errorMaP").text("Mã phòng không được chứa ký tự đặc biệt hoặc khoảng trắng.");
            event.preventDefault();
        }

        var selectedValue = $("#inputFieldChonLP").val();
        if (selectedValue === "") {
            $("#errorChonLP").text("Tên loại phòng chưa được chọn.");
            event.preventDefault();
        }


        var ngayTaoValue = $("#inputFieldNgayTao").val();

        // Kiểm tra xem ngày tạo có được chọn hay không
        if (ngayTaoValue.length === 0) {
            $("#errorNgayTao").text("Ngày tạo không được để trống.");
            event.preventDefault();
        } else if (!isValidNgayTao(ngayTaoValue)) {
            $("#errorNgayTao").text("Ngày tạo không hợp lệ.");
            event.preventDefault();
        } else if (isGreaterThan7Days(ngayTaoValue)) {
            $("#errorNgayTao").text("Ngày tạo không được lớn hơn ngày hiện tại quá 7 ngày.");
            event.preventDefault();
        } else {
            $("#errorNgayTao").text("");
        }

    });

    // Hàm kiểm tra ngày tạo hợp lệ
    function isValidNgayTao(ngayTao) {
        var ngayTaoRegex = /^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}$/;
        return ngayTaoRegex.test(ngayTao);
    }

    // Hàm kiểm tra ngày tạo không được lớn hơn ngày hiện tại quá 7 ngày
    function isGreaterThan7Days(ngayTao) {
        var ngayTaoDate = new Date(ngayTao);
        var today = new Date();
        var differenceInDays = (ngayTaoDate - today) / (1000 * 60 * 60 * 24);

        // Kiểm tra xem ngày tạo có lớn hơn ngày hiện tại quá 7 ngày không
        return differenceInDays > 7;
    }
});
