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
                config.CreateMap<Book, BookDto>()
                    .ForMember(dst => dst.Genre, opt =>
                    opt.MapFrom(src => src.Genre.Name));
                config.CreateMap<BookDto, Book>();
            });

            return mappingConfig;
        }
    }
}
