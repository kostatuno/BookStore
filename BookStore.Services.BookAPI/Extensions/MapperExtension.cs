using AutoMapper;
using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;
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
            Genres = new List<Genre>();
        }

        public static Book Map(this IMapper mapper, BookDto source, Book destination)
        {
            var book = mapper.Map<BookDto, Book>(source);

            return new Book();
        }
    }
}
