using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class02.DemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.DemoApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View(); // return result of type: ViewResult 
        }

        public IActionResult ListBooks()
        {
            return RedirectToAction("Index", "Home");
            // returns a Redirect to an action in different controller
        }

        public IActionResult Empty()
        {
            return new EmptyResult(); // return result of type: EmptyResult 
        }

        public IActionResult JsonData()
        {
            Book book = new Book
            {
                Id = 1,
                Title = "Harry Potter"
            };

            return new JsonResult(book); // returns result of type: JSON
        }

        [Route("BookDetails/{id}")] // example for redirecting with value for parameters
        public IActionResult BookDetails(int id)
        {
            Book foundBook = StaticDB.Books.FirstOrDefault(b => b.Id == id);
            return RedirectToAction("Contact", "Home", new { personName = foundBook.Title });
        }

        public IActionResult CheckName(string name)
        {
            return View();
        }

    }
}
