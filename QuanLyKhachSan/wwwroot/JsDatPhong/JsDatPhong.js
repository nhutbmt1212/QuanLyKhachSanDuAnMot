function showSearchBar(MaPhong) {
    document.getElementById("popupOverlay").style.display = "flex";
    console.log(MaPhong);
    var maPhong = document.getElementById('MaPhong_PopUp_DatPhong').innerText = MaPhong;
    $.ajax({
        url: '/DatPhong/LayThongTinPhong', // Replace with your controller and action names
        type: 'GET', // or 'POST' depending on your action method
        data: { maPhong: maPhong }, // Pass the maPhong parameter
        success: function (data) {
            // Handle success response
            console.log(data.tenLoaiPhong);
            document.getElementById('MaLoaiPhong_PopUpDatPhong').value = data.tenLoaiPhong;
        },
        error: function (error) {
            // Handle error response
            console.error(error);
        }
    });
}

function showForm() {
    var formPopup = document.getElementById("formPopup");
    formPopup.style.display = "block";

    var closeButton = document.createElement("i");
    closeButton.className = "fa fa-times close-icon";
    closeButton.onclick = function () {
        formPopup.style.display = "none";
    };

    formPopup.appendChild(closeButton);
}

function closeForm() {
    document.getElementById("formPopup").style.display = "none";
}

function closePopup() {
    document.getElementById("popupOverlay").style.display = "none";
}

function openPopupThanhToan() {
    document.getElementById("paymentPopup").style.display = "block";
    document.getElementById("overlayThanhToan").style.display = "block";
}

function closePopupThanhToan() {
    document.getElementById("paymentPopup").style.display = "none";
    document.getElementById("overlayThanhToan").style.display = "none";
}