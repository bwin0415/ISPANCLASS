// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#CustomerId").bind("change", () => {
    UpdateOrders();
})
function UpdateOrders() {
    $.ajax({
        type: "GET",
        url: webroot +"/"+ CustomerId.value,
        //url: "/Customers/Orders/" + CustomerId.value,
    })
        .done((data) => { $("#Orders").html(data) })
        .fail((err) => { alert(err.responseText) });
}