using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface IFood
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetPreferred(int count);
        IEnumerable<Book> GetBooksByCategoryId(int categoryId);
        IEnumerable<Book> GetFilteredBooks(int id, string searchQuery);
        IEnumerable<Book> GetFilteredBooks(string searchQuery);
        Book GetById(int id);
        void NewBooks(Book book);
        void EditBooks(Book book);
        void DeleteBooks(int id);
    }
}
