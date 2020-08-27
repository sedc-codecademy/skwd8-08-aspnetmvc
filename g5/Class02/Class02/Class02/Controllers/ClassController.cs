using System.Collections.Generic;
using System.Threading;
using Class02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("InProgress", "Common");
        }

        public IActionResult SendEmail()
        {
            Thread.Sleep(5000);
            return new EmptyResult();
        }

        public IActionResult GetData()
        {
            List<Module> modules = new List<Module>
            {
                new Module("C# Basic", 10),
                new Module("C# Advance", 10),
                new Module("Sql", 10)
            };

            return new JsonResult(modules);
        }
    }
}
