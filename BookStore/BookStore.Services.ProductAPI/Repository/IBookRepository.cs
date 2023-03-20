using BookStore.Services.ProductAPI.Models.Dto;

namespace BookStore.Services.ProductAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookDto>> GetBooks();
        Task<BookDto> GetBookById(int id);
        Task<BookDto> CreateUpdateBook(BookDto bookDto);
        Task<bool> DeleteBook(int id);
    }
}