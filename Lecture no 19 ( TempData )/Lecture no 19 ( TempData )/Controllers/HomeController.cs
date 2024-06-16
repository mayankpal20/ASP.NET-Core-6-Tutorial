using Lecture_no_19___TempData__.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lecture_no_19___TempData__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["key1"] = "This is a ViewData";
            ViewBag.vibag = "This is a ViewBag";
            TempData["key2"] = "This is a TempData";
            TempData["key3"] = new List<string>()
            {
                "Mayank" , "Rudra" , "Omkara"
            };
            TempData.Keep();
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
