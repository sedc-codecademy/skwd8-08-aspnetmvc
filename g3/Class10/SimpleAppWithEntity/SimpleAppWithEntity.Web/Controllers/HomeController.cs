using Microsoft.AspNetCore.Mvc;
using SimpleAppWithEntity.Services.Interfaces;
using SimpleAppWithEntity.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAppWithEntity.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        [HttpGet]
        public IActionResult AddName() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddName(NameViewModel model)
        {
            _homeService.CreateNewName(model);
            return View();
        }

        [HttpGet]
        public IActionResult GetNames() 
        {
            var names = _homeService.GetAllNames();
            return View(names);
        }

    }
}
