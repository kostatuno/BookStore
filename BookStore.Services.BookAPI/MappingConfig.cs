using AutoMapper;
using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;

namespace BookStore.Services.BookAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Book, BookDto>();
                config.CreateMap<BookDto, Book>();
            });

            return mappingConfig;
        }
    }
}
