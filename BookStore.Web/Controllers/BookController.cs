using BookStore.Web.Models;
using BookStore.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

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
            var books = new List<BookViewModel>();
            var response = await _bookService.GetAllBooksAsync<ResponseDto>();
            if (response is not null && response.IsSuccess == true)
            {
                books = JsonConvert.DeserializeObject<List<BookViewModel>>(Convert.ToString(response.Result));
            }
            ViewData["books"] = books;
            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var bookDto = new BookViewModel();
            var response = await _bookService.GetBookByIdAsync<ResponseDto>(id);
            if (response is not null && response.IsSuccess == true)
            {
                bookDto = JsonConvert.DeserializeObject<BookViewModel>(Convert.ToString(response.Result));
            }
            return View(bookDto);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            object result = new();
            var response = await _bookService.DeleteBookAsync<ResponseDto>(id);
            if (response is not null && response.IsSuccess == true)
            {
                result = JsonConvert.DeserializeObject<string>(Convert.ToString(response.Result));
            }
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookViewModel bookDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _bookService.CreateBookAsync<ResponseDto>(bookDto);
                if (response is not null && response.IsSuccess == true)
                {
                    return RedirectToAction(nameof(GetAll));
                }
            }
            return View(bookDto);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(BookViewModel bookDto)
        {
            var bookDtoResult = new BookViewModel();
            var response = await _bookService.UpdateBookAsync<ResponseDto>(bookDto);
            if (response is not null && response.IsSuccess == true)
            {
                bookDtoResult = JsonConvert.DeserializeObject<BookViewModel>(Convert.ToString(response.Result));
            }
            return View(bookDtoResult);
        }
    }
}
