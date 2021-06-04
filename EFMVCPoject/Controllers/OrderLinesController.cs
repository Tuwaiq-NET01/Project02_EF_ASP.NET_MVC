using EFMVCPoject.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVCPoject.Controllers
{
    public class OrderLinesController : Controller
    {
        private readonly AppDbContext _db;

        public OrderLinesController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var orderLines = _db.OrderLines.ToList();
            ViewData["OrderLines"] = orderLines;
            return View();
        }
    }
}
