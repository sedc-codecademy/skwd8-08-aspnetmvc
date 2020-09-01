 public static class StaticDb
    {
        public static List<Order> Orders;
        public static List<Pizza> Menu;
        public static List<User> Users;
        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Jill Street",
                    Phone = 08006546345
                }
            };
            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 4,
                    Name = "Peperoni",
                    Price = 9,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "Peperoni",
                    Price = 10,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "Peperoni",
                    Price = 11,
                    Size = PizzaSize.Family
                }
            };
            Orders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = Users[0],
                    Pizza = Menu[0],
                    Delivered = false
                }
            };
        }
    }
