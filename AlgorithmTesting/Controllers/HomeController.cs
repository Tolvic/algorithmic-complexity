using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlgorithmTesting.Models;

namespace AlgorithmTesting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var NumberOfTimesToRun = 10;
            var startArraySize = 50;
            var maxArraySize = 1000;
            var incrementSize = 50;
            var ArrayType = "random";
            var AverageType = "median";
            IDictionary<int, double> result = FunctionTesting.SpeedTest(DuplicateAlgorithm.TheBestDuplicateAlgorithm, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType);
            IDictionary<int, double> result2 = FunctionTesting.SpeedTest(DuplicateAlgorithm.FindDuplicateNumbers, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType);

            ViewBag.result = result;
            ViewBag.result2 = result2;
            ViewBag.timesRan = NumberOfTimesToRun;

            return View();
        }

        public IActionResult NewTest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RunTest(int startArraySize, int maxArraySize, int incrementSize, int NumberOfTimesToRun, string ArrayType, string AverageType)
        {
            IDictionary<int, double> result = FunctionTesting.SpeedTest(DuplicateAlgorithm.TheBestDuplicateAlgorithm, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType);
            ViewBag.result = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
