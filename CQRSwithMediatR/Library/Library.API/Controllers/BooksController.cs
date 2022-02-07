using Library.Services.Command;
using Library.Services.Model;
using Library.Services.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _mediator.Send(new GetAllBookQuery());

        }

        [HttpPost]
        public async Task<Book> AddBook([FromBody] Book book)
        {
            return await _mediator.Send(new AddBookCommand(book));
        }
    }
}
