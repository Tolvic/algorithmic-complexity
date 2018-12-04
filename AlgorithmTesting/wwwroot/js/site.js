﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var testResults = $("#data").find('tr').map(function(){
    return [ $("td", this).map(function(){ return $(this).text();}).get() ];
}).get();
testResults.shift();
keys = testResults.map(x => x[0]);
values = testResults.map(x => x[1]);

var ctx = document.getElementById("myChart").getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: keys,
        datasets: [{
            label: 'Method Name',
            data: values,
            backgroundColor: [
                'rgba(54, 162, 235, 0.2)',
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
        }]
    },
    options: {
        maintainAspectRatio: false,
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
            display: false
        }
    }
});