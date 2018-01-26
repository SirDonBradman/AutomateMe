$(document).ready(function () {

    $("#DeleteButton").click(function () {

        var records = [];
        $('.MultipleDelete').each(function (i, e) {
            if (e.checked) {
                records.push(e.getAttribute('name'));
            }
        });
        if (records.length == 0) {
            alert("Select atleast one record to delete");
        }
        else if (confirm("Are you sure you want to delete emoplyees with Ids " + records)) {
            console.log({ ids: records });

            $.post("/Employees/MultipleDelete", { ids: records }, function () {
                location.reload(true);
                alert('Selected Records are deleted\n' + records);
                records = [];

            });
        }
    });
});
