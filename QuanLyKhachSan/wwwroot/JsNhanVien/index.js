var btn_them = document.getElementById('btn_themNv');

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
document.getElementById('btn_themNv').addEventListener('click', hidePopUpEditNhanVien);

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

    var MaNv = row.dataset.maNv;
    var TenNv = row.dataset.tenNv;
    var email = row.dataset.email;
    var diaChiNv = row.dataset.diaChi;
    var sdtNv = row.dataset.soDienThoai;
    var cccdNv = row.dataset.cccd;
    var gioiTinhNv = row.dataset.gioiTinh;
    var ngaySinhNv = row.dataset.ngaySinh;
    var ngayDangKyNv = row.dataset.ngayDangKy;
    var chucVuNv = row.dataset.chucVu;
    var ngayVaoLamNv = row.dataset.ngayVaoLam;
    var tenDangNhapNv = row.dataset.tendangnhap;
    var matKhauNv = row.dataset.matkhau;
    var tinhTrangNv = row.dataset.tinhtrang;
    document.querySelector('.manvEdit').value = MaNv;
    document.querySelector('.tennvEdit').value = TenNv;
    document.querySelector('.emailEdit').value = email;
    document.querySelector('.diaChiEdit').value = diaChiNv;
    document.querySelector('.soDienThoaiEdit').value = sdtNv;
    document.querySelector('.cccdEdit').value = cccdNv;
    document.querySelector('.gioiTinhEdit').value = gioiTinhNv;
    document.querySelector('.tenDangNhapEdit').value = tenDangNhapNv;
    document.querySelector('.matKhauEdit').value = matKhauNv;
    document.querySelector('.tinhTrangEdit').value = tinhTrangNv;
    //convert time
    var ngaySinhParts = ngaySinhNv.split('/');
    var ngaySinhFormatted = ngaySinhParts[2] + '-' + ngaySinhParts[1] + '-' + ngaySinhParts[0];
    document.querySelector('.ngaySinhEdit').value = ngaySinhFormatted;
    document.querySelector('.manvEdit').value = MaNv;


    //var ngayDangKyParts = ngayDangKyNv.split('/');
    //var ngayDangKyFormatted = ngayDangKyParts[2] + '-' + ngayDangKyParts[1] + '-' + ngayDangKyParts[0];
    //document.querySelector('.ngayDangKyEdit').value = ngayDangKyFormatted;

    document.querySelector('.chucVuEdit').value = chucVuNv;

    var ngayVaoLamNv = "14/12/2021";
    formatAndSetDate(ngayVaoLamNv);
});
function formatAndSetDate(ngayVaoLamNv) {
    // Split the date string
    var ngayVaoLamParts = ngayVaoLamNv.split('/');

    // Check if the date string is in the expected format
    if (ngayVaoLamParts.length === 3) {
        // Format the date as "yyyy-MM-dd"
        var ngayVaoLamFormatted = ngayVaoLamParts[2] + '-' + ngayVaoLamParts[1] + '-' + ngayVaoLamParts[0];

        // Set the formatted date to the input field
        document.querySelector('.ngayVaoLamEdit').value = ngayVaoLamFormatted;
    } else {
        // Handle invalid date format (you may display an error message or take appropriate action)
        console.error('Invalid date format: ' + ngayVaoLamNv);
    }
}
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

