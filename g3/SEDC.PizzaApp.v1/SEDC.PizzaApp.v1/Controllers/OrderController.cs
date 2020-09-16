using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.v1.Models.DomainModels;
using SEDC.PizzaApp.v1.Models.Enum;
using SEDC.PizzaApp.v1.Models.HelperModels;
using SEDC.PizzaApp.v1.Models.ViewModels;

namespace SEDC.PizzaApp.v1.Controllers
{
    public class OrderController : Controller
    {
        private readonly IHostingEnvironment _webhost;

        public OrderController(IHostingEnvironment webhost)
        {
            _webhost = webhost;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //transfer data form a Model          
            User person = new User()
            {
                FirstName = "Bob",
                LastName = "Bosky",
                Address = "Praska 90b",
                Phone = 12345,
            };

            Pizza pizza = new Pizza()
            {
                Name = "Capri",
                Size = PizzaSize.Family,
                Price = 12.50
            };

            Pizza pizza2 = new Pizza()
            {
                Name = "Quatro",
                Size = PizzaSize.Medium,
                Price = 8.50
            };

            Order order = new Order()
            {
                Id = 12,
                Price = pizza.Price + 2,
                User = person,
                IsDelivered = true,
                Pizzas = new List<Pizza>() { pizza, pizza2 }
            };

            //ViewData
            ViewData.Add("Title", "Welcome to our order page!");
            ViewData.Add("Username", person.FirstName);

            //ViewBag
            ViewBag.Greeting = "We have the best pizza in the world!";
            ViewBag.Pizza = pizza;

            return View(order);
        }

        [HttpGet]
        public IActionResult Order(string error) 
        {
            var menu = StaticDb.Menu;

            var pizzaNames = new List<string>();

            foreach (var pizza in menu)
            {
                pizzaNames.Add(pizza.Name);
            }

            var filteredPizzaNames = pizzaNames.Distinct().ToList();

            var viewModel = new MakeOrderViewModel()
            {
                PizzaNames = filteredPizzaNames
            };

            ViewBag.Error = error;

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Order(MakeOrderViewModel model) 
        {
            try
            {
                var pizza = StaticDb.Menu.FirstOrDefault(x => x.Name == model.Pizzas && x.Size == model.Size);

                var lastUserId = StaticDb.Users.Last().Id;

                var user = new User()
                {
                    Id = lastUserId + 1,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Phone = model.Phone
                };

                var lastOrderId = StaticDb.Orders.Last().Id;

                var order = new Order()
                {
                    Id = lastOrderId + 1,
                    IsDelivered = false,
                    Price = pizza.Price + 1.5,
                    User = user,
                    Pizzas = new List<Pizza>() { pizza }
                };

                StaticDb.Users.Add(user);
                StaticDb.Orders.Add(order);
                return View("_ThankYou");
            }
            catch
            {
                var message = "There was problem with the order, plesae select diferent pizza.";
                return RedirectToAction("Order", "Order", new { error = message });
            }
        }

        [HttpGet]
        public IActionResult Orders() 
        {
            var dbOrders = StaticDb.Orders;

            var orders = new List<OrderViewModel>();

            foreach (var order in dbOrders)
            {
                var tempOrder = new OrderViewModel()
                {
                    Id = order.Id,
                    FullName = order.User.FirstName + " " + order.User.LastName,
                    Address = order.User.Address,
                    Contact = order.User.Phone,
                    Price = order.Price,
                    IsDelievered = order.IsDelivered,
                    Pizzas = new List<PizzaViewModel>()
                };

                foreach (var pizza in order.Pizzas)
                {
                    var tempPizza = new PizzaViewModel()
                    {
                        Name = pizza.Name,
                        Price = pizza.Price,
                        Size = pizza.Size
                    };

                    tempOrder.Pizzas.Add(tempPizza);
                }

                orders.Add(tempOrder);
            }

            var ordersViewModel = new OrdersViewModel()
            {
                FirstPizza = dbOrders[0].Pizzas[0].Name,
                FirstPersonName = $"{dbOrders[0].User.FirstName} {dbOrders[0].User.LastName}",
                NumberOfOrders = dbOrders.Count,
                Orders = orders
            };

            return View(ordersViewModel);
        }

        [HttpGet]
        public IActionResult Details(int? id) 
        {
            var order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                return RedirectToAction("Index");
            }

            //mapping
            var orderDetails = new OrderViewModel()
            {
                Id = order.Id,
                FullName = order.User.FirstName + " " + order.User.LastName,
                Address = order.User.Address,
                Contact = order.User.Phone,
                Price = order.Price,
                IsDelievered = order.IsDelivered,
                Pizzas = new List<PizzaViewModel>()
            };

            foreach (var pizza in order.Pizzas)
            {
                var tempPizza = new PizzaViewModel()
                {
                    Name = pizza.Name,
                    Price = pizza.Price,
                    Size = pizza.Size
                };

                orderDetails.Pizzas.Add(tempPizza);
            }

            return View(orderDetails);
        }

        [HttpGet]
        public IActionResult Menu() 
        {
            var dbMenu = StaticDb.Menu.OrderByDescending(x => x.Id).ToList();

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

            var fileInfo = AccessWWWRoot();
            var pizzaImageNames = new List<string>();
            foreach (var item in fileInfo)
            {
                string extension = Path.GetExtension(item.Name);
                string result = item.Name.Substring(0, item.Name.Length - extension.Length);
                pizzaImageNames.Add(result);
            }

            var menuViewModel = new MenuViewModel()
            {
                Menu = menu,
                PizzaNames = pizzaImageNames
            };

            return View(menuViewModel);
        }


        //add pizza
        [HttpGet]
        public IActionResult AddPizza() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPizza(PizzaViewModel model)
        {
            var lastPizzaId = StaticDb.Menu.Last().Id;

            var pizza = new Pizza()
            {
                Id = lastPizzaId + 1,
                Name = model.Name,
                Price = model.Price,
                Size = model.Size
            };

            StaticDb.Menu.Add(pizza);

            return RedirectToAction("Menu");
        }

        //upolad image
        [HttpGet]
        public IActionResult UploadImg()
        {
            var ic = new ImageClass();
            var fileInfo = AccessWWWRoot();
            ic.FileImage = fileInfo;
            return View(ic);
        }

        [HttpPost]
        public IActionResult UploadImg(IFormFile imgfile)
        {
            var ic = new ImageClass();
            var fileInfo = AccessWWWRoot();
            ic.FileImage = fileInfo;

            if (imgfile == null) 
            {
                ic.Message = "Please select valid image.";
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
                ic.Message = $"Only file the img file types .jpg or .png can be uploaded.";
            }

            fileInfo = AccessWWWRoot();
            ic.FileImage = fileInfo;

            return View(ic);
        }

        //delete img
        [HttpGet]
        public IActionResult DeleteImg(string imgdelete) 
        {
            imgdelete = Path.Combine(_webhost.WebRootPath, "img/pizza", imgdelete);
            var image = new FileInfo(imgdelete);

            if (image != null) 
            {
                System.IO.File.Delete(imgdelete);
                image.Delete();
            }

            return RedirectToAction("UploadImg");
        }

        private List<FileInfo> AccessWWWRoot() 
        {
            var displayImg = Path.Combine(_webhost.WebRootPath, "img/pizza");
            var di = new DirectoryInfo(displayImg);
            List<FileInfo> fileInfo = di.GetFiles().ToList();
            return fileInfo;
        }
    }
}
