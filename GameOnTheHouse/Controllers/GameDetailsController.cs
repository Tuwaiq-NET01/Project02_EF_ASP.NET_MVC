using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GameOnTheHouse.Data;
using GameOnTheHouse.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameOnTheHouse.Controllers
{
    public class GameDetailsController : Controller
    {
        private readonly AppDbContext _db;

        public GameDetailsController(AppDbContext context)
        {
            _db = context;
        }

        // GET: /GameDetails/Index
        //public IActionResult Index(int id)
        public IActionResult Index(int id)
        {
            GameDetail GameDetail = _db.GameDetails.Find(id);
            var gameDetails = _db.GameDetails.Where((game) => game.Id == id).ToList();
            var screenshots = _db.Screenshots.Where((game) => game.GameDetailId == id).ToList();


            ViewData["gameDetail"] = GameDetail;
            ViewData["screenshots"] = screenshots;
            return View();
            //return innerGroupJoinQuery2;
        }
    }
}


