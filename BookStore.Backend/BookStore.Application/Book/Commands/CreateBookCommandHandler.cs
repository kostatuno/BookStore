using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using MediatR;

namespace BookStore.Application.Commands
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IBookStoreDbContext _context;
        public CreateBookCommandHandler(IBookStoreDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle
            (CreateBookCommand request, 
            CancellationToken cancellationToken)
        {
            var book = new Book()
            {
                Id = request.Id,
                Name = request.Name
            };

            await _context.Books.AddAsync(book, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return request.Id;
        }
    }
}
