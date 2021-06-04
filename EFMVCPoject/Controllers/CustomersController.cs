using EFMVCPoject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db;

        public CustomersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var customers = _db.Customers.ToList();
            ViewData["Customers"] = customers;
            return View();
        }
    }
}
