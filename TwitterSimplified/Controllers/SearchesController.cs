using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterSimplified.Data;
namespace TwitterSimplified.Controllers
{
    public class SearchesController : Controller
    {
        private readonly AppDbContext _db;

        public SearchesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Search(string txt)
        {
            var user = _db.Users.Where(u => u.Username.Contains(txt)).ToList();
            ViewData["User"] = user;
            return View();
        }
    }
}
