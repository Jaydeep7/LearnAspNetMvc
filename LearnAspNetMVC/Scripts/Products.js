﻿$(function () {
    console.log('Inside js......');
    console.log($("#frm").serialize());
    $("div.checkbox").click(function () {
        console.log('Inside function......');
        $.ajax({
            type: "POST",
            url: "/Home/Filter",
            datatype: "JSON",
            traditional: true,
            data: $("#frm").serialize(), //to pass from data to ajax call - it automatically binds model data to model
            
            //UpdateTargetId: "ItemsColleciton",
            //InsertionMode : "InsertionMode.Replace",
            success: function (data) {
                console.log('ajax success....');
                console.log('data is ' + data);
                $('#ItemsColleciton').html(data);

            },
            error: function () {
                console.log("ajax error....");
            }
        });

    });



});