using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class02.DemoApp.Models;

namespace Class02.DemoApp
{
    public static class StaticDB
    {
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id=1,
                Title="Harry Potter"
            },
             new Book
            {
                Id=2,
                Title="C# in Depth"
            }
        };
    }
}
