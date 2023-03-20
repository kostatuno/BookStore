using AutoMapper;
using BookStore.Services.ProductAPI.Models;
using BookStore.Services.ProductAPI.Models.Dto;

namespace BookStore.Services.ProductAPI
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
