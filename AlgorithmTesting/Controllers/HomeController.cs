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
            var NumberOfTimesToRun = 50;
            var startArraySize = 5000;
            var maxArraySize = 100000;
            var incrementSize = 5000;
            IDictionary<int, double> result = FunctionTesting.SpeedTest(StandardLibraryFunctions.ReverseMethod, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun);
            IDictionary<int, double> result2 = FunctionTesting.SpeedTest(StandardLibraryFunctions.SortMethod, startArraySize, maxArraySize, incrementSize, NumberOfTimesToRun);

            ViewBag.result = result;
            ViewBag.result2 = result2;
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
