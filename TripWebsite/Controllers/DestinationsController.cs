using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripWebsite.Data;
namespace TripWebsite.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly AppDbContext _db;
    
        public DestinationsController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Destinations = _db.Destinations.ToList();
            ViewData["Destinations"] = Destinations;
            return View();
        }

    }
}

