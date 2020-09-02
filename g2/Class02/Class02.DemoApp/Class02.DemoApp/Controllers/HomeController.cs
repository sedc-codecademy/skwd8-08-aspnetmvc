using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class02.DemoApp.Models;

namespace Class02.DemoApp.Controllers
{
    //[Route("App")] // https://localhost:port/App/Start
    public class HomeController : Controller
    {
        //[Route("Start")] // https://localhost:port/App/Start
        public IActionResult Index()
        {
            return View();
        }

        //[Route("About")] // // https://localhost:port/App/About
        public IActionResult About()
        {
            return View();
        }

        //[Route("GoHome")] // https://localhost:port/App/GoHome
        public IActionResult GoHome() // returns a RedirectToAction to the same controller
        {

            return RedirectToAction("Contact", new { personName = "Dejan" });
        }

        //[Route("Contact/{personName}")] // https://localhost:port/App/Contact/YourNameHere
        public IActionResult Contact(string personName)
        {
            ViewData["Message"] = $"Hello {personName}";

            return View();
        }
    }
}
