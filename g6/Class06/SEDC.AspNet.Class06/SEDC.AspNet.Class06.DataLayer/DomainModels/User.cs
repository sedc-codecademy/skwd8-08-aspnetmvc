using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer.DomainModels
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
