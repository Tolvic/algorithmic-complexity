// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.







var json = $("#json").text();
var data = jQuery.parseJSON(json);
var backgroundColors = [
                'rgba(54, 162, 235, 0)',
                'rgba(255, 99, 132, 0)',
                'rgba(255, 159, 64, 0)',
                'rgba(153, 102, 255, 0)',
                'rgba(75, 192, 192, 0)',
                'rgba(255, 206, 86, 0)',
                'rgba(54, 162, 235, 0)'
            ];
var borderColors = [
                'rgba(54, 162, 235, 1)',
                'rgba(255, 99, 132, 1)',
                'rgba(255, 159, 64, 1)',
                'rgba(153, 102, 255, 1',
                'rgba(75, 192, 192, 1)',
                'rgba(255, 206, 86, 1',
                'rgba(54, 162, 235, 1)'
            ];

var allTimes = []; // contains arrays of times for each speed test
var times = []; // timings for a single test
var arraySizes = []; //array sizes
var methodNames = []; //Array of method names
var mydatasets = [];
var maxLength = Object.keys(data[0].TestResults).length;
var dataSet = [];

data.forEach(element => {

    methodNames.push(element.TestedMethodName);

    for (var k in element.TestResults){

        if (arraySizes.length < maxLength) {
            arraySizes.push(k);
        }


        times.push(element.TestResults[k]);
    }
    allTimes.push(times);
    times = [];
});

// Generate chart dataset looping through each function test received
for(var i = 0; i < methodNames.length; i++){
    dataSet.push({label: methodNames[i], 
            data: allTimes[i], 
            backgroundColor: backgroundColors[i], 
            borderColor: borderColors[i], 
            borderWidth: 1});
}



var options =  {


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
    };



var ctx = document.getElementById("myChart").getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: arraySizes,
        datasets: dataSet

    },
    options: options
});
    



