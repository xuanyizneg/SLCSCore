using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SLCSCore.Models;
using SLCSCore.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SLCSCore.Controllers
{
    public class IndexController : Controller
    {

        private readonly IBookService _bookService;
        public IndexController (IBookService bookService)
        {
            _bookService = bookService;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var bookModel = _bookService.GetAll()
                .Select(bs => new Book {
                    B_Id= bs.B_Id,
                    B_BookName=bs.B_BookName,
                    B_Author=bs.B_Author,
                    B_Publisher=bs.B_Publisher,
                    B_PublishYear=bs.B_PublishYear
                }).ToList();



            return View(bookModel);
        }


    }
}
