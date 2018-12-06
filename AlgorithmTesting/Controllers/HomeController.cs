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
            var NumberOfTimesToRun = 20;
            var startArraySize = 100000;
            var maxArraySize = 2000000;
            var incrementSize = 100000;
            var ArrayType = "sequential";
            var AverageType = "median";
            IDictionary<int, double> result = FunctionTesting.SpeedTest(StandardLibraryFunctions.ShuffleMethod, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType);
            IDictionary<int, double> result2 = FunctionTesting.SpeedTest(ShuffleAlgorithm.ShuffleArrayNonList, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType);
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
            ViewBag.timesRan = NumberOfTimesToRun;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
