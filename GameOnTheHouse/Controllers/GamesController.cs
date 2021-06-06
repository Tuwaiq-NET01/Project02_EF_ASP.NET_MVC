using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOnTheHouse.Data;
using GameOnTheHouse.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace GameOnTheHouse.Controllers
{
    public class GamesController : Controller
    {

        private readonly AppDbContext _db;

        public GamesController(AppDbContext context)
        {
            _db = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var Games = _db.Games.ToList();
            ViewData["Games"] = Games;
            return View();
        }
    }
}
