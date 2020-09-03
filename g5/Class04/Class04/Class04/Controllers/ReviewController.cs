using Class04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class04.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View(DataHelper.People);
        }
    }
}
