using BookStore.Web.Models;
using BookStore.Web.Services.IServices;

namespace BookStore.Web.Services
{
    public class BookService : BaseService, IBookService
    {
        public BookService(IHttpClientFactory httpClient) : base(httpClient)
        {
        }

        public async Task<T> CreateBookAsync<T>(BookViewModel bookDto)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = "",
                ApiTipe = SD.ApiType.POST,
                Data = bookDto,
                Url = SD.BookAPIBase + "/api/books"
            });
        }

        public async Task<T> DeleteBookAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = "",
                ApiTipe = SD.ApiType.DELETE,
                Url = SD.BookAPIBase + "/api/books"
            });
        }

        public async Task<T> GetAllBooksAsync<T>()
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = "",
                ApiTipe = SD.ApiType.GET,
                Url = SD.BookAPIBase + "/api/books"
            });
        }

        public async Task<T> GetBookByIdAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = "",
                ApiTipe = SD.ApiType.GET,
                Url = SD.BookAPIBase + "/api/books/" + id
            });
        }

        public async Task<T> UpdateBookAsync<T>(BookViewModel bookDto)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = "",
                ApiTipe = SD.ApiType.PUT,
                Data = bookDto,
                Url = SD.BookAPIBase + "/api/books"
            });
        }
    }
}
