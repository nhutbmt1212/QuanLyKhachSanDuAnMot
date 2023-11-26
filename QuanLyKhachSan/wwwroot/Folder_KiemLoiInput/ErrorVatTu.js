$(document).ready(function () {
    // Bắt sự kiện khi người dùng click vào ô input mã nhân viên
    $("#inputFieldMaVT").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 5) {
            $("#errorMaVT").text("Độ dài ít nhất 5 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorMaVT").text("Mã vật tư không được để trống.");
        } else if (/[^a-zA-Z0-9]/.test(inputValue)) {
            $("#errorMaVT").text("Mã vật tư không được chứa ký tự đặc biệt hoặc khoảng trắng.");
        } else {
            $("#errorMaVT").text("");
        }
    });

    // Bắt sự kiện khi người dùng click vào ô input tên nhân viên
    $("#inputFieldTenVT").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTenVT").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTenVT").text("Tên vật tư không được để trống.");
        } else {
            $("#errorTenVT").text("");
        }
    });

    $("#inputFieldNhaSX").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorNhaSX").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorNhaSX").text("Tên nhà sản xuất không được để trống.");
        }  else {
            $("#errorNhaSX").text("");
        }
    });
    $("#inputFieldTinhTrangVT").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTinhTrangVT").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTinhTrangVT").text("Tình trạng vật tư không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTinhTrangVT").text("Tình trạng vật tư chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTinhTrangVT").text("");
        }
    });



    // Bắt sự kiện khi form được submit
    $("#myForm").submit(function (event) {
        var inputValueMaNV = $("#inputFieldMaVT").val();

        if (inputValueMaNV.length === 0) {
            $("#errorMaVT").text("Mã vật tư không được để trống.");
            // Ngăn chặn submit nếu có lỗi
            event.preventDefault();
        } else if (inputValueMaNV.length < 5) {
            $("#errorMaVT").text("Độ dài ít nhất 5 ký tự.");
            event.preventDefault();
        } else if (/[^a-zA-Z0-9]/.test(inputValueMaNV)) {
            $("#errorMaVT").text("Mã vật tư không được chứa ký tự đặc biệt hoặc khoảng trắng.");
            event.preventDefault();
        }


        var inputValueTenNV = $("#inputFieldTenVT").val();
        if (inputValueTenNV.length === 0) {
            $("#errorTenVT").text("Tên vật tư không được để trống.");
            event.preventDefault();
        }
        else if (inputValueTenNV.length < 5) {
            $("#errorTenVT").text("Độ dài ít nhất 5 ký tự.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorTenVT").text("Tên vật tư không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } 

        var inputValueTenSX = $("#inputFieldNhaSX").val();
         if (inputValueTenSX.length === 0) {
            $("#errorNhaSX").text("Tên nhà sản xuất không được để trống.");
            event.preventDefault();
        }
        else if (inputValueTenSX.length < 5) {
            $("#errorNhaSX").text("Độ dài ít nhất 5 ký tự.");
            event.preventDefault();
        } else if (inputValueTenSX.trim() === "") {
            $("#errorNhaSX").text("Tên nhà sản xuất không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } 

        var inputValueTenTT = $("#inputFieldTinhTrangVT").val();
        if (inputValueTenTT.length === 0) {
            $("#errorTinhTrangVT").text("Tình trạng không được để trống.");
            event.preventDefault();
        } else if (inputValueTenTT.length < 3) {
            $("#errorTinhTrangVT").text("Độ dài ít nhất 3 ký tự.");
            event.preventDefault();
        } else if (inputValueTenTT.trim() === "") {
            $("#errorTinhTrangVT").text("Tình trạng không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenTT)) {
            $("#errorTinhTrangVT").text("Tình trạng vật tư chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        } 

    });

    
});