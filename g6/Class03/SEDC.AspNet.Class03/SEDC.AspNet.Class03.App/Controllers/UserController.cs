using Microsoft.AspNetCore.Mvc;
using SEDC.AspNet.Class03.App.Database;
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

            return View(userDetails);
        }
    }
}
