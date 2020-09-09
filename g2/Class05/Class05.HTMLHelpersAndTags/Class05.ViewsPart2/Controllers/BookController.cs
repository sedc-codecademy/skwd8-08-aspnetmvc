using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class05.ViewsPart2.Helpers;
using Class05.ViewsPart2.Models.Domain;
using Class05.ViewsPart2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Class05.ViewsPart2.Controllers
{
    public class BookController : Controller
    {
        [Route("all-books")]
        public IActionResult Index()
        {
            List<Book> books = StaticDB.Books;
            return View(books);
        }

        public IActionResult Create()
        {
            BookCreateViewModel model = new BookCreateViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(BookCreateViewModel model)
        {
            Book book = new Book();
            Author author = new Author();

            int id = StaticDB.Books.Count() + 1;

            if(model != null)
            {
                book.Id = id;
                book.ISBN = model.ISBN;
                book.Title = model.Title;
                book.Genre = model.Genre;

                author.FullName = model.AuthorFullName;
                author.Age = model.AuthorAge.HasValue ? model.AuthorAge.Value : 0;

                book.Author = author;
                book.IsAvailable = model.IsAvailable;

                StaticDB.Books.Add(book);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Book book = StaticDB.Books.SingleOrDefault(x => x.Id == id);

            BookDetailsViewModel bookDetails = new BookDetailsViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorFullName = book.Author.FullName,
                Genre = book.Genre
            };
            return View(bookDetails);
        }
    }
}
