using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Services.Classes;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Models;

namespace SEDC.PizzaApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private MenuService _menuService;
        private IMenuService _menuService;

        public HomeController(IMenuService menuService)
        {
            //_menuService = new MenuService();
            _menuService = menuService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Menu() 
        {
            var dbMenu = _menuService.GetMenu();

            var menu = new List<PizzaViewModel>();

            foreach (var pizza in dbMenu)
            {
                var tempModel = new PizzaViewModel()
                {
                    Name = pizza.Name,
                    Price = pizza.Price,
                    Size = pizza.Size
                };

                menu.Add(tempModel);
            }

            //var fileInfo = AccessWWWRoot();
            //var pizzaImageNames = new List<string>();

            //foreach (var item in fileInfo)
            //{
            //    string extension = Path.GetExtension(item.Name);
            //    string result = item.Name.Substring(0, item.Name.Length - extension.Length);
            //    pizzaImageNames.Add(result);
            //}

            var menuViewModel = new MenuViewModel()
            {
                Menu = menu,
                //PizzaNames = pizzaImageNames
            };

            return View(menuViewModel);
        }
    }
}
