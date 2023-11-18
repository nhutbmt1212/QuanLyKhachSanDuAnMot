var btn_themDv = document.getElementById('btn_themDv');

function openForm() {
    document.getElementById("myForm").style.display = "block";
    btn_themDv.style.display = 'none';
}

function closeForm() {
    document.getElementById("myForm").style.display = "none";
    btn_themDv.style.display = 'block';
}

// Popup for editing services
function OpenFormEdit() {
    document.getElementById('myFormEdit').style.display = "block";
}

function CloseFormEdit() {
    document.getElementById('myFormEdit').style.display = "none";
}

// Turn off the edit popup if both are open
document.getElementById('btn_themDv').addEventListener('click', hidePopUpEditDichVu);

function hidePopUpEditDichVu() {
    document.getElementById('myFormEdit').style.display = 'none';
}

// Event listener for the "Sửa" button in the dropdown menu
document.getElementById('btn_Sua').addEventListener('click', hidePopUpAddDichVu);

function hidePopUpAddDichVu() {
    document.getElementById('myForm').style.display = 'none';
    btn_themDv.style.display = 'block';
}

var getValue = document.querySelector('#table_detail');

// Assuming getValue is an appropriate element

getValue.addEventListener('click', function (e) {
    const cell = e.target.closest('td');
    if (!cell) { return; }
    const row = cell.parentElement;
    var maDv = row.dataset.maDv;
    var tenDv = row.dataset.tenDv;
    var donViTinh = row.dataset.donvitinh;
    var giaTien = row.dataset.giatien;
    var tinhTrang = row.dataset.tinhtrang;
    var gioBatDauDv = row.dataset.giobatdaudichvu ;
    var gioKetThucDv = row.dataset.gioketthucdichvu;
     document.querySelector(".madichvu").value = maDv;
    document.querySelector(".tendichvu").value = tenDv;
    document.querySelector(".donvitinh").value = donViTinh;
    document.querySelector(".giatien").value = giaTien;
    document.querySelector(".tinhtrang").value = tinhTrang;
    document.querySelector(".giobddichvu").value = gioBatDauDv;
    document.querySelector(".gioktdichvu").value = gioKetThucDv;
    console.log(gioBatDauDv);
  
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

// Check the number of selected checkboxes for services
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
