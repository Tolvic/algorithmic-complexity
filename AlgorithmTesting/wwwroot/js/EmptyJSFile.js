var testResults = $("#data").find('tr').map(function(){
    return [ $("td", this).map(function(){ return $(this).text();}).get() ];
}).get();
testResults.shift();
keys = testResults.map(x => x[0]);
values = testResults.map(x => x[1]);

var testResults2 = $("#data2").find('tr').map(function(){
    return [ $("td", this).map(function(){ return $(this).text();}).get() ];
}).get();
testResults2.shift();
values2 = testResults2.map(x => x[1]);

var ctx = document.getElementById("myChart").getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: keys,
        datasets: [{
            label: 'Method Name',
            data: values,
            backgroundColor: [
                'rgba(54, 162, 235, 0)',
                'rgba(255, 99, 132, 0.2)',
                'rgba(255, 159, 64, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(54, 162, 235, 0.2)'
            ],
            borderColor: [
                'rgba(54, 162, 235, 1)',
                'rgba(255,99,132,1)',
                'rgba(255, 159, 64, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(255, 206, 86, 1)'
            ],
            borderWidth: 1
        }, {
            label: 'Method2',
            data: values2,
            backgroundColor: [
                'rgba(255, 99, 132, 0)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 159, 64, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(54, 162, 235, 0.2)'
            ],
            borderColor: [
                'rgba(255,99,132,1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 159, 64, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(255, 206, 86, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: true,
        title: {
            display: true,
            text: 'Time to Execute Method'
        },
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero:true
                },
                scaleLabel: {
                    display: true,
                    labelString: 'Time (Nanoseconds)'
                  }
            }],
            xAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'Array Size'
                  }
            }]
        },
        legend: {
            display: true
        }
    }
});
