using SEDC.Library.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Library.Models.ViewModels
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public BookGenre BookGenre { get; set; }
        public List<string> AuthorsFullNames { get; set; }

    }
}
