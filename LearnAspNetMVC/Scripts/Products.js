$(function () {
    console.log('Inside js......');
    $("div.checkbox").click(function () {
        console.log('Inside function......');
        $.ajax({
            type: "POST",
            url: "/Home/Products",
            //url: "/Home/Filter",
            success: function () {
                console.log("ajax successfull....");
            },
            error: function () {
                console.log("ajax error....");
            }
        });

    });

    

});