using System;
using System.Collections.Generic;
using SLCSCore.Models;

namespace SLCSCore.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetByBookName(string value);
        IEnumerable<Book> GetByAuthor(string value);
    }
}
