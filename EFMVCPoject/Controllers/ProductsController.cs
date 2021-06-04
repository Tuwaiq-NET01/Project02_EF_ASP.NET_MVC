using EFMVCPoject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Controllers
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
    }
}
