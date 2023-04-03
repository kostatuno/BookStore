using AutoMapper;
using BookStore.Services.BookAPI.Mapping;
using BookStore.Services.BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Services.BookAPI.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookStore.Services.BookAPI.Tests
{
    public class ApplicationDbContextTests
    {
        public DbContextOptions<ApplicationDbContext> Options { get; set; }
        public ApplicationDbContextTests()
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            Options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        [Fact]
        public void SaveChanges_AddBook_DbException()
        {
            using var db = new ApplicationDbContext(Options);
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            BookViewModel bookView = new BookViewModel()
            {
                BookId = 0,
                Name = "test",
                AreIllustrations = true,
                Price = 0,
                Cover = "test",
                InStock = 1,
                ImageUrl = "test",
                Description = "test",
                Weight = 100,
                YearOfPublication = new DateTime(2000, 01, 01),
                NumberOfPages = 100,
                Genre = "Humor"
            };

            var book = mapper.Map(bookView);

            Assert.Throws<DbUpdateException>(() =>
            {
                db.Books.Add(book);
                db.SaveChanges();
            });
        }
    }
}
