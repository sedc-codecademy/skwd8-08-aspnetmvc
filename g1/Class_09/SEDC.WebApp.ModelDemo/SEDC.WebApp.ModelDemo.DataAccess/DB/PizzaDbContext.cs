using Microsoft.EntityFrameworkCore;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Enums;
using SEDC.WebApp.ModelDemo.DataAccess.Domain.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.DB
{
    public class PizzaDbContext : DbContext
    {
        //Configuring the context
        public PizzaDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
               
            modelBuilder.Entity<Order>()
                .HasOne(order => order.User)
                .WithMany(user => user.Orders);
            modelBuilder.Entity<Order>()
                .HasOne(order => order.Pizza);

            modelBuilder.Entity<Discount>()
                .HasKey(x => x.PizzaId);

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Medium,
                    Image = "Kapri.png"
                },
               new Pizza()
               {
                   Id = 2,
                   Name = "Kapri",
                   Price = 7,
                   Size = PizzaSize.Large,
                   Image = "Kapri.png"
               },
               new Pizza()
               {
                   Id = 3,
                   Name = "Kapri",
                   Price = 7,
                   Size = PizzaSize.Family,
                   Image = "Kapri.png"
               },
               new Pizza()
               {
                   Id = 4,
                   Name = "Peperoni",
                   Price = 9,
                   Size = PizzaSize.Medium,
                   Image = "Peperoni.png"
               },
               new Pizza()
               {
                   Id = 5,
                   Name = "Peperoni",
                   Price = 8,
                   Size = PizzaSize.Large,
                   Image = "Peperoni.png"
               },
               new Pizza()
               {
                   Id = 6,
                   Name = "Peperoni",
                   Price = 8,
                   Size = PizzaSize.Family,
                   Image = "Peperoni.png"
               },
               new Pizza()
               {
                   Id = 7,
                   Name = "Margarita",
                   Price = 10.5,
                   Size = PizzaSize.Medium,
                   Image = "Margarita.png"
               },
               new Pizza()
               {
                   Id = 8,
                   Name = "Margarita",
                   Price = 10.5,
                   Size = PizzaSize.Family,
                   Image = "Margarita.png"
               },
               new Pizza()
               {
                   Id = 9,
                   Name = "Margarita",
                   Price = 10.5,
                   Size = PizzaSize.Family,
                   Image = "Margarita.png"
               },
               new Pizza()
               {
                   Id = 10,
                   Name = "Siciliana",
                   Price = 6.5,
                   Size = PizzaSize.Medium,
                   Image = "Siciliana.png"
               },
               new Pizza()
               {
                   Id = 11,
                   Name = "Siciliana",
                   Price = 9.5,
                   Size = PizzaSize.Large,
                   Image = "Siciliana.png"
               },
               new Pizza()
               {
                   Id = 12,
                   Name = "Siciliana",
                   Price = 9.5,
                   Size = PizzaSize.Family,
                   Image = "Siciliana.png"
               }
            );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                }
            );
        }

    }
}
