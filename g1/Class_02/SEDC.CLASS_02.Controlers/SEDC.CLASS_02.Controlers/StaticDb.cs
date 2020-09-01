using SEDC.CLASS_02.Controlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.CLASS_02.Controlers
{
    public static class StaticDb
    {
        public static List<UserModel> Users;
        static StaticDb()
        {
            Users = new List<UserModel>()
            {
                new UserModel()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                },
                new UserModel()
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                }
            };

        }
    }
}
