using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlgorthmTesting.Models;

namespace AlgorthmTesting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var NumberOfTimesToRun = 10;
            IDictionary<int, double> result = FunctionTesting.SpeedTest(StandardLibraryFunctions.ReverseMethod, 10, 100, 10, NumberOfTimesToRun);

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
