var btn_them = document.getElementById('btn_themKh');

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
document.getElementById('btn_themKh').addEventListener('click', hidePopUpEditNhanVien);

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
function formatAndSetDate(ngaysinh) {
    // Split the date string
    var ngayVaoLamParts = ngayVaoLamNv.split('/');

    // Check if the date string is in the expected format
    if (ngayVaoLamParts.length === 3) {
        // Format the date as "yyyy-MM-dd"
        var ngayVaoLamFormatted = ngayVaoLamParts[2] + '-' + ngayVaoLamParts[1] + '-' + ngayVaoLamParts[0];

        // Set the formatted date to the input field
        document.querySelector('.inputEditNgaySinh').value = ngayVaoLamFormatted;
    } else {
        // Handle invalid date format (you may display an error message or take appropriate action)
        console.error('Invalid date format: ' + ngayVaoLamNv);
    }
}
getValue.addEventListener('click', function (e) {
    const cell = e.target.closest('td');
    if (!cell) { return; }
    const row = cell.parentElement;

    var MaKh = row.dataset.maKh;
    var TenKh = row.dataset.tenKh;
    var gioiTinh = row.dataset.gioitinh;
    var sdt = row.dataset.sdt;
    var diaChi = row.dataset.diachi;
    var cccd = row.dataset.cccd;
    var ngaySinh = row.dataset.ngaysinh;
    var matKhau = row.dataset.matkhau;
    var tinhTrang = row.dataset.tinhtrang;
    var email = row.dataset.email;
    console.log(gioiTinh);
    document.querySelector('.MaKhachHangEdit').value = MaKh;
    document.querySelector('.TenKhachHangEdit').value = TenKh;
    document.querySelector('.SdtEdit').value = sdt;
    document.querySelector('.DiaChiEdit').value = diaChi;
    document.querySelector('.CccdEdit').value = cccd;
    document.querySelector('.GioiTinhEdit').value = gioiTinh;
    document.querySelector('.EmailEdit').value = email;
    document.querySelector('.TinhTrangEdit').value = tinhTrang;
    document.querySelector('.MatKhauEdit').value = matKhau;
    console.log(gioiTinh);
    //convert time
    var ngaySinhParts = ngaySinh.split('/');
    var ngaySinhFormatted = ngaySinhParts[2] + '-' + ngaySinhParts[1] + '-' + ngaySinhParts[0];
 
    document.querySelector('.NgaySinhEdit').value = ngaySinhFormatted;

   
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

