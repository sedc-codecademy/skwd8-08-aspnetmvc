using SEDC.Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Library.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public BookGenre BookGenre { get; set; }
        public List<Author> Authors { get; set; }

    }
}
