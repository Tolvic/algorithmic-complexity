using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlgorithmTesting.Models;
using Newtonsoft.Json;

namespace AlgorithmTesting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int NumberOfTimesToRun = 10;
            int startArraySize = 50;
            int maxArraySize = 1000;
            int incrementSize = 50;
            string ArrayType = "random";
            string AverageType = "median";

            TestResult[] tests = new TestResult[] {
                new TestResult("Example Test", FunctionTesting.SpeedTest(DuplicateAlgorithm.FindDuplicateNumbers, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType)),
                new TestResult("Example Test 2", FunctionTesting.SpeedTest(DuplicateAlgorithm.FindDuplicateNumbers, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType))
                };

            string json = JsonConvert.SerializeObject(tests);

            ViewBag.json = json;
            ViewBag.tests = tests;
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
