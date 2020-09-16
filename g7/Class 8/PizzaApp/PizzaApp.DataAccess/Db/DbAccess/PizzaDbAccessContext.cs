using Microsoft.EntityFrameworkCore;
using PizzaApp.DataAccess.Core.Entities;
using PizzaApp.DataAccess.Db.Interfaces;

namespace PizzaApp.DataAccess.Db.DbAccess
{
    public class PizzaDbAccessContext : DbContext, IDbContext
    {
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Blog> Blogs { get; set; }
        

        public PizzaDbAccessContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData
                (
                    new Pizza()
                    {
                        ID =1,
                        Name = "Capri",
                        Price =10,
                        Size = Core.Enums.PizzaSize.Small
                    },
                    new Pizza()
                    {
                        ID = 2,
                        Name = "Peperoni",
                        Price = 12,
                        Size = Core.Enums.PizzaSize.Small
                    },
                    new Pizza()
                    {
                        ID = 3,
                        Name = "Funghi",
                        Price = 14,
                        Size = Core.Enums.PizzaSize.Small
                    }
                );

            modelBuilder.Entity<User>()
                .HasMany<Order>(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);


            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);
            modelBuilder.Entity<Blog>().HasOne(b => b.User).WithMany(u => u.Blogs);
        }

    }
}
