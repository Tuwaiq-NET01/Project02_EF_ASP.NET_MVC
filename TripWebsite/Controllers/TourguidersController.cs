using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripWebsite.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripWebsite.Controllers
{
    public class TourguidersController : Controller
    {
        private readonly AppDbContext _db;

        public TourguidersController(AppDbContext context)
        {
            _db = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var Tourguiders = _db.Tourguiders.ToList();
            ViewData["Tourguiders"] = Tourguiders;
            return View();
        }

    }
}
