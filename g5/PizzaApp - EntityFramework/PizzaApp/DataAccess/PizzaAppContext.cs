using System.Collections.Generic;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PizzaAppContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSize> PizzaSizes { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=PizzaDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().HasKey(x => x.Id);
            //modelBuilder.Entity<Customer>().Property(x => x.Id).ValueGeneratedOnAdd();

            //modelBuilder.Entity<Order>()
            //    .HasMany(x => x.OrderItems)
            //    .WithOne(x => x.Order)
            //    .HasForeignKey(x => x.OrderId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Order>()
            //    .HasOne(x => x.Customer)
            //    .WithOne(x => x.Order);
            
            var pizza1 = new Pizza("Capricioza", "Capri with ham", "https://pizzapempele.mk/wp-content/uploads/2014/11/pizza_capriciossa-520x390.jpg")
            {
                Id = 1
            };

            var pizza2 = new Pizza("Bacon", "Really good pizza", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2Fgluten-free-cookbook%2Fpepperoni-pizza-ck-x.jpg")
            {
                Id = 2
            };
            modelBuilder.Entity<Pizza>().HasData(new List<Pizza> {pizza1, pizza2});

            var size1 = new Size("Sredna", "45 cm")
            {
                Id = 1
            };
            var size2 = new Size("Golema", "60 cm")
            {
                Id = 2
            };
            modelBuilder.Entity<Size>().HasData(new List<Size>() {size1, size2});
        }
    }
}
