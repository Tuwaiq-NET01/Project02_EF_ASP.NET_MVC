using LibraryBook.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBook.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _db;

        public BooksController(AppDbContext context)

        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Books = _db.Books.ToList();
            ViewData["Books"] = Books;
            return View();
        }
    }
}
