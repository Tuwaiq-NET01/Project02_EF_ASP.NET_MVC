using EFMVCPoject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _db;

        public OrdersController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var orders = _db.Orders.ToList();
            ViewData["Orders"] = orders;
            return View();
        }
    }
}
