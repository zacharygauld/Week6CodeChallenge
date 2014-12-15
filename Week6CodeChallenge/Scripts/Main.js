$(document).ready(function () {
    $("body").on("click", ".ajax-link", function () {
        var url = $(this).data("url");
        $(".btn-primary").removeClass("active");
        $(this).addClass("active");

        $.get(url, function (data) {
            $(".content").html(data);
        });
    });
});