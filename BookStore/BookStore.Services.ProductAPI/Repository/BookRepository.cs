using AutoMapper;
using BookStore.Services.ProductAPI.Models;
using BookStore.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Services.ProductAPI.Repository
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

        public async Task<BookDto> CreateUpdateBook(BookDto bookDto)
        {
            var book = _mapper.Map<BookDto, Book>(bookDto);
            if (book.BookId > 0) 
            { 
                _context.Books.Update(book);
            }
            else
            {
                _context.Books.Add(book);
            }
            await _context.SaveChangesAsync();
            return _mapper.Map<Book, BookDto>(book);
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

        public async Task<BookDto> GetBookById(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(x => x.BookId == id);
            return _mapper.Map<BookDto>(book);
        }

        public async Task<IEnumerable<BookDto>> GetBooks()
        {
            var books = await _context.Books.ToListAsync();
            return _mapper.Map<List<BookDto>>(books);
        }
    }
}