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
