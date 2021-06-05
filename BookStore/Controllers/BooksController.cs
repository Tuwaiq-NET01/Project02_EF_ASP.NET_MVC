using System;
using System.Linq;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var books = _context.Books.Include(b => b.Authors).ThenInclude(a => a.Author)
                .Include(c => c.Category).Include(p => p.Publisher).ToList();
            ViewData["Books"] = books;
            return View();
        }
    }
}