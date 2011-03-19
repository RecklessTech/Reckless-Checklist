/// <reference path="jquery-1.4.4-vsdoc.js"/>

$(document).ready(function () {
    if (window.changingTask == true) {
        return false;
    }



    //Task Click Event
    $('#taskList li').live('click', function (evt) {
        window.changingTask = true;


        var taskId = this.id.substring(7);
        var that = this;

        $.post('/Home/ToggleTask', { taskId: taskId }, function (response) {
            if (response.Completed) {
                $(that).removeClass(response.OldStatus);
                $(that).addClass(response.NewStatus);
            }
            window.changingTask = false;

        }, "json");


    });

    //Hover Event
    $('#taskList li').hover(function () {
        $(this).toggleClass("ActiveHover");
    });

});    

