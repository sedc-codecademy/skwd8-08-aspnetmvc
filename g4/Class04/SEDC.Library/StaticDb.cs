using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.Library.Models;
using SEDC.Library.Models.Domain;
using SEDC.Library.Models.Enums;

namespace SEDC.Library
{
    public static class StaticDb
    {
        public static int BookID = 2;
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id =1,
                Title = "Kasni Porasni",
                BookGenre = BookGenre.Mystery,
                Year="1992",
                Authors = new List<Author>
                {
                    new Author
                    {
                        Id =1,
                        FirstName = "Author1",
                        LastName ="AuthorlastName1"
                    },
                     new Author
                    {
                        Id =2,
                        FirstName = "Author2",
                        LastName ="AuthorlastName2"
                    }
                }
            },
             new Book
             {
                 Id=2,
                 Title = "Zoki Poki",
                 BookGenre = BookGenre.Novel,
                 Year="1990",
                 Authors = new List<Author>
                 {
                     new Author
                    {
                        Id =3,
                        FirstName = "Author3",
                        LastName ="AuthorlastName3"
                    },
                     new Author
                    {
                        Id =4,
                        FirstName = "Author4",
                        LastName ="AuthorlastName4"
                    }
                 }
             }
        };
    }
}
