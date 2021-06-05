using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project02_EF_ASP.NET_MVC.Data;

namespace Project02_EF_ASP.NET_MVC.Controllers
{
    public class CarsController : Controller
    {
        private readonly AppDbContext _db;

        public CarsController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Cars = _db.Cars.ToList();
            ViewBag.Data = Cars;
            return View();
        }
    }
}
