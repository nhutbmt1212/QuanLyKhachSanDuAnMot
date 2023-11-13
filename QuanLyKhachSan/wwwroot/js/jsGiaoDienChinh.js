const allSideMenu = document.querySelectorAll('#sidebar .side-menu.top li a');

allSideMenu.forEach(item => {
	const li = item.parentElement;

	item.addEventListener('click', function () {
		allSideMenu.forEach(i => {
			i.parentElement.classList.remove('active');
		})
		li.classList.add('active');
	})
});




// TOGGLE SIDEBAR
const menuBar = document.querySelector('#content nav .bx.bx-menu');
const sidebar = document.getElementById('sidebar');

menuBar.addEventListener('click', function () {
	sidebar.classList.toggle('hide');
})







//if (window.innerWidth < 768) {
//	sidebar.classList.add('hide');
//} else if (window.innerWidth > 576) {
//	searchButtonIcon.classList.replace('bx-x', 'bx-search');
//	searchForm.classList.remove('show');
//}


//window.addEventListener('resize', function () {
//	if (this.innerWidth > 576) {
//		searchButtonIcon.classList.replace('bx-x', 'bx-search');
//		searchForm.classList.remove('show');
//	}
//})

//add attribute when the width < 768px

function thuGonNav() {
	var handleBtn = document.getElementById('HandleButton');
		var element = document.getElementById('sidebar');
	if (window.innerWidth < 769) {
		element.setAttribute('class', 'hide');
		handleBtn.style.display = 'none';

	}
	else {
		handleBtn.style.display = 'block';
		element.removeAttribute('class');
	}
}
window.onload = thuGonNav;
window.onresize = thuGonNav;












	
