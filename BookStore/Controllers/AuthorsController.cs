using System.Linq;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var authors = _context.Authors.Include(b=>b.Books).ThenInclude(b=>b.Book).ToList();
            ViewData["Authors"] = authors;
            return View();
        }
    }
}