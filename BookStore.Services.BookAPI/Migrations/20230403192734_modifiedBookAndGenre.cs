using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Services.BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class modifiedBookAndGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Genre",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Nonfiction history books include any books that lay out the known facts about a particular, time, culture, or event in history.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Memoirs are one type of autobiography. In this type of book, the author puts emphasis on specific moments or events that brought about specific life lessons. ");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Political nonfiction books can include books written by career politicians, books that explore political systems, or books that discuss the politics of a certain period.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Self-help books aim to aid the reader in improving some part of her life. Common topics covered by self-help books include relationships, finances, and mental health. ");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Thrillers are suspenseful stories, which makes a crime thriller a book that has a crime as its main subject while keeping readers on edge. The main characters are often fighting for justice.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Also known as Sci-Fi, science fiction deals with the imagined future in terms of science or technology advances. This genre includes things like time travel, outer space, and intelligent life.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "The world can be a dark place at times, and we all need something light-hearted to entertain and distract us. Happily, there are a host of witty, satirical and downright hilarious books out there, waiting to put a smile back on our face.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Horror is a genre of literature, film, and television that is meant to scare, startle, shock, and even repulse audiences. The key focus of a horror novel, horror film, or horror TV show is to elicit a sense of dread in the reader through frightening images, themes, and situations.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "A classic book can be simply defined as a book which has been recognized by critics and the public to be excellent, and a “must-read.” Traditionally, the term was only used to describe books originally written in Greek or Latin, but the definition has been expanded to include books written in all languages.");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "A biography is simply the story of a real person's life. It could be about a person who is still alive, someone who lived centuries ago, someone who is globally famous, an unsung hero forgotten by history, or even a unique group of people.");
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

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Genre",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "");
        }
    }
}
