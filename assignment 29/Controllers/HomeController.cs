using Microsoft.AspNetCore.Mvc;

namespace assignment_29.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewResult view = new ViewResult();

            return View();  //helper method
        }

        public IActionResult AboutUs() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
