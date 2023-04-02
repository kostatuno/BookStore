using AutoMapper;
using BookStore.Services.BookAPI.Extensions;
using BookStore.Services.BookAPI.Mapping;
using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.BookAPI.Tests
{
    public class MappingConfigTests
    {
        [Fact]
        public void Map_BookToDto_True()
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            Book book = new()
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
                YearOfPublication = DateTime.Now,
                NumberOfPages = 100,
                GenreId = 1,
                Genre = new Genre()
                {
                    Id = 1,
                    Description = "test",
                    Name = "test",
                }
            };

            var bookDto = mapper.Map<Book, BookDto>(book);
            Assert.True(bookDto.Equals(new BookDto()
            {
                BookId = 0,
                Description = "test",
                Genre = "test",
                ImageUrl = "test",
                Name = "test",
                Price = 0
            }));
        }

        [Fact]
        public void Map_DtoToBook_GenreIsNotNull()
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            BookDto bookDto = new BookDto()
            {
                BookId = 0,
                Name = "test",
                Price = 0,
                Description = "test",
                Genre = "test",
                ImageUrl = "test"
            };

            var book = mapper.Map<BookDto, Book>(bookDto);

            Assert.True(book.Genre != null);
        }

        [Fact]
        public void Map_DtoToBook_NameOfGenreIsNotNull()
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            BookDto bookDto = new BookDto()
            {
                BookId = 0,
                Name = "test",
                Price = 0,
                Description = "test",
                Genre = "test",
                ImageUrl = "test"
            };

            var book = mapper.Map<BookDto, Book>(bookDto);

            Assert.True(book.Genre.Name != null);
        }

        [Fact]
        public void Map_DtoToBook_NameOfGenreIsCalledsomeGenre()
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            BookDto bookDto = new BookDto()
            {
                BookId = 0,
                Name = "test",
                Price = 0,
                Description = "test",
                Genre = "someGenre",
                ImageUrl = "test"
            };

            var book = mapper.Map<BookDto, Book>(bookDto);
            Assert.True(book.Genre.Name == "someGenre");
        }

        [Fact]
        public void Map_DtoToBook_ThereIsTheGenreInDb()
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            BookDto bookDto = new BookDto()
            {
                BookId = 0,
                Name = "test",
                Price = 0,
                Description = "test",
                Genre = "Politics1",
                ImageUrl = "test"
            };

            

            var book = mapper.Map(bookDto);
            Assert.True(book.Genre.Name == "Politics1");
        }
    }
}
