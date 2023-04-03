using BookStore.Web.Models;

namespace BookStore.Web.Services.IServices
{
    public interface IBookService : IBaseService
    {
        Task<T> GetAllBooksAsync<T>();
        Task<T> GetBookByIdAsync<T>(int id);
        Task<T> CreateBookAsync<T>(BookViewModel bookDto);
        Task<T> UpdateBookAsync<T>(BookViewModel bookDto);
        Task<T> DeleteBookAsync<T>(int id);

    }
}
