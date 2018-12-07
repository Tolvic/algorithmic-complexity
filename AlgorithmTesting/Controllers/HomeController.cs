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
                new TestResult("Example Test 2", FunctionTesting.SpeedTest(DuplicateAlgorithm.FindDuplicateNumbers, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType)),
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

            AvaialbleFunctions functions = new AvaialbleFunctions();

            ViewBag.AvailableFunctions = functions.FunctionNames;

            return View();
        }

        [HttpPost]
        public IActionResult RunTest(string testChoice, int startArraySize, int maxArraySize, int incrementSize, int NumberOfTimesToRun, string ArrayType, string AverageType)
        {
            AvaialbleFunctions functions = new AvaialbleFunctions();

            TestResult[] tests = new TestResult[]
                {
                    new TestResult(testChoice, FunctionTesting.SpeedTest(functions.Functions[testChoice], startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType))
                };

            string json = JsonConvert.SerializeObject(tests);

            ViewBag.json = json;
            ViewBag.tests = tests;
            ViewBag.timesRan = NumberOfTimesToRun;

            return View("~/Views/Home/Index.cshtml");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
