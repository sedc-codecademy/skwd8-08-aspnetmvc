using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class03.Models.Models.ViewModels
{
    public class OrderViewModel
    {
        public string UserFirstName { get; set; }
        public string UserLastName{ get; set; }
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public string AuthorFullName { get; set; }
    }
}
