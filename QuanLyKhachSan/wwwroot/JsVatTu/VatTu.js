
var btn_them = document.getElementById('btn_themvt');

function openForm() {
    document.getElementById("myForm").style.display = "block";
    btn_them.style.display = 'none';
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    btn_them.style.display = 'block';

}
//turn off popup if both open
document.getElementById('btn_themvt').addEventListener('click', hidePopUpEditNhanVien);
function hidePopUpEditNhanVien() {
    document.getElementById('myFormEdit').style.display = 'none';
}

document.getElementById('btn_Sua').addEventListener('click', hidePopUpAddNhanVien);
function hidePopUpAddNhanVien() {
    document.getElementById('myForm').style.display = 'none';
    btn_them.style.display = 'block';

}
function OpenFormEdit() {
    document.getElementById('myFormEdit').style.display = "block";

}

function CloseFormEdit() {
    document.getElementById('myFormEdit').style.display = "none";

}
function OpenFormEdit(maVatTu, tenVatTu, nhaSanXuat, tinhTrangVatTu, ngayThem) {
    // Hiển thị popup sửa vật tư
    document.getElementById("myFormEdit").style.display = "block";

    // Điền thông tin của vật tư vào các input
    document.getElementById("MaVatTuEdit").value = maVatTu;
    document.getElementById("TenVatTuEdit").value = tenVatTu.trim();
    document.getElementById("NhaSanXuatEdit").value = nhaSanXuat.trim();
    document.getElementById("TinhTrangVatTuEdit").value = tinhTrangVatTu;

    // Chuyển định dạng ngày
   /* var formattedDate = ngayThem.replace(" ", "T");*/
    document.getElementById("NgayThemEdit").value = ngayThem;
    console.log(ngayThem)
}
$(document).ready(function () {
    $("#inputFieldTenVT").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTenVT").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTenVT").text("Tên vật tư không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTenVT").text("Tên vật tư chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTenVT").text("");
        }
    });
    $("#inputFieldNhaSX").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorNhaSX").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorNhaSX").text("Nhà sản xuất không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorNhaSX").text("Nhà sản xuất chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorNhaSX").text("");
        }
    });
    $("#inputFieldTinhTrangVT").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorTinhTrangVT").text("Tình trạng vật tư ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorTinhTrangVTerrorTinhTrangVT").text("Tình trạng vật tư không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorTinhTrangVT").text("Tình trạng vật tư chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorTinhTrangVT").text("");
        }
    });
    $("#inputEditTenVT").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorEditTenVT").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorEditTenVT").text("Tên vật tư không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorEditTenVT").text("Tên vật tư chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorEditTenVT").text("");
        }
    });
    $("#inputEditNhaSX").on("focusout", function () {
        var inputValue = $(this).val();

        if (inputValue.length < 3) {
            $("#errorEditNhaSX").text("Độ dài ít nhất 3 ký tự.");
        } else if (inputValue.length === 0) {
            $("#errorEditNhaSX").text("Tên vật tư không được để trống.");
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValue)) {
            $("#errorEditNhaSX").text("Tên vật tư chỉ được chứa chữ cái và khoảng trắng.");
        } else {
            $("#errorEditNhaSX").text("");
        }
    });
    $("#myForm").submit(function (event) {


        var inputValueTenNV = $("#inputFieldTenVT").val();
        if (inputValueTenNV.length === 0) {
            $("#errorTenVT").text("Tên vật tư không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorTenVT").text("Tênvật tư không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNV.length === 0) {
            $("#errorTenVT").text("Tên vật tư không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNV)) {
            $("#errorTenVT").text("Tên vật tư chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }

        var inputValueTenNhaSx = $("#inputFieldTenVT").val();
        if (inputValueTenNhaSx.length === 0) {
            $("#errorNhaSX").text("Tên nhà sản xuất không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNhaSx.trim() === "") {
            $("#errorNhaSX").text("Tên nhà sản xuất không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNhaSx.length === 0) {
            $("#errorNhaSX").text("Tên nhà sản xuất không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNhaSx)) {
            $("#errorNhaSX").text("Tên nhà sản xuất chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }
      
    });

    $("#myFormEdit").submit(function (event) {


        var inputValueTenNV = $("#inputEditTenVT").val();
        if (inputValueTenNV.length === 0) {
            $("#errorEditTenVT").text("Tên vật tư không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNV.trim() === "") {
            $("#errorEditTenVT").text("Tênvật tư không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNV.length === 0) {
            $("#errorEditTenVT").text("Tên vật tư không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNV)) {
            $("#errorEditTenVT").text("Tên vật tư chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }

        var inputValueTenNhaSx = $("#inputEditNhaSX").val();
        if (inputValueTenNhaSx.length === 0) {
            $("#errorEditNhaSX").text("Tên nhà sản xuất không được để trống.");
            event.preventDefault();
        } else if (inputValueTenNhaSx.trim() === "") {
            $("#errorEditNhaSX").text("Tên nhà sản xuất không được chứa toàn khoảng trắng.");
            event.preventDefault();
        } else if (inputValueTenNhaSx.length === 0) {
            $("#errorEditNhaSX").text("Tên nhà sản xuất không được để trống.");
            event.preventDefault();
        } else if (/[^a-zA-ZÀ-Ỹà-ỹ ]/.test(inputValueTenNhaSx)) {
            $("#errorEditNhaSX").text("Tên nhà sản xuất chỉ được chứa chữ cái và khoảng trắng.");
            event.preventDefault();
        }

    });

});
