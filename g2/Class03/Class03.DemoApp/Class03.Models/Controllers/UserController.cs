using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class03.Models.Helpers;
using Class03.Models.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Class03.Models.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData.Add("Title", "Users");
            ViewData.Add("Message", "Here are all our users!");

            User user = new User
            {
                Id = 1,
                FirstName = "Martin",
                LastName = "Panovski",
                Age = 27
            };

            //ViewData.Add("User", user);


            ViewBag.User = user;



            return View();
        }

        public IActionResult UsersWithBooks()
        {
            List<Book> books = StaticDB.Books.ToList();
            User user = new User() { Id = 1, FirstName = "Dejan", LastName = "Jovanov", Age = 27, Books = books };

            return View(user);
        }
    }
}
