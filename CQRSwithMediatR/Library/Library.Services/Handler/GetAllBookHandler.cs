using Library.Services.Model;
using Library.Services.Query;
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
    public record GetAllBookHandler : IRequestHandler<GetAllBookQuery, IEnumerable<Book>>
    {
        private readonly IBookRepository _book;

        public GetAllBookHandler(IBookRepository book)
        {
            _book = book;
        }
        public async Task<IEnumerable<Book>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            return await _book.Getall();
        }
    }
}
