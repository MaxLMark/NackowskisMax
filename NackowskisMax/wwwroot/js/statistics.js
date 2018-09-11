$(document).ready(function () {

    $('#js-myAuctions').click(function () {
        var date = $('#js-pickMonth').find('input').val();
        console.log(date);
        $.ajax({
            type: "GET",
            url: '/Admin/MyAuctions/' + date,
            success: function (result) {
                // the result is the returned html from the partial view
                $('.js-auctionList').html(result);
            },
        });
    });

    $('#js-allAuctions').click(function () {
        var date = $('#js-pickMonth').find('input').val();
        $.ajax({
            type: "GET",
            url: '/Admin/AllAuctions/' + date,
            success: function (result) {
                // the result is the returned html from the partial view
                $('.js-auctionList').html(result);
            }
        });
    });

    $('#js-pickMonth').datetimepicker({
        useCurrent: true,
        format: "YYYY-MM"
    });
});