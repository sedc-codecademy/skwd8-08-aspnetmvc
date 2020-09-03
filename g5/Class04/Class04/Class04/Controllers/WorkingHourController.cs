using System.Linq;
using Class04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class04.Controllers
{
    public class WorkingHourController : Controller
    {
        public IActionResult Index()
        {
            return View(DataHelper.People);
        }
    }
}
