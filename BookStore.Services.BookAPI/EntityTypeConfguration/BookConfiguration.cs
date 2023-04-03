using BookStore.Services.BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.BookAPI.EntityTypeConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);
            builder
                .HasOne(f => f.Genre)
                .WithMany(c => c.Books)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new Book[] {
                new Book() {
                    BookId = 1,
                    AreIllustrations = true,
                    Cover = "Soft",
                    Description = "Some Description",
                    GenreId = 3,
                    ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/abraham_lincoln_a_history_vol.i.jpg",
                    InStock = 21,
                    Name = "Abraham Lincoln: A History, Vol. I",
                    Price = 299,
                    Weight = 699,
                    NumberOfPages = 152,
                    YearOfPublication = new DateTime(2009, 04, 17)
                },
                new Book() {
                    BookId = 2,
                    AreIllustrations = false,
                    Cover = "Soft",
                    Description = "Some Description",
                    GenreId = 7,
                    ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/the_book_of_awesome_humour.jpg",
                    InStock = 12,
                    Name = "The book of Awesome Humour",
                    Price = 159,
                    Weight = 329,
                    NumberOfPages = 81,
                    YearOfPublication = new DateTime(2015, 02, 27)
                },
                new Book() {
                    BookId = 3,
                    AreIllustrations = true,
                    Cover = "Solid",
                    Description = "Some Description",
                    GenreId = 2,
                    ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/the_water_is_wide_pat_conroy.jpg",
                    InStock = 51,
                    Name = "The water is wide",
                    Price = 512,
                    Weight = 999,
                    NumberOfPages = 187,
                    YearOfPublication = new DateTime(2007, 11, 1)
                },
                new Book() {
                    BookId = 4,
                    AreIllustrations = false,
                    Cover = "Solid",
                    Description = "Some Description",
                    GenreId = 1,
                    ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/war_and_peace.jpg",
                    InStock = 71,
                    Name = "War and Peace",
                    Price = 499,
                    Weight = 699,
                    NumberOfPages = 132,
                    YearOfPublication = new DateTime(1881, 02, 15)
                },
            });
        }
    }
}
