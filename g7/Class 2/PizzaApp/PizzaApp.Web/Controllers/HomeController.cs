using Microsoft.AspNetCore.Mvc;

namespace PizzaApp.Web.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet("Index")]
        public IActionResult IndexPage()
        {
            return View("Home");
        }

        [HttpGet("About")]
        public IActionResult AboutPage()
        {
            return View("About");
        }

        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
