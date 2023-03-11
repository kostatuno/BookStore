using BookStore.Application.Book.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.WebApi.Controllers
{
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task CreateBookCommant(CreateBookCommand createBookCommand)
        {
            var result = await _mediator.Send(createBookCommand);
            return Ok(result);
        }
    }
}
