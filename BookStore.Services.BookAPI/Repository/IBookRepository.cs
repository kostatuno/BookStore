using BookStore.Services.BookAPI.Models;


namespace BookStore.Services.BookAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookViewModel>> GetBooks();
        Task<BookViewModel> GetBookById(int id);
        Task<BookViewModel> CreateUpdateBook(BookViewModel bookView);
        Task<bool> DeleteBook(int id);
    }
}