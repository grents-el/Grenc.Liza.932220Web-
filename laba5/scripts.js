var openedBlock;
var fog;
var isFogEnable;

function openWin(name) {
    openedBlock = document.getElementById(name);
    openedBlock.style.display = "block";
    fog = document.getElementById("fogBlock");
    fog.style.display = "block";
    isFogEnable = true;
};

function closeWin() {
    if (isFogEnable) {
        fog.style.display = "none";
        isFogEnable = false;
    }
    openedBlock.style.display = "none";
}