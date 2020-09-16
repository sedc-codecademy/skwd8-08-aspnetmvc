using System;
using System.Collections.Generic;
using System.Text;

namespace NTIerApp.PresentationLayer.ViewModels
{
    public class UserVM
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public List<OrderVM> Orders { get; set; }
    }
}
