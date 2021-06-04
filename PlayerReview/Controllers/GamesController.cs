using Microsoft.AspNetCore.Mvc;
using PlayerReview.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerReview.Controllers
{
    public class GamesController : Controller
    {

        private readonly AppDbContext _db; 
        public GamesController(AppDbContext context)
        { 
            _db = context; 
        }



        public IActionResult Index()
        {


            var games = _db.Games.ToList();
            var companies = _db.Companies.ToList();
            ViewData["games"] = games;
            ViewData["companies "] = companies;
            return View();
        }
    }
}
