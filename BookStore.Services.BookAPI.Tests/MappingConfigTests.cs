using AutoMapper;
using BookStore.Services.BookAPI.Exceptions;
using BookStore.Services.BookAPI.Extensions;
using BookStore.Services.BookAPI.Mapping;
using BookStore.Services.BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services.BookAPI.Tests
{
    public class MappingConfigTests
    {
        [Fact]
        public void Map_BookToBookView_True()
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
                YearOfPublication = new DateTime(2000, 01, 01),
                NumberOfPages = 100,
                GenreId = 1,
                Genre = new Genre()
                {
                    Id = 1,
                    Description = "test",
                    Name = "test",
                }
            };

            var bookView = mapper.Map<Book, BookViewModel>(book);

            Assert.True(bookView.Equals(new BookViewModel()
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
                Genre = "test"
            }));
        }

        [Fact]
        public void Map_BookViewToBook_GenreIsNotNull()
        {
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
                Genre = "test"
            };

            var book = mapper.Map<BookViewModel, Book>(bookView);

            Assert.NotNull(book.Genre);
        }

        [Fact]
        public void Map_BookViewToBook_NameOfGenreIsNotNull()
        {
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
                Genre = "test"
            };

            var book = mapper.Map<BookViewModel, Book>(bookView);

            Assert.NotNull(book.Genre.Name);
        }

        [Fact]
        public void Map_BookViewToBook_NameOfGenreIsCalledsomeGenre()
        {
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
                Genre = "someGenre"
            };

            var book = mapper.Map<BookViewModel, Book>(bookView);
            Assert.True(book.Genre.Name == "someGenre");
        }


        [Fact]
        public void Map_BookViewToBook_AutoMapperNoSuchGenreException()
        {
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
                Genre = "test"
            };

            var book = new Book();
            Assert.Throws<AutoMapperNoSuchGenreException>(() =>
            {
                book = mapper.Map(bookView);
            });
        }

        [Fact]
        public void Map_BookViewToBook_ThereWontBeAutoMapperNoSuchGenreException()
        {
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
                Genre = "Politics"
            };

            var book = mapper.Map(bookView);
            Assert.True(book.Genre.Name == "Politics");
        }
    }
}
