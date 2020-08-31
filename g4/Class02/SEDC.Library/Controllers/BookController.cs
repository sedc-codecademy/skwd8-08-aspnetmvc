using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Library.Models;

namespace SEDC.Library.Controllers
{
    // [Route("Kniga/[Action]")] - the routes would look like this:  localhost:port/Kniga/Index
    //[Route("Kniga")]
    public class BookController : Controller
    {
        // [Route("Books")]   localhost:port/Books
        public IActionResult Index()
        {
            return View();
        }

        // [Route("Json")] - if we use it in combination with [Route("Kniga")] -> localhost:port/Kniga/Json
        public IActionResult JsonData()
        {
            Book book = new Book
            {
                Id = 1,
                Title = "Kasni Porasni"
            };
            return new JsonResult(book); // return type: JsonResult
        }
        
        public IActionResult ListBooks()
        {
            return RedirectToAction("Index"); // redirects to Index Action in the same controller
        }

        public IActionResult BackToHome()
        {
            return RedirectToAction("Index","Home"); // redirects to Index Action in the Home controller
        }

        public IActionResult Empty()
        {
            //processing
            return new EmptyResult(); // return type: EmptyResult
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                // if we send id find the book we are looking for
                Book book = StaticDb.Books.FirstOrDefault(x => x.Id == id);
                return View(book);
            }
            return new EmptyResult();
        }
    }
}