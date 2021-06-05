using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compound.Models;
using Compound.Data;

namespace Compound.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Services = _context.Services.ToList();
            var Staff = _context.Staff.ToList();
            ViewData["Services"] = Services;
            ViewData["Staff"] = Staff;
            return View();
        }
    }
}
