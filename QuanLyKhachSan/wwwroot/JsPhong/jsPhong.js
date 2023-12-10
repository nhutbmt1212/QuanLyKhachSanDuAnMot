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
//sửa phòng
// Lưu các URL ảnh đã chọn vào một mảng
var selectedImages = [];

// Hàm hiển thị các ảnh đã chọn trong phần editpreview
function displaySelectedImages() {
    var previewElement = document.getElementById('editImagePreviewContainer');
    previewElement.innerHTML = '';

    selectedImages.forEach(function (imageUrl, index) {
        var imageContainer = document.createElement('div');
        imageContainer.classList.add('image-container');

        var imageElement = document.createElement('img');
        imageElement.src = imageUrl;

        var removeButton = document.createElement('button');
        removeButton.classList.add('remove-button');
        removeButton.innerText = 'X';
        removeButton.addEventListener('click', function () {
            removeImage(index);
        });

        imageContainer.appendChild(imageElement);
        imageContainer.appendChild(removeButton);
        previewElement.appendChild(imageContainer);
    });
}

// Hàm xóa ảnh khỏi phần editpreview
function removeImage(index) {
    selectedImages.splice(index, 1);
    displaySelectedImages();

    // Xóa ảnh khỏi danh sách "choose files"
    var fileInput = document.getElementById('editInputImage');
    var fileList = fileInput.files;
    var newFileList = new FileList();

    for (var i = 0; i < fileList.length; i++) {
        if (i !== index) {
            newFileList.append(fileList[i]);
        }
    }

    fileInput.files = newFileList;
}
// Hàm chuyển đổi từ base64 sang file
function dataURLtoFile(dataurl, filename) {
    var arr = dataurl.split(',');
    var mime = arr[0].match(/:(.*?);/)[1];
    var bstr = atob(arr[1]);
    var n = bstr.length;
    var u8arr = new Uint8Array(n);
    while (n--) {
        u8arr[n] = bstr.charCodeAt(n);
    }
    return new File([u8arr], filename, { type: mime });
}

// Sự kiện khi chọn ảnh mới trong phần sửa phòng
document.getElementById('editInputImage').addEventListener('change', function (e) {
    var files = e.target.files;
    for (var i = 0; i < files.length; i++) {
        var reader = new FileReader();
        reader.onload = function (event) {
            selectedImages.push(event.target.result);
            displaySelectedImages();
        };
        reader.readAsDataURL(files[i]);
    }
});

// Hàm hiển thị các ảnh đã chọn trong phần addImagePreview
function displayAddedImages() {
    var previewElement = document.getElementById('addImagePreviewContainer');
    previewElement.innerHTML = '';

    selectedImages.forEach(function (imageUrl, index) {
        var imageContainer = document.createElement('div');
        imageContainer.classList.add('image-container');

        var imageElement = document.createElement('img');
        imageElement.src = imageUrl;

        var removeButton = document.createElement('button');
        removeButton.classList.add('remove-button');
        removeButton.innerText = 'X';
        removeButton.addEventListener('click', function () {
            removeAddedImage(index);
        });

        imageContainer.appendChild(imageElement);
        imageContainer.appendChild(removeButton);
        previewElement.appendChild(imageContainer);
    });
}

// Hàm xóa ảnh khỏi phần addImagePreview
function removeAddedImage(index) {
    selectedImages.splice(index, 1);
    displayAddedImages();
}

// Sự kiện khi chọn ảnh mới trong phần thêm phòng
document.getElementById('addInputImage').addEventListener('change', function (e) {
    var files = e.target.files;
    for (var i = 0; i < files.length; i++) {
        var reader = new FileReader();
        reader.onload = function (event) {
            selectedImages.push(event.target.result);
            displayAddedImages();
        };
        reader.readAsDataURL(files[i]);
    }
});
function ThemPhong() {
    // Lấy các giá trị từ các trường input
    var maPhong = document.getElementById('inputFieldMaP').value;
    var maLoaiPhong = document.getElementById('inputFieldChonLP').value;
    var ngayTao = document.getElementById('inputFieldNgayTao').value;
    var giaTheoGio = document.getElementsByName('giatheogio')[0].value;
    var giaTheoNgay = document.getElementsByName('giatheongay')[0].value;
    var phuThuTraMuon = document.getElementsByName('phuthutramuon')[0].value;
    var soLuongNguoiLon = document.getElementsByName('soluonnguoilon')[0].value;
    var soLuongTreEm = document.getElementsByName('soluongtreem')[0].value;

    // Tạo FormData object để chứa dữ liệu form
    var formData = new FormData();

    // Thêm các giá trị vào FormData
    formData.append('maphong', maPhong);
    formData.append('maloaiphong', maLoaiPhong);
    formData.append('ngaytao', ngayTao);
   
    formData.append('soluongnguoilon', soLuongNguoiLon);
    formData.append('soluongtreem', soLuongTreEm);

    // Lấy danh sách các tệp tin ảnh đã chọn từ input[type="file"]
    var fileInput = document.getElementById('addInputImage');
    var files = fileInput.files;

    // Thêm danh sách các tệp tin ảnh vào FormData
    for (var i = 0; i < files.length; i++) {
        var file = files[i];
        formData.append('Imageurl', file);
    }

    // Gọi action "LuuAnh" và truyền FormData
    fetch('/Phong/LuuAnh', {
        method: 'POST',
        body: formData
    })
        .then(function (response) {
            if (response.ok) {
                // Xử lý khi gọi action thành công
                console.log('Action called successfully');
            } else {
                // Xử lý khi gọi action không thành công
                console.log('Failed to call action');
            }
        })
        .catch(function (error) {
            console.log('Error:', error);
        });
}
