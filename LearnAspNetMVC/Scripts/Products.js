$(function () {
    console.log('Inside js......');
    $("div.checkbox").click(function () {
        console.log('Inside function......');
        $.ajax({
            type: "GET",
            //url: "/Home/Products",
            url: "/Home/Filter",
            //datatype: "JSON",
            //traditional : true,
            data: $("#frm").serialize(),
            UpdateTargetId: "ItemsColleciton",
            //InsertionMode : "InsertionMode.Replace",
            success: function () {
                console.log("ajax successfull....");
            },
            error: function () {
                console.log("ajax error....");
            }
        });

    });

    

});