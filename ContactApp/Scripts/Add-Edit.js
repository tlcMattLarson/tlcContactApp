$().ready(function () {
    //form validation
    $("#mainform").validate();
    $("#FirstName").rules("add", { required: true});
    $("#LastName").rules("add", { required: true});
    $("#Phone").rules("add", { required: true, maxlength: 10 });
    $("#Email").rules("add", { required: true, email: true });
})