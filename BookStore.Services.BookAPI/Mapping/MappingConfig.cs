using AutoMapper;
using BookStore.Services.BookAPI.Models;

namespace BookStore.Services.BookAPI.Mapping
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Book, BookViewModel>()
                    .ForMember(dst => dst.Genre, opt =>
                    opt.MapFrom(src => src.Genre.Name));
                config.CreateMap<BookViewModel, Book>()
                    .ForMember(dst => dst.GenreId, opt => opt.Ignore())
                    .ForMember(dst => dst.Genre, opt => opt.MapFrom(src => new Genre() { Name = src.Genre }));
            });

            return mappingConfig;
        }
    }
}
