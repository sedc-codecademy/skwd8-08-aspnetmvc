using NTierApp.DataAccess.Core.Entities;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NTierApp.Services.Mappings
{
    public static class Mapper
    {
        public static List<UserVM> MapUserModelsToViewModels(List<User> users)
        {
            return users.Select(x => new UserVM() { Email = x.Email, LastName = x.LastName, Name = x.Name, Password = x.Password, PhoneNumber = x.PhoneNumber, UserName = x.UserName, Orders = MapOrdersToOrderVM(x.Orders) }).ToList();
        }
        public static List<MovieVM> MapMoviesToMoviesVM(List<Movie> movies)
        {
            return movies.Select(m => new MovieVM() { Duration = m.Duration, MovieGenre = m.MovieGenre, MovieRating = m.MovieRating, Title = m.Title }).ToList();
        }
        public static List<OrderVM> MapOrdersToOrderVM(List<Order> orders)
        {
            return orders.Select(x => new OrderVM() { Movies = MapMoviesToMoviesVM(x.Movies), User = MapUserToUserVM(x.User) }).ToList();
        }
        public static UserVM MapUserToUserVM(User user)
        {
            return new UserVM()
            {
                Email = user.Email,
                LastName = user.LastName,
                Name = user.Name,
                Password = user.Password,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                Orders = MapOrdersToOrderVM(user.Orders)
            };
        }
        public static MovieVM FromMovieToMovieVM(Movie movie)
        {
            return new MovieVM()
            {
                Duration = movie.Duration,
                MovieGenre = movie.MovieGenre,
                MovieRating = movie.MovieRating,
                Title = movie.Title
            };
        }
    }
}
