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
            var result = FunctionTesting.SpeedTest(FunctionTesting.TestFuction, 1, 10, 1);
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
