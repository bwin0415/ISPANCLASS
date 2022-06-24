// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function readURL(input, img) {
    if (input.files && input.files[0]) {
        let reader = new FileReader();
        reader.onload = (e) => {
            img.attr('src', e.target.result);
        }
        reader.readAsDataURL(input.files[0])
    }
}
// Write your JavaScript code.
