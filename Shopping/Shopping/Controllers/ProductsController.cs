using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;
using Shopping.Data;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext context)
        {
            _db = context;
        }


        public IActionResult Index()
        {
            var products = _db.Products.ToList(); 
            ViewData["Products"] = products;

            return View();
                        
        }
        public IActionResult Search(string SearchForName)
        {
            var products = _db.Products.Where(s => s.name.Contains(SearchForName) || s.brand.Contains(SearchForName)).ToList();
            ViewData["Search"] = products;
            return View();
        }
        public IActionResult Details(int? id)
        {
            var products = _db.Products.Where(a => a.id == id).ToList();
            ViewData["Details"] = products;
            return View();
        }

    }
    
}
