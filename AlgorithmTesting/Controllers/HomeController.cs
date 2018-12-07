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
        public IActionResult RunTest(int startArraySize, int maxArraySize, int incrementSize, int NumberOfTimesToRun, string ArrayType, string AverageType, string testChoice1, string testChoice2, string testChoice3, string testChoice4)
        {
            string[] inputTests = new string[]
            {
                testChoice1,
                testChoice2,
                testChoice3,
                testChoice4
            };
            int numberOfTests = 0;

            foreach (string i in inputTests)
            {
                if (i != "none")
                {
                    numberOfTests++;

                }
            }
            AvaialbleFunctions functions = new AvaialbleFunctions();

            TestResult[] tests = new TestResult[numberOfTests];

            int testNumber = 0;
            if (testChoice1 != "none")
            {
                tests[testNumber] = new TestResult(testChoice1, FunctionTesting.SpeedTest(functions.Functions[testChoice1], startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType));
                testNumber++;
            }
            if (testChoice2 != "none")
            {
                tests[testNumber] = new TestResult(testChoice2, FunctionTesting.SpeedTest(functions.Functions[testChoice2], startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType));
                testNumber++;
            }
            if (testChoice3 != "none")
            {
                tests[testNumber] = new TestResult(testChoice3, FunctionTesting.SpeedTest(functions.Functions[testChoice3], startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType));
                testNumber++;
            }
            if (testChoice4 != "none")
            {
                tests[testNumber] = new TestResult(testChoice4, FunctionTesting.SpeedTest(functions.Functions[testChoice4], startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun, ArrayType, AverageType));
                testNumber++;
            }

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
