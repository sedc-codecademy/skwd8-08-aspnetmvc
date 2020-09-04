using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class03.Models.Helpers;
using Class03.Models.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Class03.Models.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            List<Book> books = new List<Book>();
            books = StaticDB.Books;
            return View(books);
        }

        public IActionResult Details(int? id)
        {
            Book book = StaticDB.Books
                                .Where(x => x.Id == id)
                                .SingleOrDefault();
            if(book != null)
                return View(book);
            return RedirectToAction("Index");
        }
    }
}
