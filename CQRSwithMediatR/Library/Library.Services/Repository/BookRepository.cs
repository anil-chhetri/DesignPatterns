using Library.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Repository
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books { get; set; }
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book { Id = 1, Name="Adventures of Tom Sawyer", Author="Mark Twain"},
                new Book {Id = 2 , Name="Time Machine", Author="H.G. Wells"},
                new Book {Id = 3 , Name="Adventures of Sherlock Holmes", Author="Arthur Conan Doyle"},
                new Book {Id = 4 , Name="A Tale of Two Cities", Author="Charles Dickens"},
            };
        }
        public async Task<IEnumerable<Book>> Getall() => await Task.Run(() => books);

        public async Task<Book> AddBookAsync(Book book)
        {
            book.Id = books.Max(b => b.Id) + 1;
            books.Add(book);

            return await Task.Run(() => book);
        }
    }
}
