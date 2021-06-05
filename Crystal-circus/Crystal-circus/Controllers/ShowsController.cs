using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crystal_circus.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crystal_circus.Controllers
{
    public class ShowsController : Controller
    {
        private readonly AppDbContext _db;

        public ShowsController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["shows"] = _db.Shows.ToList();
            ViewData["venues"] = _db.Venues.ToList();
            return View();
        }
    }
}
