$(document).ready(function () {
    // Bắt sự kiện khi người dùng click vào ô input mã nhân viên
    $("#inputFieldMaLP").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 5) {
            $("#errorMaLP").text("Độ dài ít nhất 5 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorMaLP").text("Mã loại phòng không được để trống.");
        } else if (/[^a-zA-Z0-9]/.test(inputValue)) {
            $("#errorMaLP").text("Mã loại phòng không được chứa ký tự đặc biệt hoặc khoảng trắng.");
        } else {
            $("#errorMaLP").text("");
        }
    });

    // Bắt sự kiện khi người dùng click vào ô input tên nhân viên
    $("#inputFieldTenLP").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTenLP").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTenLP").text("Tên loại phòng không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTenLP").text("Tên loại phòng chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTenLP").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input giá theo giờ
    $("#inputFieldGiaTheoGio").on("focusout", function () {
        var giaTheoGioValue = $(this).val();

        if (giaTheoGioValue.length === 0) {
            $("#errorGiaTheoGio").text("Giá theo giờ không được để trống.");
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoGio").text("Giá theo giờ không hợp lệ.");
        } else {
            $("#errorGiaTheoGio").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input giá theo giờ
    $("#inputFieldGiaTheoNgay").on("focusout", function () {
        var giaTheoGioValue = $(this).val();

        if (giaTheoGioValue.length === 0) {
            $("#errorGiaTheoNgay").text("Giá theo ngày không được để trống.");
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoNgay").text("Giá theo ngày không hợp lệ.");
        } else {
            $("#errorGiaTheoNgay").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input giá theo giờ
    $("#inputFieldPhuThu").on("focusout", function () {
        var giaTheoGioValue = $(this).val();

        if (giaTheoGioValue.length === 0) {
            $("#errorPhuThu").text("Giá phụ thu không được để trống.");
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorPhuThu").text("Giá phụ thu không hợp lệ.");
        } else {
            $("#errorPhuThu").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input giá theo giờ
    $("#inputFieldNguoiLon").on("focusout", function () {
        var giaTheoGioValue = $(this).val();

        if (giaTheoGioValue.length === 0) {
            $("#errorNguoiLon").text("Số lượng người lớn không được để trống.");
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorNguoiLon").text("Số lượng người lớn không hợp lệ.");
        } else {
            $("#errorNguoiLon").text("");
        }
    });

    // Bắt sự kiện khi người dùng rời khỏi ô input giá theo giờ
    $("#inputFieldTreEm").on("focusout", function () {
        var giaTheoGioValue = $(this).val();

        if (giaTheoGioValue.length === 0) {
            $("#errorTreEm").text("Số lượng trẻ em không được để trống.");
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorTreEm").text("Số lượng trẻ em không hợp lệ.");
        } else {
            $("#errorTreEm").text("");
        }
    });







    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {
        var inputValueMaLP = $("#inputFieldMaLP").val();
        if (inputValueMaLP.length === 0) {
            $("#errorMaLP").text("Mã loại phòng không được để trống.");
            // Ngăn chặn submit nếu có lỗi
            event.preventDefault();
        } else if (/[^a-zA-Z0-9]/.test(inputValueMaLP)) {
            $("#errorMaLP").text("Mã loại phòng không được chứa ký tự đặc biệt hoặc khoảng trắng.");
            event.preventDefault();
        }


        var inputValueTenLP = $("#inputFieldTenLP").val();
        if (inputValueTenLP.length === 0) {
            $("#errorTenLP").text("Tên loại phòng không được để trống.");
            event.preventDefault();
        } else if (inputValueTenLP.trim() === "") {
            $("#errorTenLP").text("Tên loại phòng không được chứa toàn khoảng trắng.");
            event.preventDefault();
        }else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenLP)) {
            $("#errorTenLP").text("Tên loại phòng chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }

        // Lấy giá trị từ ô input
        var giaTheoGioValue = $("#inputFieldGiaTheoGio").val();
        if (giaTheoGioValue.length === 0) {
            $("#errorGiaTheoGio").text("Giá theo giờ không được để trống.");
            event.preventDefault();
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoGio").text("Giá theo giờ không hợp lệ.");
            event.preventDefault();
        } 
        // Lấy giá trị từ ô input
        var giaTheoNgayValue = $("#inputFieldGiaTheoNgay").val();
        if (giaTheoNgayValue.length === 0) {
            $("#errorGiaTheoNgay").text("Giá theo ngày không được để trống.");
            event.preventDefault();
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoGio").text("Giá theo giờ không hợp lệ.");
            event.preventDefault();
        } 
        // Lấy giá trị từ ô input
        var phuThuValue = $("#inputFieldPhuThu").val();
        if (phuThuValue.length === 0) {
            $("#errorPhuThu").text("Phụ thu không được để trống.");
            event.preventDefault();
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoGio").text("Phụ thu không hợp lệ.");
            event.preventDefault();
        } 
        // Lấy giá trị từ ô input
        var giaTheoGioValue = $("#inputFieldNguoiLon").val();
        if (giaTheoGioValue.length === 0) {
            $("#errorNguoiLon").text("Số lượng người lớn không được để trống.");
            event.preventDefault();
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoGio").text("Số lượng người lớn không hợp lệ.");
            event.preventDefault();
        } 
        // Lấy giá trị từ ô input
        var giaTheoGioValue = $("#inputFieldTreEm").val();
        if (giaTheoGioValue.length === 0) {
            $("#errorTreEm").text("Số lượng trẻ em không được để trống.");
            event.preventDefault();
        } else if (!isValidGiaTheoGio(giaTheoGioValue)) {
            $("#errorGiaTheoGio").text("Số lượng trẻ em không hợp lệ.");
            event.preventDefault();
        } 
    });

    // Hàm kiểm tra giá theo giờ hợp lệ
    function isValidGiaTheoGio(giaTheoGio) {
        // Sử dụng biểu thức chính quy để kiểm tra chỉ có số và không âm
        var giaTheoGioRegex = /^\d+$/;

        return giaTheoGioRegex.test(giaTheoGio) && parseInt(giaTheoGio) >= 0;
    }
});