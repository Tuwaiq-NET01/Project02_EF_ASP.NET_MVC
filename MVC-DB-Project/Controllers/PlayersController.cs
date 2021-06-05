using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_DB_Project.data;

namespace MVC_DB_Project.Controllers
{
    public class PlayersController : Controller
    {
        private readonly AppDbContext _db;

        
        public PlayersController(AppDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var searchbyId = _db.Players.SingleOrDefault(a => a.Id == 2); 
            var searchbynum = _db.Players.Where(a => a.number >7).ToList(); 
            ViewData["sId"] = searchbyId;
            ViewData["sNum"] = searchbynum;

            var Players = _db.Players.ToList();
            ViewData["Players"] = Players;
            return View();
        }
       
    }
}

