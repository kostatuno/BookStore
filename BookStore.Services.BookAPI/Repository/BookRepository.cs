using AutoMapper;
using BookStore.Services.BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using BookStore.Services.BookAPI.Extensions;

namespace BookStore.Services.BookAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookViewModel> CreateUpdateBook(BookViewModel bookView)
        {
            var book = _mapper.Map(bookView);
            var genre = book.Genre;
            
            if (book.BookId > 0) 
            { 
                _context.Books.Update(book);
            }
            else
            {
                book.Genre = null;
                _context.Books.Add(book);
            }
            
            await _context.SaveChangesAsync();
            book.Genre = genre;
            return _mapper.Map<Book, BookViewModel>(book);
        }

        public async Task<bool> DeleteBook(int id)
        {
            try
            {
                var book = await _context.Books.FirstOrDefaultAsync(x => x.BookId == id);
                if (book == null) 
                {
                    return false;
                }
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<BookViewModel> GetBookById(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.BookId == id);
            await _context.Entry(book).Reference(x => x.Genre).LoadAsync();
            return _mapper.Map<BookViewModel>(book);
        }

        public async Task<IEnumerable<BookViewModel>> GetBooks()
        {
            var books = await _context.Books.Include(b => b.Genre).ToListAsync();
            return _mapper.Map<List<BookViewModel>>(books);
        }
    }
}