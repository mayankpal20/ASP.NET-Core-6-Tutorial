using Lecture_no_20___Model__.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lecture_no_20___Model__.Controllers
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
            var students = new List<StudentModel> { 
            
                new StudentModel{Rollno=1 , Name="Mayank" , Gender="Male"},
                new StudentModel{Rollno=2 , Name="Omkara" , Gender="Male"},
                new StudentModel{Rollno=3 , Name="Rudra" , Gender="Male"}


            };
            ViewData["mystudents"] = students;
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
