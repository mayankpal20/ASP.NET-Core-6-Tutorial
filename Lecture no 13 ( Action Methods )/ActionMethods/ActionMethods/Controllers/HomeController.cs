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

        //For Partial Layout
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Address()
        {
            return View();
        }
    }
}
