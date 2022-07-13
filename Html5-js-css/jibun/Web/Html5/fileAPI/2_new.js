function doFirst() {
    document.getElementById('theFile').onchange = fileChange

    function fileChange() {
        let file = document.getElementById('theFile').files[0]
        let message = "";
        message += `File name: ${file.name}\n`
        message += `File name: ${file.name}\n`
        message += `File size: ${file.size} byte\n`
        message += `Last Modified: ${file.lastModifiedDate} \n`

        document.getElementById('fileInfo').value = message;
    }
}
window.addEventListener('load', doFirst)
