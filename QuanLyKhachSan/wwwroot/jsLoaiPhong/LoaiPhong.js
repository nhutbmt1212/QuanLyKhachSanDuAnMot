var btn_them = document.getElementById('btn_themLoaiPhong');

function openForm() {
    document.getElementById("myForm").style.display = "block";
    btn_them.style.display = 'none';
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    btn_them.style.display = 'block';
}

// Popup for editing room types
function OpenFormEdit() {
    document.getElementById('myFormEdit').style.display = "block";
}

function CloseFormEdit() {
    document.getElementById('myFormEdit').style.display = "none";
}

// Turn off the edit popup if both are open
document.getElementById('btn_themLoaiPhong').addEventListener('click', hidePopUpEditLoaiPhong);

function hidePopUpEditLoaiPhong() {
    document.getElementById('myFormEdit').style.display = 'none';
}

// Event listener for the "Sửa" button in the dropdown menu
document.getElementById('btn_Sua').addEventListener('click', hidePopUpAddLoaiPhong);

function hidePopUpAddLoaiPhong() {
    document.getElementById('myForm').style.display = 'none';
    btn_them.style.display = 'block';
}
var getValue = document.querySelector('#table_detail');

getValue.addEventListener('click', function (e) {
    const cell = e.target.closest('td');
    if (!cell) { return; }
    const row = cell.parentElement;
    var maLoaiPhong = row.dataset.maLoaiPhong;
    var tenLoaiPhong = row.dataset.tenLoaiPhong;
    var giaTheoGio = row.dataset.giaTheoGio;
    var giaTheoNgay = row.dataset.giaTheoNgay;
    var phuThuTraMuon = row.dataset.phuThuTraMuon;
    var soLuongNguoiLon = row.dataset.soLuongNguoiLon;
    var soLuongTreEm = row.dataset.soLuongTreEm;
    console.log(giaTheoNgay);
    document.querySelector(".maLPEdit").value = maLoaiPhong;
    document.querySelector(".tenLPEdit").value = tenLoaiPhong;
    document.querySelector(".GiaTheoGioEdit").value = giaTheoGio;
    document.querySelector(".GiaTheoNgayEdit").value = giaTheoNgay;
    document.querySelector(".PhuThuEdit").value = phuThuTraMuon;
    document.querySelector(".SoNguoiLonEdit").value = soLuongNguoiLon;
    document.querySelector(".SoTreEmEdit").value = soLuongTreEm;


});
// Event listener for the header checkbox to tick/untick all checkboxes
document.getElementById('thead_checkbox').addEventListener('click', TickedAllCheckBox);

function TickedAllCheckBox() {
    var type_checkbox = document.getElementById('thead_checkbox').checked;
    var elements_checkbox_content = document.querySelectorAll('.tbody_checkbox');

    elements_checkbox_content.forEach(function (checkbox) {
        checkbox.checked = type_checkbox;
        KiemTraCheckBox();
    });
}

// Check the number of selected checkboxes for room types
function KiemTraCheckBox() {
    var x = document.querySelectorAll('input[name="checkBox_Name"]:checked');
    var btn = document.querySelectorAll(".check_checkbox");

    for (const btn_element of btn) {
        if (x.length > 1) {
            btn_element.classList.add('hide_edit');
        } else {
            btn_element.classList.remove('hide_edit');
        }
    }
}

// Additional UI adjustments on page load
window.addEventListener('load', function (event) {
    // Perform any additional UI adjustments here
});