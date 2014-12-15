$(document).ready(function () {
    $("body").on("click", ".ajax-link", function () {
        var url = $(this).data("url");
        $(".btn-primary").removeClass("active");
        $(this).addClass("active");

        $.get(url, function (data) {
            $(".content").html(data);
        });
    });

    $("body").on("submit", ".ajax-form", function (event) {
        // event is the act of submitting the form
        // preventing the default behavior, in this case not allowing the form to submit normally
        event.preventDefault();

        // make the AJAX POST request
        // first param: url to post to
        // second param: sends the input field data
        // third param: what to do with the response
        $.post($(this).data("posturl"), $(this).serialize(), function (data) {
            // update our content area
            $(".content").html(data);
        });
    });
});