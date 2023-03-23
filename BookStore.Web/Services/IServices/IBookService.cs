﻿using BookStore.Web.Models;

namespace BookStore.Web.Services.IServices
{
    public interface IBookService
    {
        Task<T> GetAllBooksAsync<T>();
        Task<T> GetAllByIdAsync<T>(int id);
        Task<T> CreateBookAsync<T>(BookDto bookDto);
        Task<T> UpdateBookAsync<T>(BookDto bookDto);
        Task<T> DeleteBookAsync<T>(int id);

    }
}
