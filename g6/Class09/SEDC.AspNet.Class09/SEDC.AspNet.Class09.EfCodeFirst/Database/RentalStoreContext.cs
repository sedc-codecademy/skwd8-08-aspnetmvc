using Microsoft.EntityFrameworkCore;
using SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels;
using SEDC.AspNet.Class09.EfCodeFirst.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class09.EfCodeFirst.Database
{
    public class RentalStoreContext : DbContext
    {
        public RentalStoreContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<RentalInfo> RentalsInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .ToTable(nameof(User))
                .HasMany(x => x.RentedMovies)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder
                .Entity<RentalInfo>()
                .ToTable(nameof(RentalInfo))
                .HasOne(x => x.Movie);

            modelBuilder
                .Entity<Movie>()
                .ToTable(nameof(Movie));

            modelBuilder
                .Entity<User>()
                .HasData(
                new User() { Id = 1, CardNumber = 123, FullName = "Trajan Stevkovski" },
                new User() { Id = 2, CardNumber = 112, FullName = "Im Admin" }
                );

            modelBuilder
                .Entity<Movie>()
                .HasData(
                new Movie() { Title = "Iron Man", AgeRestriction = 14, Genre = Genre.Action, Id = 1, IsAvailable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2008, 5, 2) },
                new Movie() { Title = "The Incredible Hulk", AgeRestriction = 16, Genre = Genre.Action, Id = 2, IsAvailable = true, Language = "EN", Length = 220, Quantity = 7, ReleaseDate = new DateTime(2008, 6, 13) },
                new Movie() { Title = "Iron Man 2", AgeRestriction = 14, Genre = Genre.Action, Id = 3, IsAvailable = false, Language = "EN", Length = 120, Quantity = 0, ReleaseDate = new DateTime(2010, 5, 7) },
                new Movie() { Title = "Thor", AgeRestriction = 16, Genre = Genre.Action, Id = 4, IsAvailable = true, Language = "EN", Length = 210, Quantity = 2, ReleaseDate = new DateTime(2011, 7, 6) },
                new Movie() { Title = "Captain America: The First Avenger", AgeRestriction = 8, Genre = Genre.Action, Id = 5, IsAvailable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2011, 7, 22) },
                new Movie() { Title = "Marvel's The Avengers", AgeRestriction = 6, Genre = Genre.Action, Id = 6, IsAvailable = false, Language = "EN", Length = 160, Quantity = 0, ReleaseDate = new DateTime(2012, 5, 4) },
                new Movie() { Title = "Hot Rod", AgeRestriction = 6, Genre = Genre.Comedy, Id = 7, IsAvailable = true, Language = "EN", Length = 111, Quantity = 1, ReleaseDate = new DateTime(2007, 5, 2) },
                new Movie() { Title = "The First Wives Club", AgeRestriction = 6, Genre = Genre.Comedy, Id = 8, IsAvailable = false, Language = "EN", Length = 180, Quantity = 0, ReleaseDate = new DateTime(1996, 5, 2) },
                new Movie() { Title = "Scary Movie", AgeRestriction = 8, Genre = Genre.Comedy, Id = 9, IsAvailable = true, Language = "EN", Length = 200, Quantity = 8, ReleaseDate = new DateTime(2000, 5, 2) },
                new Movie() { Title = "The Bank Dick", AgeRestriction = 6, Genre = Genre.Comedy, Id = 10, IsAvailable = true, Language = "EN", Length = 140, Quantity = 4, ReleaseDate = new DateTime(1940, 5, 2) },
                new Movie() { Title = "Mrs. Doubtfire", AgeRestriction = 6, Genre = Genre.Comedy, Id = 11, IsAvailable = false, Language = "EN", Length = 100, Quantity = 0, ReleaseDate = new DateTime(1993, 5, 2) },
                new Movie() { Title = "Existenz", AgeRestriction = 14, Genre = Genre.SciFi, Id = 12, IsAvailable = true, Language = "EN", Length = 160, Quantity = 2, ReleaseDate = new DateTime(1999, 5, 2) },
                new Movie() { Title = "The Congress", AgeRestriction = 12, Genre = Genre.SciFi, Id = 13, IsAvailable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2014, 5, 2) },
                new Movie() { Title = "Dark City", AgeRestriction = 10, Genre = Genre.SciFi, Id = 14, IsAvailable = true, Language = "EN", Length = 110, Quantity = 7, ReleaseDate = new DateTime(1998, 5, 2) },
                new Movie() { Title = "The Matrix Reloaded", AgeRestriction = 14, Genre = Genre.SciFi, Id = 15, IsAvailable = true, Language = "EN", Length = 180, Quantity = 10, ReleaseDate = new DateTime(2003, 5, 2) },
                new Movie() { Title = "Splice", AgeRestriction = 18, Genre = Genre.SciFi, Id = 16, IsAvailable = true, Language = "EN", Length = 180, Quantity = 3, ReleaseDate = new DateTime(2010, 5, 2) },
                new Movie() { Title = "Rise of the planet of the apes", AgeRestriction = 12, Genre = Genre.SciFi, Id = 17, IsAvailable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2011, 5, 2) }
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
