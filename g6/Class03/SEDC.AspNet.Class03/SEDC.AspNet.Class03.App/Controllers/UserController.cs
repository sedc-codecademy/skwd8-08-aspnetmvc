using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Class03.App.Database;
using SEDC.AspNet.Class03.App.Models.DataAccessModels;
using SEDC.AspNet.Class03.App.Models.DataTransferModel;
using SEDC.AspNet.Class03.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class03.App.Controllers
{
    [Route("profile")]
    public class UserController : Controller
    {
        [HttpGet("{id:int}")]
        public IActionResult GetProfile(int id)
        {
            var user = PizzaDatabase.Users.FirstOrDefault(u => u.Id == id);

            if(user == null)
            {
                return RedirectToAction("Index", "Home", new { error = "User does not exists" });
            }

            var address = PizzaDatabase.Addresses.FirstOrDefault(a => a.UserId == user.Id);
            var subs = PizzaDatabase.NewsletterSubscription.FirstOrDefault(n => n.UserId == user.Id);

            var userDetails = new UserDetailsVM
            {
                Id = user.Id,
                FullName = string.Format("{0} {1}", user.FirstName, user.LastName),
                Phone = user.Phone,
                Address = address.Name,
                IsSubscribed = subs.IsSubscribed ? "Yes" : "No"
            };

            ViewData["ProfileInfo"] = TempData["ProfileInfo"]; //TempData["ProfileInfo"] value is -> "Successfuly created profile"

            return View(userDetails);
        }

        [HttpGet("user-info/{id:int}")]
        public IActionResult GetFullUserInfo(int id)
        {
            var user = PizzaDatabase.Users.FirstOrDefault(u => u.Id == id);

            var address = PizzaDatabase.Addresses.FirstOrDefault(a => a.Id == user.AddressId);

            var subs = PizzaDatabase.NewsletterSubscription.FirstOrDefault(nl => nl.Id == user.NewsletterId);

            var orders = PizzaDatabase.Orders.Where(o => o.UserId == user.Id);
            var pizzaIds = orders.Select(o => o.PizzaId);

            var pizzas = PizzaDatabase.Pizzas.Where(p => pizzaIds.Contains(p.Id));

            var userDto = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Address = address.Name,
                IsSubscribed = subs.IsSubscribed,
                Orders = new List<OrderDto>()
            };

            foreach (var order in orders)
            {
                var pizza = pizzas.FirstOrDefault(p => p.Id == order.PizzaId);

                var orderDto = new OrderDto
                {
                    Id = order.Id,
                    Delivered = order.Delivered,
                    Price = pizza.Price,
                    Pizza = new PizzaDto
                    {
                        Name = pizza.Name,
                        Size = pizza.Size
                    }
                };

                userDto.Orders.Add(orderDto);
            }

            userDto.TotalSpendings = userDto.Orders.Sum(x => x.Price);

            return Json(userDto);
        }

        [HttpGet("create-profile")]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost("create-profile")]
        public IActionResult CreateUser(CreateUserVM createUser)
        {
            var user = new User
            {
                Id = PizzaDatabase.Users.Count + 1,
                FirstName = createUser.FirstName,
                LastName = createUser.LastName,
                Phone = createUser.Phone
            };

            var address = new Address
            {
                Id = PizzaDatabase.Addresses.Count + 1,
                Name = createUser.Address,
                UserId = user.Id
            };

            var sub = new NewsletterSubscription
            {
                Id = PizzaDatabase.NewsletterSubscription.Count + 1,
                IsSubscribed = createUser.IsSubscribed,
                UserId = user.Id
            };

            user.AddressId = address.Id;
            user.NewsletterId = sub.Id;

            PizzaDatabase.Users.Add(user);
            PizzaDatabase.Addresses.Add(address);
            PizzaDatabase.NewsletterSubscription.Add(sub);

            TempData["ProfileInfo"] = "Successfuly created profile";

            return RedirectToAction("GetProfile", new { id = user.Id });
        }
    }
}
