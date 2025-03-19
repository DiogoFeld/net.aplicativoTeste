let button = document.getElementById("menuHeaderButton");
let sideBar = document.getElementById("sideBar");

button.onclick = function () { openMenu() };


function openMenu() {
    if (sideBar.classList.contains("sidebarClose"))
        sideBar.classList.remove("sidebarClose");
    else
        sideBar.classList.add("sidebarClose");
}


        /*MODALS*/
function openModal() {
    document.getElementById('modalOverlay').classList.add('show');
}
function closeModal() {
    document.getElementById('modalOverlay').classList.remove('show');
}


function openModalAtendimento() {
    document.getElementById('modalOverlayAtendimento').classList.add('show');
}
function closeModalAtendimento() {
    document.getElementById('modalOverlayAtendimento').classList.remove('show');
}
