using Microsoft.AspNetCore.Mvc;
using SimpleAppWithEntity.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAppWithEntity.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult AddName() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddName(NameViewModel model)
        {
            return new EmptyResult();
        }

    }
}
