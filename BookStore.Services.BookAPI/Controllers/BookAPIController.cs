using BookStore.Services.BookAPI.Models;
using BookStore.Services.BookAPI.Models.Dto;
using BookStore.Services.BookAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Services.BookAPI.Controllers
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
                var bookView = await _bookRepository.GetBooks();
                _response.Result = bookView;
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
                var bookView = await _bookRepository.GetBookById(id);
                _response.Result = bookView;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] BookViewModel bookView)
        {
            try
            {
                var model = await _bookRepository.CreateUpdateBook(bookView);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] BookViewModel bookView)
        {
            try
            {
                var model = await _bookRepository.CreateUpdateBook(bookView);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                var isSuccess = await _bookRepository.DeleteBook(id);
                _response.Result = isSuccess;
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
