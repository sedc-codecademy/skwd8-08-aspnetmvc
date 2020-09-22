using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Services.Classes;
using SEDC.PizzaApp.Services.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.Helpers;
using SEDC.PizzaApp.ViewModels.Models;

namespace SEDC.PizzaApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private MenuService _menuService;
        private IMenuService _menuService;
        private readonly IHostingEnvironment _webhost;

        public HomeController(IMenuService menuService,
                              IHostingEnvironment webhost)
        {
            //_menuService = new MenuService();
            _menuService = menuService;
            _webhost = webhost;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { pizzas = model.NumberOfPizzas });
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

            var menuViewModel = new MenuViewModel()
            {
                Menu = menu
            };

            return View(menuViewModel);
        }

        [HttpGet]
        public IActionResult AddPizza() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPizza(AddPizzaViewModel model)
        {
            _menuService.AddPizzaInMenu(model);
            return RedirectToAction("Menu");
        }

        [HttpGet]
        public IActionResult UploadImg()
        {
            var ic = new ImageClass();
            var fileInfo = AccessWWWRoot();
            ic.FileImages = fileInfo;
            return View(ic);
        }

        [HttpPost]
        public IActionResult UploadImg(IFormFile imgfile)
        {
            ImageClass ic = new ImageClass();
            var fileInfo = AccessWWWRoot();
            ic.FileImages = fileInfo;

            if (imgfile == null)
            {
                ic.Message = "Please select a valid Image.";
                return View(ic);
            }

            var saveimg = Path.Combine(_webhost.WebRootPath, "img/pizza", imgfile.FileName);

            var imgtext = Path.GetExtension(imgfile.FileName);
            if (imgtext == ".jpg" || imgtext == ".png")
            {
                using (var uploadimg = new FileStream(saveimg, FileMode.Create))
                {
                    imgfile.CopyTo(uploadimg);
                    ic.Message = $"The selected file {imgfile.FileName} is saved successfully.";
                }
            }
            else
            {
                ic.Message = $"Only the img file types .jpg or .png can be uploaded!";
            }

            fileInfo = AccessWWWRoot();
            ic.FileImages = fileInfo;

            return View(ic);
        }

        [HttpGet]
        public IActionResult DeleteImg(string imgdelete)
        {
            imgdelete = Path.Combine(_webhost.WebRootPath, "img/pizza", imgdelete);
            FileInfo fi = new FileInfo(imgdelete);

            if (fi != null)
            {
                System.IO.File.Delete(imgdelete);
                fi.Delete();
            }
            return RedirectToAction("UploadImg");
        }

        private List<FileInfo> AccessWWWRoot()
        {
            var displayImg = Path.Combine(_webhost.WebRootPath, "img/pizza");
            DirectoryInfo di = new DirectoryInfo(displayImg);
            List<FileInfo> fileInfo = di.GetFiles().ToList();
            return fileInfo;
        }
    }
}
