using Lecture_no_21___Repository_Pattern__.Models;
using Lecture_no_21___Repository_Pattern__.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lecture_no_21___Repository_Pattern__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //creating objet of Student Repository to access methods which are present inside Student Reporsitory
            _studentRepository = new StudentRepository();
        }

        public IActionResult Index()
        {

            return View();
        }

        public List<StudentModel> getallstudents()
        {
            // To get data here from our repository we have to declare it first
            return _studentRepository.GetStudentModels();
        }

        public StudentModel getallstudentsbyid(int id)
        {
            // To get data here from our repository we have to declare it first
            return _studentRepository.GetStudentById(id);
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
