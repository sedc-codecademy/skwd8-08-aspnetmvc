using System.Collections.Generic;

namespace NTierApp.DataAccess.Core.Entities
{
    public  class User: BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; }
    }
}
