using System.Linq;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDbContext _context;

        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var publishers = _context.Publishers.Include(b=>b.Books).ToList();
            ViewData["Publishers"] = publishers;
            return View();
        }
    }
}