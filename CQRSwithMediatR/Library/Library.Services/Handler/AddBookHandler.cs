using Library.Services.Command;
using Library.Services.Model;
using Library.Services.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Services.Handler
{
    public class AddBookHandler : IRequestHandler<AddBookCommand, Book>
    {
        private readonly IBookRepository _book;

        public AddBookHandler(IBookRepository book)
        {
            _book = book;
        }
        public async Task<Book> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            return await _book.AddBookAsync(request.book);
        }
    }
}
