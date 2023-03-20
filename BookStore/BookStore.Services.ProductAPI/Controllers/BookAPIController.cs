using BookStore.Services.ProductAPI.Models.Dto;
using BookStore.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Services.ProductAPI.Controllers
{
    [Route("api/books")]
    public class BookAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IBookRepository _bookRepository;

        public BookAPIController(IBookRepository bookRepository)
        {
            _response = new ResponseDto();
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                var booksDto = await _bookRepository.GetBooks();
                _response.Result = booksDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                var bookDto = await _bookRepository.GetBookById(id);
                _response.Result = bookDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
