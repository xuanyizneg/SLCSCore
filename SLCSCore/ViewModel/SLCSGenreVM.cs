using System;
using System.Collections.Generic;
using SLCSCore.Models;
using SLCSCore.ViewModel;

namespace SLCSCore.ViewModel
{
    public class SLCSGenreVM
    {
           public List<Book> Books { get; set; }
           public BookFiliter SearchBook { get; set; } 
    }
}
