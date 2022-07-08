function doFirst() {
    document.getElementById('theFile').onchange = fileChange


}
function fileChange() {
    let file = document.getElementById('theFile').files[0]
    let message = "";
    message += `File name: ${file.name}\n`
    message += `File type: ${file.type}\n`
    message += `File size: ${file.size} byte\n`
    message += `Last Modified: ${file.lastModifiedDate} \n`

    document.getElementById('fileInfo').value = message;


    let readFile = new FileReader()
    readFile.readAsDataURL(file)
    readFile.addEventListener('load', function () {
        let myMovie = document.getElementById('myMovie')
        myMovie.src = readFile.result;
        // myMovie.controls = 'controls';
        myMovie.controls = true;
        myMovie.width = 536;

    })
}
window.addEventListener('load', doFirst)
