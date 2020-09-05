using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.Library.Models;

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
                Title = "Kasni Porasni"
            },
             new Book
             {
                 Id=2,
                 Title = "Zoki Poki"
             }
        };
    }
}
