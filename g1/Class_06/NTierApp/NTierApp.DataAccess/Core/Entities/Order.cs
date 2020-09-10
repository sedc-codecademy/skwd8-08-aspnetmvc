using System.Collections.Generic;

namespace NTierApp.DataAccess.Core.Entities
{
    public class Order : BaseEntity
    {
        public User User { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
