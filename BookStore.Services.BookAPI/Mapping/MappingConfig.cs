using AutoMapper;
using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;

namespace BookStore.Services.BookAPI.Mapping
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
                config.CreateMap<BookDto, Book>()
                    .ForMember(dst => dst.NumberOfPages, opt => opt.Ignore())
                    .ForMember(dst => dst.YearOfPublication, opt => opt.Ignore())
                    .ForMember(dst => dst.InStock, opt => opt.Ignore())
                    .ForMember(dst => dst.AreIllustrations, opt => opt.Ignore())
                    .ForMember(dst => dst.Cover, opt => opt.Ignore())
                    .ForMember(dst => dst.Weight, opt => opt.Ignore())
                    .ForMember(dst => dst.GenreId, opt => opt.Ignore())
                    .ForMember(dst => dst.Genre, opt => opt.MapFrom(src => new Genre() { Name = src.Genre }));

            });

            return mappingConfig;
        }
    }
}
