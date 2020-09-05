using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Library.Models;

namespace SEDC.Library.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // return type: ViewResult 
        }

        public IActionResult ReturnIndex()
        {
            return View("Index"); // return type: ViewResult - returns View named Index.cshtml
        }

        public IActionResult About()
        {
            ViewData["Message"] = "It's our about page."; // Dictionary sending key - value pairs to view

            return View(); // return type: ViewResult 
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(); // return type: ViewResult 
        }

        public IActionResult Privacy()
        {
            return View(); // return type: ViewResult 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
