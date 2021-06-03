using furnitureStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furnitureStore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Categories = _db.Categories.ToList();
            ViewData["Categories"] = Categories;
            return View();
        }

        public IActionResult Details(int id)
        {
            var a = _db.Categories.ToList().Find(a => a.Id == id);
            ViewData["Categories"] = a;
            return View();
        }
    }
}

