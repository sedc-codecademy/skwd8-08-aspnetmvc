using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.Library.Models.Domain;
using SEDC.Library.Models.Mappers;
using SEDC.Library.Models.ViewModels;

namespace SEDC.Library.Controllers
{
    // [Route("Kniga/[Action]")] - the routes would look like this:  localhost:port/Kniga/Index
    //[Route("Kniga")]
    public class BookController : Controller
    {
        // [Route("Books")]   localhost:port/Books
        public IActionResult Index()
        {
            List<Book> books = StaticDb.Books;
            List<BookListViewModel> bookListViewModels = new List<BookListViewModel>();
            foreach(Book book in books)
            {
                bookListViewModels.Add(BookMapper.ToBookListViewModel(book));
            }
            return View(bookListViewModels);
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
                BookDetailsViewModel bookDetailsViewModel = BookMapper.ToBookDetailsViewModel(book);
                return View(bookDetailsViewModel);
            }
            return new EmptyResult();
        }

        [HttpGet]
        public IActionResult CreateBook() //this action is called via GET method to return the view with the form
        {
            Book book = new Book();
            return View(book);
        }

        [HttpPost]
        public IActionResult CreateBookPost(Book book) // this is the POST action that we send the data to
        {
            StaticDb.BookID++; //logic for auto incrementing the ids of the books
            book.Id = StaticDb.BookID;
            StaticDb.Books.Add(book);
            return RedirectToAction("Index");
        }
    }
}