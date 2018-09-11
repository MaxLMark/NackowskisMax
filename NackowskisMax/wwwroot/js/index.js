$(document).ready(function () {

    if (currUser !== '') {
        //doo it
    }

    // Setup - add a text input to each footer cell
    $('#example tfoot th').each(function () {
        var title = $(this).text();
        if (title === "Titel") {
            $(this).html('<input type="text" placeholder="Search title" />');
        } else if (title === "Beskrivning") {
            $(this).html('<input type="text" placeholder="Search description" />');
        }
    });


    var table = $('#example').DataTable();
    $(".dataTables_filter").hide();

    // Apply the search
    table.columns().every(function () {
        var that = this;

        $('input', this.footer()).on('keyup change', function () {
            if (that.search() !== this.value) {
                that
                    .search(this.value)
                    .draw();
            }
        });
    });

    $('th input').keyup(function () {
        $('.js-inActiveAuction').removeClass('d-none');
        $('tr.selected').removeClass("selected");
        $('#js-editAuction').addClass("disabled");
        $('#js-deleteAuction').addClass("disabled");
        $('#js-showBids').addClass("disabled");

    });

    $('#example tbody').on('click', 'tr', function () {
        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
            $('#js-editAuction').addClass("disabled");
            $('#js-deleteAuction').addClass("disabled");
            $('#js-showBids').addClass("disabled");
        }
        else {
            var items = $(this).data("item");

            table.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
            $('#js-showBids').removeClass("disabled");
            $('#newAuction').val($(this).closest('tr').children('td:first').text());
            $('#deleteAuction').val($(this).closest('tr').children('td:first').text());
            if (isAdmin === 'True' || currUser === items.SkapadAv) {
                $('#js-editAuction').removeClass("disabled");

                $('#js-deleteAuction').removeClass("disabled");
            } else {
                $('#js-deleteAuction').addClass("disabled");
            }

            //var items = $(this).data("item");
            //console.log(items.Titel);
        }
    });

    //EDIT AUCTION
    $("#js-editAuction").on('click', function () {
        var items = table.$('tr.selected').data("item");
        var startDate = items.StartDatum;
        var endDate = items.SlutDatum;
        var url = $(this).attr('data-url');

        //endDate = endDate.substring(0, endDate.indexOf('T'));
        //startDate = startDate.substring(0, startDate.indexOf('T'));

        //console.log(items);

        //Ändra modal titlen
        $('#modalTitle').text("Edit Auction");

        //Ge inputsen rätt värden
        $('#js-auctionForm').attr('action', url);
        $('#js-auctionId').val(parseInt(items.AuktionID));
        $("#js-auctionTitel").val(items.Titel);
        $("#js-auctionDescription").val(items.Beskrivning);
        $("#js-startDateInput").val(startDate);
        $("#js-endDateInput").val(endDate);
        $('#js-auctionEstimate').val(parseInt(items.Utropspris));

    });

    //CREATE NEW AUCTION
    $("#js-createAuction").on('click', function () {

        var url = $(this).attr('data-url');
        //Ändra modal titlen
        $('#modalTitle').text("Create Auction");
        $('#js-auctionForm').attr('action', url);
        $('#js-auctionId').val('');
        $("#js-auctionTitel").val('');
        $("#js-auctionDescription").val('');
        $("#js-startDate").val('');
        $("#js-endDate").val('');
        $('#js-auctionEstimate').val('');

    });

    //CREATE NEW BID
    $('#js-showBids').on('click', function () {
        $("ul").empty();
        $('#js-bidInput').removeClass('d-none');
        $('#js-bidSubmit').removeClass('d-none');
        $('#js-bidSubmit').addClass("disabled");
        $('#js-highestBidLabel').text("No bids yet!")
        var items = table.$('tr.selected').data("item");
        var url = $(this).attr('data-url');
        if (items.OfferList.length > 0) {
            $('#js-highestBidLabel').text("Highest bid yet: ");
            $.each(items.OfferList, function (index, value) {

                $('#js-bidList').prepend('<li value="' + value.Summa + '"><p> Bid: ' + value.Summa + 'kr Bidder: ' + value.Budgivare + '</p></li>');

            });


            $("li p").first().addClass("redText");
            $("li").first().addClass("js-highestBid");
            if (table.$('tr.selected').hasClass("js-inActiveAuction")) {
                $('#js-highestBidLabel').text("The winning bid:");
                $('#js-bidInput').addClass('d-none');
                $('#js-bidSubmit').addClass('d-none');
                $('#js-bidList').find('li').slice(1).remove();
                $('#js-bidlist').prepend('<p> Winning bid of the auction: </p>');
            }
        };

        $('#js-createBidForm').attr('action', url);
        $('#js-auctionId').val(parseInt(items.AuktionID));
    });

    //Validering på inputen
    $('#js-bidInput').keyup(function () {
        //console.log($("#js-bidInput").val());

        var inputValue = $(this).val();
        var highestBid = $('.js-highestBid').first().val();

        if (inputValue > highestBid || highestBid === undefined) {
            $(this).addClass("isValidPrice");
            $(this).removeClass("notValidPrice");
            $('#js-bidSubmit').removeClass("disabled");
            $('#js-bidSubmit').removeAttr("disabled");

        } else if (highestBid >= inputValue) {
            $(this).addClass("notValidPrice");
            $(this).removeClass("isValidPrice");
            $('#js-bidSubmit').addClass("disabled");
            $('#js-bidSubmit').attr('disabled', "disabled");
        }

    });

    //DELETE AUCTION
    $("#js-deleteAuction").on('click', function () {
        var items = table.$('tr.selected').data("item");
        var url = $(this).attr('data-url');


        $('#js-deleteSubmit').removeAttr('disabled');
        $('#js-deleteWarning').text("This action cannot be undone");

        if (items.OfferList.length > 0) {
            $('#js-deleteWarning').text("You cannot delete an auction with existing bids!");
            $('#js-deleteSubmit').attr('disabled', 'disabled');
        }

        $('#js-auctionId').val(parseInt(items.AuktionID));
        //Ge urlen till modalens form
        $('#js-deleteAuctionForm').attr('action', url);
    });

    //DATETIME PICKER
    $('#js-startDate').datetimepicker({ format: "YYYY-MM-DD HH:mm" });
    $('#js-endDate').datetimepicker({
        useCurrent: false,
        format: "YYYY-MM-DD HH:mm"
    });
    $("#js-startDate").on("change.datetimepicker", function (e) {
        $('#js-endDate').datetimepicker('minDate', e.date);
    });
    $("#js-endDate").on("change.datetimepicker", function (e) {
        $('#js-startDate').datetimepicker('maxDate', e.date);
    });



});