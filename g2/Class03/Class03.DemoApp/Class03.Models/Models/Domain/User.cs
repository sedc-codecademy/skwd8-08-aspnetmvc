using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class03.Models.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> Books { get; set; }
    }
}
