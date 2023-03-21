using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Services.BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AreIllustrations", "Cover", "Description", "GenreId", "ImageUrl", "InStock", "Name", "NumberOfPages", "Price", "Weight", "YearOfPublication" },
                values: new object[,]
                {
                    { 1, true, "Soft", "Some Description", 3, "https://projectsbykostatuno.blob.core.windows.net/bookstore/abraham_lincoln_a_history_vol.i.jpg", 21, "Abraham Lincoln: A History, Vol. I", 152, 299m, 699.0, new DateTime(2009, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, false, "Soft", "Some Description", 7, "https://projectsbykostatuno.blob.core.windows.net/bookstore/the_book_of_awesome_humour.jpg", 12, "The book of Awesome Humour", 81, 159m, 329.0, new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, true, "Solid", "Some Description", 2, "https://projectsbykostatuno.blob.core.windows.net/bookstore/the_water_is_wide_pat_conroy.jpg", 51, "The water is wide", 187, 512m, 999.0, new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, false, "Solid", "Some Description", 1, "https://projectsbykostatuno.blob.core.windows.net/bookstore/war_and_peace.jpg", 71, "War and Peace", 132, 499m, 699.0, new DateTime(1881, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);
        }
    }
}
