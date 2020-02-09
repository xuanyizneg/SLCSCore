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

        string IBookService.CreateBook(Book newBooks)
        {

            string rtnMsg = "000000";

            try
            {
                _context.Add(newBooks);
                _context.SaveChanges();
            }
            catch(Exception ex) {
                rtnMsg = ex.Message;
                
            }

            return rtnMsg;
        }
    }
}
