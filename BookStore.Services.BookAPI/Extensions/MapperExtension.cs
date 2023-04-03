using AutoMapper;
using BookStore.Services.BookAPI.Exceptions;
using BookStore.Services.BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.BookAPI.Extensions
{
    public static class MapperExtension
    {
        public static List<Genre> Genres { get; set; }
        static MapperExtension()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new ApplicationDbContext(options))
                Genres = db.Genre.ToList();
        }

        public static Book Map(this IMapper mapper, BookViewModel source)
        {
            var genre = Genres.FirstOrDefault(g => g.Name == source.Genre);

            if (genre is null)
                throw new AutoMapperNoSuchGenreException();
                
            var book = mapper.Map<BookViewModel, Book>(source);

            book.GenreId = genre.Id;
            book.Genre = genre;

            return book;
        }
    }
}
