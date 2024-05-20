using Microsoft.AspNetCore.Mvc;

namespace ActionMethods.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string NewMethod()
        {
            return "AA gaya Swad";
        }
    }
}
