function doFirst() {
    document.getElementById("dropzone").ondragover = dragOver;
    document.getElementById("dropzone").ondrop = dropped;

}
function dragOver(e) {
    e.preventDefault();
}
function dropped(e) {
    e.preventDefault();
    let file = e.dataTransfer.files[0];
    // console.log(file);
    document.getElementById("filename").innerHTML = file.name;
    let readFile = new FileReader()
    readFile.readAsDataURL(file)
    readFile.addEventListener('load', function () {
        let image = document.getElementById('image')
        image.src = readFile.result;
        image.style.maxWidth = "500px";
        image.style.maxHeight = "500px";
    })
}
window.addEventListener('load', doFirst)
