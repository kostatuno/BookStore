using BookStore.Services.BookAPI.Models;

namespace BookStore.Services.BookAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookViewModel>> GetBooks();
        Task<BookViewModel> GetBookById(int id);
        Task<BookViewModel> CreateUpdateBook(BookViewModel bookDto);
        Task<bool> DeleteBook(int id);
    }
}