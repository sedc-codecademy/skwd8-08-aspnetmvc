
using SEDC.MVC.BuildingApps.Domain.Models;
using System.Collections.Generic;

namespace SEDC.MVC.BuildeingApps.DataAccess
{
    public static class Databse
    {
        public static List<User> Users { get; set; } = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Email = "test@gmail.com"
                },
                new User()
                {
                    Id = 2,
                    Email = "testMail@hotmail.com"
                }
            };
        }
}
