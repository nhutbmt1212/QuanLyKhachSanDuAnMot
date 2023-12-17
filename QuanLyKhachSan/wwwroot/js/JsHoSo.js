
        var editingField = null;

        function editMode(fieldId) {
            if (editingField) {
                return;
            }

            editingField = fieldId;

            document.getElementById(fieldId + 'Item').classList.add('edit-mode');

            var currentValue = document.getElementById(fieldId).innerText;
            document.getElementById('editedValue_' + fieldId).value = currentValue;

            document.getElementById(fieldId + 'Item').querySelector('.edit-mode-input').style.display = 'inline-block';
            document.getElementById(fieldId + 'Item').querySelector('.btn.btn-success.edit-mode-input').style.display = 'inline-block';
            document.getElementById(fieldId + 'Item').querySelector('.btn.btn-secondary.edit-mode-input').style.display = 'inline-block';

            document.getElementById(fieldId + 'Item').querySelector('.display-mode a').style.display = 'none';
        }

function saveEdit(fieldId) {

            var editedValue = document.getElementById('editedValue_' + fieldId).value;
    document.getElementById(fieldId).innerText = editedValue;
    LuuThongTinHoSo();
            cancelEdit(fieldId);
            
        }

        function cancelEdit(fieldId) {
            document.getElementById(fieldId + 'Item').classList.remove('edit-mode');

            document.getElementById(fieldId + 'Item').querySelector('.edit-mode-input').style.display = 'none';
            document.getElementById(fieldId + 'Item').querySelector('.btn.btn-success.edit-mode-input').style.display = 'none';
            document.getElementById(fieldId + 'Item').querySelector('.btn.btn-secondary.edit-mode-input').style.display = 'none';
            document.getElementById('editedValue_' + fieldId).value = '';

            document.getElementById(fieldId + 'Item').querySelector('.display-mode a').style.display = 'inline-block';

            editingField = null;
        }

        document.getElementById('imageInput').addEventListener('change', function (event) {
            const input = event.target;
            const previewImage = document.getElementById('previewImage');

            const file = input.files[0];

            if (file) {
                const reader = new FileReader();

                reader.onload = function (e) {
                    previewImage.src = e.target.result;
                };

                reader.readAsDataURL(file);
            }
            console.log(file);
        });

$('#imageInput').change(function () {
    LuuThongTinHoSo();
});

function LuuThongTinHoSo() {
    var TenNhanVien = $('#editedValue_employeeName').val();
    var SoDienThoai = $('#editedValue_phoneNumber').val();
    var CCCD = $('#editedValue_cccd').val();
    var Email = $('#editedValue_email').val();
    var GioiTinh = $('#editedValue_gender').val();
    var DiaChi = $('#editedValue_address').val();
    var MatKhau = $('#editedValue_password').val();
    var AnhNhanVien = $('#imageInput').get(0).files[0]; // Lấy file ảnh từ input

    var data = new FormData();
    data.append('TenNhanVien', TenNhanVien);
    data.append('SoDienThoai', SoDienThoai);
    data.append('CCCD', CCCD);
    data.append('Email', Email);
    data.append('GioiTinh', GioiTinh);
    data.append('DiaChi', DiaChi);
    data.append('MatKhau', MatKhau);
    data.append('AnhNhanVien', AnhNhanVien); // Thêm file ảnh vào FormData

    $.ajax({
        type: 'POST',
        url: '/NhanVien/LuuThongTinHoSo',
        data: data,
        processData: false, // Đặt processData và contentType thành false để jQuery không xử lý dữ liệu
        contentType: false,
        success: function () {
            location.reload();
        },
        error: function () {
            console.log('lỗi');
        }
    });
}
