using AutoMapper;
using BookStore.Services.BookAPI.Exceptions;
using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;
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

        public static Book Map(this IMapper mapper, BookDto source)
        {
            if (!Genres.Any(g => g.Name == source.Genre))
                throw new AutoMapperNoSuchGenreException();

            var book = mapper.Map<BookDto, Book>(source);

            return book;
        }
    }
}
