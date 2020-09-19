using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels
{
    public class RentalInfo
    {
        // table columns
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }

        // navigation properties
        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
