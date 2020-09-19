using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels
{
    public class User
    {
        // table columns
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long CardNumber { get; set; }
        public bool IsSubscriptionExpired { get; set; }

        // navigation properties
        public List<RentalInfo> RentedMovies { get; set; }
    }
}
