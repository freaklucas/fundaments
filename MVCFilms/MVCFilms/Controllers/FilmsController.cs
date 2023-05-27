using Microsoft.AspNetCore.Mvc;

namespace MVCFilms.Controllers
{
    public class FilmsController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, string lastName, int age)
        {
            ViewData["name"] = name;
            ViewData["lastName"] = lastName;
            ViewData["age"] = 12;

            return View();
        }
    }
}
