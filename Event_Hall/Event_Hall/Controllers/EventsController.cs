using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_Hall.Data;
using Microsoft.EntityFrameworkCore;

namespace Event_Hall.Controllers
{
    public class EventsController : Controller
    {
        private readonly AppDbContext _db;

        public EventsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var DbEvents = _db.Events.ToList();
            ViewBag.Events = DbEvents;
            return View();
        }
    }
}
