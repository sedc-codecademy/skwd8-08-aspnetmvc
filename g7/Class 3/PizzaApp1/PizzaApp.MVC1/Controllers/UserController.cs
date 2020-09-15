using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaApp.MVC1.Models;
using PizzaApp.MVC1.Models.ViewModels;

namespace PizzaApp.MVC1.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult CreateView()
        
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateView(UserViewModel vm)
        {
            return RedirectToAction("GetUser",vm);
        }

        public IActionResult GetUser(UserViewModel vm)
        {
            return View(vm);
        }
    }
}