using Library.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Getall();

        Task<Book> AddBookAsync(Book book);
    }
}
