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
            IDictionary<int, double> result = FunctionTesting.SpeedTest(StandardLibraryFunctions.ReverseMethod, 5000, 100000, 5000, NumberOfTimesToRun);

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
