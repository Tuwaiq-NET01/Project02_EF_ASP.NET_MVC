using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksStoreMVC.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksStoreMVC.Controllers
{
    public class AuthersController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _db;

        public AuthersController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
           
            var DbAuthers = _db.Authers.ToList();
            ViewBag.Authers = DbAuthers;
            return View();
        }
    }
}
