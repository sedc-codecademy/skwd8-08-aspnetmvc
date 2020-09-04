using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class03.Models.Helpers;
using Class03.Models.Models.Domain;
using Class03.Models.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Class03.Models.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {

            List<Book> books = StaticDB.Books.ToList();

            List<Book> martinsBooks = books.Where(x => x.Id == 1).ToList();
            List<Book> dejansBooks = books.ToList();

            List<User> users = new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Martin",
                    LastName = "Panovski",
                    Age = 27,
                    Books = martinsBooks
                },
                new User
                {
                    Id = 2,
                    FirstName = "Dejan",
                    LastName = "Jovanov",
                    Age = 27,
                    Books = dejansBooks
                }
            };


            //FirstName
            //LastName
            //Title
            //Author name 
            //ISBN number
            List<OrderViewModel> orders = new List<OrderViewModel>();


            //We create a new instance of the ViewModel that we need to send to the view with only specific data
            foreach (var user in users)
            {
                OrderViewModel order = new OrderViewModel
                {
                    UserFirstName = user.FirstName,
                    UserLastName = user.LastName,
                    BookTitle = user.Books.FirstOrDefault(x => x.Id == 1).Title,
                    AuthorFullName = user.Books.FirstOrDefault(x => x.Id == 1).Author.FullName,
                    ISBN = user.Books.FirstOrDefault(x => x.Id == 1).ISBN
                };
                orders.Add(order);
            }
            return View(orders);
        }
    }
}
