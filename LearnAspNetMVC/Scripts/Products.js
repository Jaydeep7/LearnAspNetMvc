$(function () {
    console.log('Inside js......');
    $('.Categories').click(function (e) {
        console.log(this.id, $("#" + this.id).is(":checked"));
        $.ajax({
            type: "POST",
            url: "/Home/Products",
            success: function () {
                console.log("ajax successfull....");
            },
            error: function () {
                console.log("ajax error....");
            }
        });

    });

    

});