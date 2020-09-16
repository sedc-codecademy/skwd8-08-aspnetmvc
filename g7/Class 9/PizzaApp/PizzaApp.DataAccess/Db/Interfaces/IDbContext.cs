using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.Core.Entities;

namespace PizzaApp.DataAccess.Db.Interfaces
{
    public interface IDbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
