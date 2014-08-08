//load the DOM into jQuery
$(document).ready(function () {
    //after the DOM loaded, then execute this code

    //when we click on homeLink, run some code
    $('.homeLink').on('click', function () {
        //use a .get request to update the data
        // data-url attribute
        var url = $(this).data('url');
        //use a .get request to update our content
        $.get(url, function (data) {
            //update the content div with the
            //data returned from our GET request
            $('#content').html(data);
        });
    });

    $('.aboutLink').on('click', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {
            $('#content').html(data);
        });
    });
    $('.workLink').on('click', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {
            $('#content').html(data);
        });
    });

    $('.contact').on('click', function () {
        var url = $(this).data('url');
        $.get(url, function (data) {
            $('#content').html(data);
        });
    });

});