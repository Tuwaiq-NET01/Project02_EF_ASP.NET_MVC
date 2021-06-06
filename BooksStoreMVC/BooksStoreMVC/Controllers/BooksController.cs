
using BooksStoreMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksStoreMVC.Controllers
{
    public class BooksController : Controller
    {
        // GET: /<controller>/
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

