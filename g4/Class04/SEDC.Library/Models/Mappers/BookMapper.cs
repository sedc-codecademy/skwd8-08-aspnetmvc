using SEDC.Library.Models.Domain;
using SEDC.Library.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Library.Models.Mappers
{
    public static class BookMapper
    {
        public static BookListViewModel ToBookListViewModel(Book book)
        {
            return new BookListViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Year = book.Year
            };
        }

        public static BookDetailsViewModel ToBookDetailsViewModel(Book book)
        {
            return new BookDetailsViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Year = book.Year,
                BookGenre = book.BookGenre,
                AuthorsFullNames = book.Authors.Select(x => x.FirstName + " " + x.LastName).ToList()
            };
        }
    }
}
