var elem;
var picture;

function setColumn(blockId, pictureId, blockWidth, pictureWidth, displayPicture) {
    elem = document.getElementById(blockId);
    elem.style.width = blockWidth;
    picture = document.getElementById(pictureId);
    picture.style.display = displayPicture;
    picture.style.width = pictureWidth;
}

function openOne(b1, enabledPicture, b2, disabledPicture) {
    setColumn(b1, enabledPicture, "850px", "600px", "block"); 
    setColumn(b2, disabledPicture, "50px", "600px", "none");
}

function openTwo(b1, b2, pic1, pic2) {
    setColumn(b1, pic1, "450px", "410px", "block");
    setColumn(b2, pic2, "450px", "410px", "block");
}