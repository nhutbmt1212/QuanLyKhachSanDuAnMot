var btn_them = document.getElementById('btn_themPhong');

function openForm() {
    document.getElementById("myForm").style.display = "block";
    btn_them.style.display = 'none';
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    btn_them.style.display = 'block';

}

//editPopup
function OpenFormEdit() {
    document.getElementById('myFormEdit').style.display = "block";

}
function CloseFormEdit() {
    document.getElementById('myFormEdit').style.display = "none";

}

//turn off popup if both open
document.getElementById('btn_themPhong').addEventListener('click', hidePopUpEditNhanVien);

function hidePopUpEditNhanVien() {
    document.getElementById('myFormEdit').style.display = 'none';
}

document.getElementById('btn_Sua').addEventListener('click', hidePopUpAddNhanVien);

function hidePopUpAddNhanVien() {
    document.getElementById('myForm').style.display = 'none';
    btn_them.style.display = 'block';

}

//take data from table and fill to form popup edit employee
var getValue = document.querySelector('#table_detail');

getValue.addEventListener('click', function (e) {
    const cell = e.target.closest('td');
    if (!cell) { return; }
    const row = cell.parentElement;

    var maphong = row.dataset.maPhong;
    var maLoaiPhong = row.dataset.maLoaiPhong;
    var ngayTao = row.dataset.ngayTao;
    var tinhTrang = row.dataset.tinhTrang;
    console.log(maphong);
    document.querySelector('.maphongedit').value = maphong;
    document.querySelector('.maloaiphongedit').value = maLoaiPhong;
    document.querySelector('.tinhtrangedit').value = tinhTrang;

  
    //convert time
    var ngayTaoParts = ngayTao.split('/');
    var ngaySinhFormatted = ngayTaoParts[2] + '-' + ngayTaoParts[1] + '-' + ngayTaoParts[0];
    document.querySelector('.ngaytaoedit').value = ngaySinhFormatted;

  
});
document.getElementById('thead_checkbox').addEventListener('click', TickedAllCheckBox);

function TickedAllCheckBox() {
    var type_checkbox = document.getElementById('thead_checkbox').checked;
    var elements_checkbox_content = document.querySelectorAll('.tbody_checkbox');

    elements_checkbox_content.forEach(function (checkbox) {
        checkbox.checked = type_checkbox;
        KiemTraCheckBox();

    });
}


//sự kiện onload để chỉnh ui hoatdong
window.addEventListener('load', (event) => {

});
function KiemTraCheckBox() {
    var x = document.querySelectorAll('input[name="checkBox_Name"]:checked');
    var btn = document.querySelectorAll(".check_checkbox");

    for (const btn_element of btn) {
        if (x.length > 1) {
            btn_element.classList.add('hide_edit');

        }
        else {
            btn_element.classList.remove('hide_edit');
        }
    }





}

