using Library.Services.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Query
{
    public record GetAllBookQuery() : IRequest<IEnumerable<Book>>;
    
}
