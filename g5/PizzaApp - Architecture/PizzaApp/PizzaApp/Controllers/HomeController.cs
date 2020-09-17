using Microsoft.AspNetCore.Mvc;

namespace PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
