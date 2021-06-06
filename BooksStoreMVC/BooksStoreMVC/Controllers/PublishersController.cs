using BooksStoreMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksStoreMVC.Controllers
{
    public class PublishersControllers : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _db;

        public PublishersControllers(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
           

            var DbPublishers = _db.Publishers.ToList();
            ViewBag.Publishers = DbPublishers;
            return View();
        }
    }
}
