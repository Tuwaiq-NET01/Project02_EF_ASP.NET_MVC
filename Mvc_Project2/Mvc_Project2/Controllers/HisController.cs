using Microsoft.AspNetCore.Mvc;
using Mvc_Project2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Project2.Controllers
{
    public class HisController : Controller
    {
        private readonly AppDbContext _db;

        public HisController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var planes = _db.Planes.ToList();
            ViewData["Planes"] = planes;

            var passenegrs = _db.passengers.ToList();
            ViewData["Passenegrs"] = passenegrs;

            var countries = _db.Countries.ToList();
            ViewData["Countries"] = countries;

            var bags = _db.Bags.ToList();
            ViewData["Bags"] = bags;

            return View();
        }
    }
}
