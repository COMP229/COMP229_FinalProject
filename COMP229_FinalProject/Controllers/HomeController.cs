using System.Web.Mvc;

namespace COMP229_FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "What is Banada?";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "How to contact Banana?";

            return View();
        }
        public IActionResult myPad()
        {
            ViewData["Message"] = "How to contact Banana?";

            return View();
        }
        public IActionResult myWatch()
        {
            ViewData["Message"] = "How to contact Banana?";

            return View();
        }
    }
}
