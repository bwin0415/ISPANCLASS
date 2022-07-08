
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
    readFile.readAsText(file)
    readFile.addEventListener('load', function () {

        document.getElementById('fileContent').value = readFile.result;
    })
}
window.addEventListener('load', doFirst)
