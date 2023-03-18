using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class BookService : IBook
    {
        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void EditBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooksByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetFilteredBooks(int id, string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetFilteredBooks(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetPreferred(int count)
        {
            throw new NotImplementedException();
        }

        public void NewBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
