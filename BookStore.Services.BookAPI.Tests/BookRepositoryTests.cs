using AutoMapper;
using BookStore.Services.BookAPI;
using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.BookAPI.Tests
{
    [TestClass]
    public class BookRepositoryTests
    {
        [TestMethod]
        public void MappingBookToDto_True()
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            Book book = new()
            {
                BookId = 0,
                Name = "Test",
                AreIllustrations = true,
                Price = 100,
                Cover = "test",
                InStock = 1,
                ImageUrl = "test",
                Description = "test",
                Weight = 100,
                YearOfPublication = DateTime.Now,
                NumberOfPages = 100,
                GenreId = 1,
                Genre = new Genre()
                {
                    Id = 1,
                    Description = "genre",
                    Name = "Test",
                }
            };

            var bookDto = mapper.Map<Book, BookDto>(book);
            Assert.AreSame(bookDto, new BookDto() { 
                BookId = 0, 
                Description = "test", 
                Genre = "Test", 
                ImageUrl = "test", 
                Name = "Test",
                Price = 100
            });
        }

        /*[TestMethod]
        public void MappingDtoToBook()
        {
            BookDto bookDto = new BookDto()
            {
                BookId = 0,
                Name = "Test",
                Price = 0,
                Description = "Test",
                Genre = "Test",
                ImageUrl = "Test"
            };
        }*/
    }
}
