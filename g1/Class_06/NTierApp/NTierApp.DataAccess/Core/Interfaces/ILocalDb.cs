using NTierApp.DataAccess.Core.Entities;
using System.Collections.Generic;

namespace NTierApp.DataAccess.Core.Interfaces
{
    public interface ILocalDb
    {
        IEnumerable<User> GetUsers();
        IEnumerable<Movie> GetMovies();
        IEnumerable<Order> GetOrder();
    }
}
