using BookStore.Entities;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data
{
    public interface IBook
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetPreferred(int count);
        IEnumerable<Book> GetBookByCategoryId(int categoryId);
        IEnumerable<Book> GetFilteredBook(int id, string searchQuery);
        IEnumerable<Book> GetFilteredBook(string searchQuery);
        Food GetById(int id);
        void NewBook(Book book);
        void EditBook(Book book);
        void DeleteBook(int id);
    }
}
