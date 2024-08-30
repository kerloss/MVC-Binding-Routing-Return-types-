using Microsoft.AspNetCore.Mvc;

namespace assignment_29.Controllers
{
    //if used MVC inherit from Controller but if project APIs inherit from BaseController
    public class MovieController : Controller
    {
        //Action --> public non-static func  => Movie/GetMovie
        public IActionResult GetMovie(int id, string name, Employee emp)
        {
            //IActionResult interface that return all special type of action implement this interface 

            //ContentResult result = new ContentResult();
            //result.Content = $"Movie wit id {id}";
            //result.ContentType = "object/pdf";
            //result.StatusCode = 200;

            return Content($"Movie wit id {id}", "txt/html");
        }

        // => BaseUrl/Movie/Hamada  method : post   default verb => [HttpGet]
        //[ActionName("Hamada")]
        //[HttpPost]
        //[AcceptVerbs("Post","Get")]
        public IActionResult Index()
        {
            //RedirectResult redirectResult = new RedirectResult("https://localhost:44367/Movie/GetMovie/10");
            //return redirectResult;
            //return Redirect("https://localhost:44367/Movie/GetMovie/10");
            return RedirectToAction(nameof(GetMovie), new { id = 10 }); //to make redirect with dynamic basseurl

            //return RedirectToRoute("default", new { controller = "Product", action = "GetProduct", id = 100 });
        }

        public ViewResult Hamada()
        {
            return View();
        }
    }
}
