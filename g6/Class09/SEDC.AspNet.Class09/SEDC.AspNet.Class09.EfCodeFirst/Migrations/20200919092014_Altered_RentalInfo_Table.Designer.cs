﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.AspNet.Class09.EfCodeFirst.Database;

namespace SEDC.AspNet.Class09.EfCodeFirst.Migrations
{
    [DbContext(typeof(RentalStoreContext))]
    [Migration("20200919092014_Altered_RentalInfo_Table")]
    partial class Altered_RentalInfo_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeRestriction");

                    b.Property<int>("Genre");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Language");

                    b.Property<int>("Length");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new { Id = 1, AgeRestriction = 14, Genre = 0, IsAvailable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Iron Man" },
                        new { Id = 2, AgeRestriction = 16, Genre = 0, IsAvailable = true, Language = "EN", Length = 220, Quantity = 7, ReleaseDate = new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The Incredible Hulk" },
                        new { Id = 3, AgeRestriction = 14, Genre = 0, IsAvailable = false, Language = "EN", Length = 120, Quantity = 0, ReleaseDate = new DateTime(2010, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Iron Man 2" },
                        new { Id = 4, AgeRestriction = 16, Genre = 0, IsAvailable = true, Language = "EN", Length = 210, Quantity = 2, ReleaseDate = new DateTime(2011, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Thor" },
                        new { Id = 5, AgeRestriction = 8, Genre = 0, IsAvailable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2011, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Captain America: The First Avenger" },
                        new { Id = 6, AgeRestriction = 6, Genre = 0, IsAvailable = false, Language = "EN", Length = 160, Quantity = 0, ReleaseDate = new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Marvel's The Avengers" },
                        new { Id = 7, AgeRestriction = 6, Genre = 2, IsAvailable = true, Language = "EN", Length = 111, Quantity = 1, ReleaseDate = new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Hot Rod" },
                        new { Id = 8, AgeRestriction = 6, Genre = 2, IsAvailable = false, Language = "EN", Length = 180, Quantity = 0, ReleaseDate = new DateTime(1996, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The First Wives Club" },
                        new { Id = 9, AgeRestriction = 8, Genre = 2, IsAvailable = true, Language = "EN", Length = 200, Quantity = 8, ReleaseDate = new DateTime(2000, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Scary Movie" },
                        new { Id = 10, AgeRestriction = 6, Genre = 2, IsAvailable = true, Language = "EN", Length = 140, Quantity = 4, ReleaseDate = new DateTime(1940, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The Bank Dick" },
                        new { Id = 11, AgeRestriction = 6, Genre = 2, IsAvailable = false, Language = "EN", Length = 100, Quantity = 0, ReleaseDate = new DateTime(1993, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Mrs. Doubtfire" },
                        new { Id = 12, AgeRestriction = 14, Genre = 1, IsAvailable = true, Language = "EN", Length = 160, Quantity = 2, ReleaseDate = new DateTime(1999, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Existenz" },
                        new { Id = 13, AgeRestriction = 12, Genre = 1, IsAvailable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2014, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The Congress" },
                        new { Id = 14, AgeRestriction = 10, Genre = 1, IsAvailable = true, Language = "EN", Length = 110, Quantity = 7, ReleaseDate = new DateTime(1998, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Dark City" },
                        new { Id = 15, AgeRestriction = 14, Genre = 1, IsAvailable = true, Language = "EN", Length = 180, Quantity = 10, ReleaseDate = new DateTime(2003, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The Matrix Reloaded" },
                        new { Id = 16, AgeRestriction = 18, Genre = 1, IsAvailable = true, Language = "EN", Length = 180, Quantity = 3, ReleaseDate = new DateTime(2010, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Splice" },
                        new { Id = 17, AgeRestriction = 12, Genre = 1, IsAvailable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2011, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Rise of the planet of the apes" }
                    );
                });

            modelBuilder.Entity("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.RentalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRented");

                    b.Property<DateTime?>("DateReturned");

                    b.Property<int>("MovieId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("RentalInfo");
                });

            modelBuilder.Entity("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CardNumber");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsSubscriptionExpired");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = 1, CardNumber = 123L, DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FullName = "Trajan Stevkovski", IsSubscriptionExpired = false },
                        new { Id = 2, CardNumber = 112L, DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FullName = "Im Admin", IsSubscriptionExpired = false }
                    );
                });

            modelBuilder.Entity("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.RentalInfo", b =>
                {
                    b.HasOne("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.Movie", "Movie")
                        .WithOne("RentalInfo")
                        .HasForeignKey("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.RentalInfo", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels.User", "User")
                        .WithMany("RentedMovies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}