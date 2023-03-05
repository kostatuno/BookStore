using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Interfaces
{
    public interface IBookStoreDbContext
    {
        DbSet<Book> Books { get; set; }
    }
}
