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
var currentEditingPhongId = null;
function createImageContainer(url) {
    var imageContainer = $('<div class="image-container">');
    var img = $('<img>').attr('src', url);
    var deleteIcon = $('<span class="delete-icon">').text('X').click(function () {
        imageContainer.remove();
    });

    return imageContainer.append(img, deleteIcon);
}

function previewImages() {
    var input = $('#ImageUrl')[0];
    var addContainer = $('#addImagePreviewContainer');
    var editContainer = $('#editImagePreviewContainer');

    addContainer.html(''); // Clear the add container
    editContainer.html(''); // Clear the edit container

    if (input.files && input.files.length > 0) {
        for (var i = 0; i < input.files.length; i++) {
            var reader = new FileReader();

            reader.onload = function (e) {
                createImageContainer(e.target.result).appendTo(addContainer);
            };

            reader.readAsDataURL(input.files[i]);
        }
    }
}

function switchSection(section) {
    $('.add-section, .edit-section').hide();
    $('#addButton, #editButton').hide();

    if (section === 'add') {
        $('.add-section').show();
        $('#addButton').show();
    } else if (section === 'edit') {
        $('.edit-section').show();
        $('#editButton').show();
    }
}

$('#addButton').on('click', function (e) {
    e.preventDefault();
    switchSection('add');
});

function editImages(phongId) {
    currentEditingPhongId = phongId;

    // Set the images for preview
    $.get('/Phong/GetImages?phongId=' + phongId, function (data) {
        var container = $('#editImagePreviewContainer').html('');

        data.forEach(function (url) {
            createImageContainer("/UploadImage/" + url).appendTo(container);
        });

        // Show the "Sửa ảnh" button
        $('#editButton').show();
    });
}
$('.employee-info-column-button .dropdown .dropdown-menu a.dropdown-item').on('click', function () {
    var phongId = $(this).closest('tr').data('ma-phong');
    editImages(phongId);
});

$('#btn_Sua').on('click', function () {
    var phongId = $(this).closest('tr').data('ma-phong');
    editImages(phongId);
});

// Event handler for the "Sửa ảnh" button

$('#editButton').on('click', function () {
    saveEditedImages(currentEditingPhongId);
});

$('#ImageUrl').off('change').on('change', function (e) {
    e.preventDefault();
    previewImages();
});
function saveEditedImages(phongId) {
    var editedImageUrls = [];

    $('.image-container img').each(function () {
        editedImageUrls.push($(this).attr('src').replace('/UploadImage/', ''));
    });

    $.ajax({
        url: '/Phong/SuaAnh',
        type: 'POST',
        traditional: true,
        data: { phongId: phongId, editedImageUrls: editedImageUrls },
        success: function (response) {
            if (response.success) {
                alert('Images updated successfully.');
            } else {
                alert('Failed to update images. Please try again.');
            }

            $('.add-section, .edit-section').hide();
            $('#addButton, #editButton').hide().show();
        },
        error: function () {
            alert('An error occurred while updating images. Please try again.');
        }
    });
}