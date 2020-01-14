using System;
using System.Collections.Generic;
using System.Linq;
using SLCSCore.Data;
using SLCSCore.Models;

namespace SLCSCore.Service
{
    public class BookService : IBookService
    {
        private readonly SLCSContext _context;

        public BookService(SLCSContext context)
        {
            _context=context;
        }

        public IEnumerable<Book> GetByAuthor(string value)
        {
            return _context.Book.Where(b => b.B_Author == value);
        }

        IEnumerable<Book> IBookService.GetAll()
        {
            return _context.Book;
        }

        IEnumerable<Book> IBookService.GetByBookName(string value)
        {
            return _context.Book.Where(b=>b.B_BookName ==value);
        }

    }
}
