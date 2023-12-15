
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
    document.getElementById("TenVatTuEdit").value = tenVatTu;
    document.getElementById("NhaSanXuatEdit").value = nhaSanXuat;
    document.getElementById("TinhTrangVatTuEdit").value = tinhTrangVatTu;

    // Chuyển định dạng ngày
   /* var formattedDate = ngayThem.replace(" ", "T");*/
    document.getElementById("NgayThemEdit").value = ngayThem;
    console.log(ngayThem)
}
