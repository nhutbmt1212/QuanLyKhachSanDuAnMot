$(document).ready(function () {

    // Bắt sự kiện khi người dùng click vào ô input tên nhân viên
    $("#inputFieldTenDV").on("focusout", function () {
        var inputValue = $(this).val();
        if (inputValue.length === 0) {
            $("#errorTenDV").text("Tên dịch vụ không được để trống.");
        }
        else if (inputValue.length < 3) {
            $("#errorTenDV").text("Độ dài ít nhất 3 ký tự.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTenDV").text("Tên dịch vụ chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTenDV").text("");
        }
    });
    $("#inputEditTenDV").on("focusout", function () {
        var inputValue = $(this).val();
        if (inputValue.length === 0) {
            $("#errorEditTenDV").text("Tên dịch vụ không được để trống.");
        }
        else if (inputValue.length < 3) {
            $("#errorEditTenDV").text("Độ dài ít nhất 3 ký tự.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorEditTenDV").text("Tên dịch vụ chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorEditTenDV").text("");
        }
    });
    $("#inputFieldDVT").on("focusout", function () {
        var inputValue = $(this).val();
        if (inputValue.length === 0) {
            $("#errorDVT").text("Đơn vị tính không được để trống.");
        }
        else if (inputValue.length < 2) {
            $("#errorDVT").text("Độ dài ít nhất 2 ký tự.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorDVT").text("Đơn vị tính chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorDVT").text("");
        }
    });
    $("#inputEditDVT").on("focusout", function () {
        var inputValue = $(this).val();
        if (inputValue.length === 0) {
            $("#errorEditDVT").text("Đơn vị tính không được để trống.");
        }
        else if (inputValue.length < 2) {
            $("#errorEditDVT").text("Độ dài ít nhất 2 ký tự.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorEditDVT").text("Đơn vị tính chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorEditDVT").text("");
        }
    });
    $("#inputFieldGia").on("focusout", function () {
        var gia = $(this).val();

        if (gia.length === 0) {
            $("#errorGia").text("Giá theo giờ không được để trống.");
        } else if (!isValidGiaTheoGio(gia)) {
            $("#errorGia").text("Giá theo giờ không hợp lệ.");
        } else {
            $("#errorGia").text("");
        }
    });
    $("#inputEditGia").on("focusout", function () {
        var gia = $(this).val();

        if (gia.length === 0) {
            $("#errorEditGia").text("Giá theo giờ không được để trống.");
        } else if (!isValidGiaTheoGio(gia)) {
            $("#errorEditGia").text("Giá theo giờ không hợp lệ.");
        } else {
            $("#errorEditGia").text("");
        }
    });
    // Bắt sự kiện khi người dùng rời khỏi ô input Giờ BD phục vụ
    $("#inputFieldGioBD").on("focusout", function () {
        validateGioBD();
    });
    $("#inputEditGioBD").on("focusout", function () {
        var validateGioBD = $(this).val();
        if (validateGioBD.length === 0) {
            $("#errorEditGioBD").text("Giờ bắt đầu không được để trống.");
            event.preventDefault();
        } else if (!isvalidateGioBD(validateGioBD)) {
            $("#errorEditGioBD").text("Giờ bắt đầu không hợp lệ.");
            event.preventDefault();
        } else {
            $("#errorEditGioBD").text("");
        }
    });
    // Bắt sự kiện khi người dùng rời khỏi ô input Giờ KT phục vụ
    $("#inputFieldGioKT").on("focusout", function () {
        validateGioKT();
    });
    $("#inputEditGioKT").on("focusout", function () {
        if (validateGioKT.length === 0) {
            $("#errorEditGioKT").text("Giờ kết thúc không được để trống.");
            event.preventDefault();
        } else if (!isvalidateGioBD(validateGioBD)) {
            $("#errorEditGioKT").text("Giờ kết thúc không hợp lệ.");
            event.preventDefault();
        } else {
            $("#errorEditGioKT").text("");
        }
    });
    
   




    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {

        var inputValueTenNV = $("#inputFieldTenDV").val();
        if (inputValueTenNV.length === 0) {
            $("#errorTenDV").text("Tên dịch vụ không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorTenDV").text("Tên dịch vụ không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNV.length === 0) {
            $("#errorTenDV").text("Tên dịch vụ không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNV)) {
            $("#errorTenDV").text("Tên dịch vụ chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }

        var inputValueDVT = $("#inputFieldDVT").val();
        if (inputValueDVT.length === 0) {
            $("#errorDVT").text("Đơn vị tính không được để trống.");
            event.preventDefault();
        } else if (inputValueDVT.trim() === "") {
            $("#errorDVT").text("Đơn vị tính không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValue.length < 2) {
            $("#errorDVT").text("Độ dài ít nhất 2 ký tự.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueDVT)) {
            $("#errorDVT").text("Đơn vị tính chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }

        var gia = $("#inputFieldGia").val();
        if (gia.length === 0) {
            $("#errorGia").text("Giá theo giờ không được để trống.");
            event.preventDefault();
        } else if (!isValidGiaTheoGio(gia)) {
            $("#errorGia").text("Giá theo giờ không hợp lệ.");
            event.preventDefault();
        } 

        validateGioBD();
        validateGioKT();

        // Kiểm tra điều kiện trước khi submit form
        if ($("#errorGioBD").text() !== "" || $("#errorGioKT").text() !== "") {
            event.preventDefault();
        }
    });
    function isValidGiaTheoGio(giaTheoGio) {
        var giaTheoGioRegex = /^\d+$/;

        return giaTheoGioRegex.test(giaTheoGio) && parseInt(giaTheoGio) >= 0;
    }
    // Hàm kiểm tra Giờ BD phục vụ
    function validateGioBD() {
        var gioBDValue = $("#inputFieldGioBD").val();
        if (gioBDValue.length === 0) {
            $("#errorGioBD").text("Giờ bắt đầu không được để trống.");
        } else {
            $("#errorGioBD").text("");
        }
    }

    // Hàm kiểm tra Giờ KT phục vụ
    function validateGioKT() {
        var gioKTValue = $("#inputFieldGioKT").val();
        if (gioKTValue.length === 0) {
            $("#errorGioKT").text("Giờ kết thúc không được để trống.");
        } else {
            $("#errorGioKT").text("");
        }
    }
  
});