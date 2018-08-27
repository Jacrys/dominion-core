// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.body.innerHTML = document.body.innerHTML.replace(/:-1:/g, '<i class="fa fa-thumbs-down"></i>');
document.body.innerHTML = document.body.innerHTML.replace(/:+1:/g, '<i class="fa fa-thumbs-up"></i>');

$(function () {
    $('[data-toggle="tooltip"]').tooltip();
    $('#issueModal').modal(
        {
            backdrop: true,
            keyboard: true,
            show: false,
            remote: false
        });
});

$('#issueModal').on('show.bs.modal', function () {
    $('#myInput').focus();
});