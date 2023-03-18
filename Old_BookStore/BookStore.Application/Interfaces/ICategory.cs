using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Application.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void NewCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int id);
    }
}
