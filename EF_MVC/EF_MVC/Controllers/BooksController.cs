using EF_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_MVC.Controllers
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
            var DbBooks = _db.Books.ToList();
            ViewBag.Books = DbBooks;
            return View();
        }
    }
}
