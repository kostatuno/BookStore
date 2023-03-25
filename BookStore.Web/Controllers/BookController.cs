using BookStore.Web.Models;
using BookStore.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _bookService.GetAllBooksAsync<ResponseDto>();
            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _bookService.GetBookByIdAsync<ResponseDto>(id);
            return View(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _bookService.DeleteBookAsync<ResponseDto>(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookDto bookDto)
        {
            var response = await _bookService.CreateBookAsync<ResponseDto>(bookDto);
            return View(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id)
        {
            var response = await _bookService.DeleteBookAsync<ResponseDto>(id);
            return View(response);
        }


    }
}
