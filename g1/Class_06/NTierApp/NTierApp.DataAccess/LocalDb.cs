using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using System.Collections.Generic;

namespace NTierApp.DataAccess
{
    public class LocalDb : ILocalDb
    {
        public static int IdCount { get; set; } = 1;
        public LocalDb()
        {
            IdCount++;
        }
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    ID = IdCount,
                    Title = "Good Will Hunting",
                    Duration = "2:10:00",
                    MovieGenre = Core.Enums.Genre.Drama,
                    MovieRating = Core.Enums.Rating.Three
                },
                 new Movie()
                {
                    ID = IdCount,
                    Title = "Dead poet society",
                    Duration = "1:58:10",
                    MovieGenre = Core.Enums.Genre.Drama,
                    MovieRating = Core.Enums.Rating.Three
                },
                   new Movie()
                {
                    ID = IdCount,
                    Title = "Longest Mile",
                    Duration = "1:58:10",
                    MovieGenre = Core.Enums.Genre.Comedy,
                    MovieRating = Core.Enums.Rating.Two
                }
            };
        }

        public IEnumerable<Order> GetOrder()
        {
            return new List<Order>()
            {
                new Order()
                {
                    ID = IdCount,
                    Movies = new List<Movie>(),
                    User = new User()
                },
                new Order()
                {
                    ID = IdCount,
                    Movies = new List<Movie>(),
                    User = new User()
                }
                
            };
        }

        public IEnumerable<User> GetUsers()
        {
          return  new List<User>()
            {
                new User()
                {
                    ID = IdCount,
                    Email = "damjanstojanovski454@gmail.com",
                    LastName = "Stojanovski",
                    Name = "Damjan",
                    Password = "pass123",
                    PhoneNumber = "075222222",
                    UserName = "damjan",
                    Orders = new List<Order>()
                }
            };
        }
    }
}
