using Lecture_no_17___ViewData__.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lecture_no_17___ViewData__.Controllers
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
            //ViewData
            ViewData["kuchbhi"] = "Agaya Swad";
            ViewData["kuchbhi1"] = "Ha aagaya";
            ViewData["kuchbhi2"] = 232;
            string[] arr = {"name1" , "name2" , "name3"};
            ViewData["kuchbhi3"] = arr;

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
