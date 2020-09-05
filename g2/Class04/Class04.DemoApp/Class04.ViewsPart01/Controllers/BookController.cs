using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class04.ViewsPart01.Helpers;
using Class04.ViewsPart01.Models;
using Class04.ViewsPart01.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Class04.ViewsPart01.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AllBooks()
        {
            List<Book> books = StaticDB.Books;
            return View(books);
        }
    }
}
