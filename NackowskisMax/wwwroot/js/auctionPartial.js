if (winningBidAvg > 0) {
    $(document).ready(function () {
        data = [{
            "LaneTitle": "Winning bids",
            "Count": winningBidAvg
        }, {
            "LaneTitle": "Estimates",
            "Count": estimateAvg
        }, {
            "LaneTitle": "Difference",
            "Count": difference
        }];

        $("#GateChartHolder").html("<canvas id=\"gateChart\" width=\"400\" height=\"200\"></canvas>");
        var ctx = document.getElementById("gateChart");
        var vlbl = [];
        var vcount = [];
        $.each(data, function (k, v) {
            vlbl.push(v.LaneTitle);
            vcount.push(v.Count);
        });

        var myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: vlbl,
                datasets: [{
                    label: 'Count',
                    data: vcount,
                    borderWidth: 1,
                    backgroundColor: ["#2ECC71", "#1ABC9C", "#F39C12"]
                }]
            },
            options: {
                scales: {
                    yAxes: [{
                        type: 'logarithmic',
                        ticks: {
                            beginAtZero: true,
                            callback: function (tick, index, ticks) {
                                return tick.toLocaleString();
                            },
                            min: 0
                        }
                    }]
                }
            }
        });
    });
}