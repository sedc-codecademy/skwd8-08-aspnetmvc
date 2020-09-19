using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.AspNet.Class09.EfCodeFirst.Migrations
{
    public partial class initial_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    AgeRestriction = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CardNumber = table.Column<long>(nullable: false),
                    IsSubscriptionExpired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentalInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DateRented = table.Column<DateTime>(nullable: false),
                    DateReturned = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalInfo_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentalInfo_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Genre", "IsAvailable", "Language", "Length", "Quantity", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 14, 0, true, "EN", 180, 4, new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man" },
                    { 17, 12, 1, true, "EN", 180, 2, new DateTime(2011, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rise of the planet of the apes" },
                    { 16, 18, 1, true, "EN", 180, 3, new DateTime(2010, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Splice" },
                    { 15, 14, 1, true, "EN", 180, 10, new DateTime(2003, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix Reloaded" },
                    { 14, 10, 1, true, "EN", 110, 7, new DateTime(1998, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark City" },
                    { 13, 12, 1, true, "EN", 180, 1, new DateTime(2014, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Congress" },
                    { 12, 14, 1, true, "EN", 160, 2, new DateTime(1999, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Existenz" },
                    { 11, 6, 2, false, "EN", 100, 0, new DateTime(1993, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Doubtfire" },
                    { 10, 6, 2, true, "EN", 140, 4, new DateTime(1940, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Bank Dick" },
                    { 8, 6, 2, false, "EN", 180, 0, new DateTime(1996, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The First Wives Club" },
                    { 7, 6, 2, true, "EN", 111, 1, new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hot Rod" },
                    { 6, 6, 0, false, "EN", 160, 0, new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's The Avengers" },
                    { 5, 8, 0, true, "EN", 180, 1, new DateTime(2011, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain America: The First Avenger" },
                    { 4, 16, 0, true, "EN", 210, 2, new DateTime(2011, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor" },
                    { 3, 14, 0, false, "EN", 120, 0, new DateTime(2010, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man 2" },
                    { 2, 16, 0, true, "EN", 220, 7, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Incredible Hulk" },
                    { 9, 8, 2, true, "EN", 200, 8, new DateTime(2000, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scary Movie" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CardNumber", "DateOfBirth", "FullName", "IsSubscriptionExpired" },
                values: new object[,]
                {
                    { 1, 123L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trajan Stevkovski", false },
                    { 2, 112L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Im Admin", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentalInfo_MovieId",
                table: "RentalInfo",
                column: "MovieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalInfo_UserId",
                table: "RentalInfo",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalInfo");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
