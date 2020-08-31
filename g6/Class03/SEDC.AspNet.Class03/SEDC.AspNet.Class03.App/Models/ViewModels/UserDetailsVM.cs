using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class03.App.Models.ViewModels
{
    public class UserDetailsVM
    {
        public int Id { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        public long Phone { get; set; }

        [Display(Name = "Active subscription")]
        public string IsSubscribed { get; set; }
    }
}
