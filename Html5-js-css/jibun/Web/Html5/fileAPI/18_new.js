function doFirst() {
    document.getElementById("dropzone").ondragover = dragOver;
    document.getElementById("dropzone").ondrop = dropped;

}
function dragOver(e) {
    e.preventDefault();
}
function dropped(e) {
    e.preventDefault();
    let files = e.dataTransfer.files;
    // console.log(file);
    let readFile = new FileReader();
    for (let i = 0; i < files.length; i++) 
    {
        readFile.readAsDataURL(files[i]);
        readFile.addEventListener('load', function () {
            // 動態新增<img>
            // 1 建立標籤
            let image =document.createElement("img");
            // 2將該標籤屬性方法先寫好
            image.src=readFile.result;
            //找爸爸加進去
            dropzone.appendChild(image);
            // dropzone.insertBefore(image,dropzone.firstChild)
            // dropzone.replaceChild(dropzone.firstChild)
        })
    }
}

window.addEventListener('load', doFirst)
