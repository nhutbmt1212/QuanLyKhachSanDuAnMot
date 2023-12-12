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

//document.getElementById('btn_Sua').addEventListener('click', function () {
//    document.getElementById('myFormEdit').style.display = "block";

//});
function CloseFormEdit() {
    document.getElementById('myFormEdit').style.display = "none";

}

document.getElementById('btn_themPhong').addEventListener('click', hidePopUpEditNhanVien);

function hidePopUpEditNhanVien() {
    document.getElementById('myFormEdit').style.display = 'none';
}

document.getElementById('btn_Sua').addEventListener('click', hidePopUpAddNhanVien);

function hidePopUpAddNhanVien() {
    document.getElementById('myForm').style.display = 'none';
    btn_them.style.display = 'block';

}

var getValue = document.querySelector('#table_detail');

getValue.addEventListener('click', function (e) {
    const cell = e.target.closest('td');
    if (!cell) { return; }
    const row = cell.parentElement;

    var maphong = row.dataset.maPhong;
    var maLoaiPhong = row.dataset.maLoaiPhong;
    var ngayTao = row.dataset.ngayTao;
    var tinhTrang = row.dataset.tinhTrang;

    document.querySelector('.maphongedit').value = maphong;
    document.querySelector('.maloaiphongedit').value = maLoaiPhong;
    document.querySelector('.tinhtrangedit').value = tinhTrang;

  
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
////thêm

var arrLinkAnh = [];
var arrImagePreviewing = [];

function XuLyAnhDaChon(input) {
    const fileAnhChon = input.files;
    for (let i = 0; i < fileAnhChon.length; i++) {
        const file = fileAnhChon[i];
        const LinkAnh = URL.createObjectURL(file);
        arrLinkAnh.push(LinkAnh);
        arrImagePreviewing.push(file);
    }
    capNhatAnhPreviewThemPhong();
}

function capNhatAnhPreviewThemPhong() {
    const previewContainer = document.getElementById('addImagePreviewContainer');
    previewContainer.innerHTML = "";
    for (let i = 0; i < arrLinkAnh.length; i++) {
        const UrlAnh = arrLinkAnh[i];
        const ImagePreviewing = arrImagePreviewing[i];
        const imageContainer = document.createElement('div');
        imageContainer.className = "image-containerAddPhong";

        const imgElement = document.createElement('img');
        imgElement.src = UrlAnh;
        imgElement.alt = "Image Preview";

        // Xóa ảnh
        const nutXoa = document.createElement('button');
        nutXoa.textContent = "Xóa";
        nutXoa.className = "XoaAnh_ThemPhong";
        nutXoa.type = "button";

        nutXoa.addEventListener('click', function () {
            XoaAnhThemPhong(i);
        });

        imageContainer.appendChild(imgElement);
        imageContainer.appendChild(nutXoa);
        previewContainer.appendChild(imageContainer);
    }
}

function XoaAnhThemPhong(index) {
    arrLinkAnh.splice(index, 1);
    arrImagePreviewing.splice(index, 1);
    capNhatAnhPreviewThemPhong();
}
$("#myFormContainer").on("submit", function (event) {
    event.preventDefault(); // Ngăn chặn hành vi mặc định của form
    ThemPhong();
});
function ThemPhong() {
    var maphong = $("#inputFieldMaP").val();
    var maloaiphong = $("#inputFieldChonLP").val();
    var ngaytao = $("#inputFieldNgayTao").val();

    var formData = new FormData();

    formData.append("MaPhong", maphong);
    formData.append("MaLoaiPhong", maloaiphong);
    formData.append("NgayTao", ngaytao);

    if (arrImagePreviewing.length > 0) {
        for (var i = 0; i < arrImagePreviewing.length; i++) {
            formData.append("Imageurl", arrImagePreviewing[i]);
        }
    }

    $.ajax({
        type: "POST",
        url: "/Phong/LuuPhongVaAnh",
        data: formData,
        processData: false,
        contentType: false,
        success: function (result) {
            console.log(result);
            arrLinkAnh = [];
            arrImagePreviewing = [];
            location.reload();
        },
        error: function (error) {
            console.error(error);
        }
    });
}


/*sửa*/
var arrLinkAnhEdit = [];
var arrImagePreviewingEdit = [];

function HienThiAnhSuaPhong(MaPhong) {
    document.getElementById('myFormEdit').style.display = "block";

    $.ajax({
        type: 'GET',
        url: '/Phong/GetImages',
        data: { MaPhong: MaPhong },
        success: function (LinkAnhs) {
            const previewContainer = document.getElementById('editImagePreviewContainer');
            previewContainer.innerHTML = "";
            arrImagePreviewingEdit = [];

            for (let i = 0; i < LinkAnhs.length; i++) {
                var LinkAnh = LinkAnhs[i];
                arrImagePreviewingEdit.push(LinkAnh);
                appendImagePreview(LinkAnh, i);
            }
        },
        error: function (error) {
            // Handle error
        }
    });
}

function XuLyAnhDaChonSuaPhong(input) {
    const fileAnhChon = input.files;
    for (let i = 0; i < fileAnhChon.length; i++) {
        const file = fileAnhChon[i];
        const LinkAnh = URL.createObjectURL(file);
        arrLinkAnhEdit.push(LinkAnh);
        arrImagePreviewingEdit.push(file);
        appendImagePreview(LinkAnh, arrImagePreviewingEdit.length - 1);
    }
}

function appendImagePreview(LinkAnh, index) {
    var imageFileExtensions = ['jpg', 'jpeg', 'png', 'gif', 'bmp', 'webp'];
    


    const previewContainer = document.getElementById('editImagePreviewContainer');
    const imageContainer = document.createElement('div');
    imageContainer.className = "image-containerEditPhong";

    const imgElement = document.createElement('img');
    var fileExtension = LinkAnh.split('.').pop().toLowerCase();
    if (imageFileExtensions.includes(fileExtension)) {
        imgElement.src = '/UploadImage/' + LinkAnh;
    } else {
        imgElement.src =  LinkAnh;
    }
    console.log(LinkAnh);
    imgElement.alt = "Image Edit Preview";

    const nutXoa = document.createElement('button');
    nutXoa.textContent = "Xóa";
    nutXoa.className = "XoaAnh_SuaPhong";
    nutXoa.type = "button";

    nutXoa.addEventListener('click', function () {
        XoaAnhSuaPhong(index);
    });

    imageContainer.appendChild(imgElement);
    imageContainer.appendChild(nutXoa);
    previewContainer.appendChild(imageContainer);
}

function capNhatAnhPreviewSuaPhong() {
    const previewContainer = document.getElementById('editImagePreviewContainer');
    previewContainer.innerHTML = "";

    for (let i = 0; i < arrImagePreviewingEdit.length; i++) {
        const ImagePreviewing = arrImagePreviewingEdit[i];
        appendImagePreview(typeof ImagePreviewing === 'string' ? ImagePreviewing : URL.createObjectURL(ImagePreviewing), i);
    }
}

function XoaAnhSuaPhong(index) {

    arrImagePreviewingEdit.splice(index, 1);
    capNhatAnhPreviewSuaPhong();
}


$("#myFormContainerEdit").on("submit", function (event) {
    event.preventDefault(); 
    SuaPhong();
});
function SuaPhong() {
    var maphong = $(".maphongedit").val();
    var maloaiphong = $("#inputEditChonLP").val();
    var ngaytao = $("#inputEditNgayTao").val();

    var formData = new FormData();

    formData.append("MaPhong", maphong);
    formData.append("MaLoaiPhong", maloaiphong);
    formData.append("NgayTao", ngaytao);

    if (arrImagePreviewingEdit.length > 0) {
        for (var i = 0; i < arrImagePreviewingEdit.length; i++) {
            formData.append("Imageurl", arrImagePreviewingEdit[i]);
        }
    }

    $.ajax({
        type: "POST",
        url: "/Phong/SuaPhong",
        data: formData,
        processData: false,
        contentType: false,
        success: function (result) {
            console.log(result);
            arrLinkAnhEdit = [];
            arrImagePreviewingEdit = [];
            location.reload();
        },
        error: function (error) {
            console.error(error);
        }
    });
}


