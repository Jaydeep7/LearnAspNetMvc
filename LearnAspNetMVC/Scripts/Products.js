$(function () {
    console.log('Inside js......');
    $(".Categories").click(function (e) {
        console.log('Inside function......');
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