
using Class04.ViewsPart01.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class04.ViewsPart01.Helpers
{
    public static class StaticDB
    {
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = 1,
                ISBN = "123456789",
                Title = "Harry Potter",
                Author = new Author
                {
                    Id = 1,
                    FullName = "J.K. Rowling",
                    Age = 60
                },
                Genre = Genre.Adventure,
                IsAvailable = true
            },

            new Book
            {
                Id = 2,
                ISBN = "987654321",
                Title = "Secrets of the JavaScript Ninja",
                Author =  new Author
                {
                    Id = 2,
                    FullName = "John Resig",
                    Age = 50
                },
                Genre = Genre.Tech,
                IsAvailable = false
            }
        };
    }
}
