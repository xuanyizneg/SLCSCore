using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SLCSCore.Models;
using SLCSCore.Service;
using SLCSCore.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SLCSCore.Controllers
{
    public class SLCSHomeController : Controller
    {

        private readonly IBookService _bookService;
        public SLCSHomeController(IBookService bookService)
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
                    B_PublishPlace=bs.B_PublishPlace,
                    B_PublishYear=bs.B_PublishYear
                }).ToList();

            var bookGenreVM = new SLCSGenreVM
            {
                Books = bookModel
            
            };

            return View(bookGenreVM);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("B_BookName,B_Author,B_Publisher,B_PublishPlace,B_PublishYear")] Book newBooks)
        {
            var rtnMsg = string.Empty;
            if (ModelState.IsValid)
            {
                rtnMsg = _bookService.CreateBook(newBooks);

            }
            return RedirectToAction(nameof(Index));
        }


    }
}
