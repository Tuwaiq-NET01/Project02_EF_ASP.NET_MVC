using GatheringCoffee2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Controllers
{
    public class SweetsAndFoodsController : Controller
    {
        private readonly AppDbContext _db;

        public SweetsAndFoodsController(AppDbContext context)
        {
            _db = context;
        }
        //  /SweetsAndFoods/
        public IActionResult Index()
        {
            return View();
        }
        //  /SweetsAndFoods/Sweet/
        public IActionResult Sweet()
        {
            var Sweets = _db.SweetAndFood.Where(record => record.SweetAndFoodCategoryId==1).ToList();
            ViewData["Sweets"] = Sweets;
            return View();
        }
        //  /SweetsAndFoods/Food/
        public IActionResult Food()
        {
            var Foods = _db.SweetAndFood.Where(record => record.SweetAndFoodCategoryId == 2).ToList();
            ViewData["Foods"] = Foods;
            return View();
        }
    }
}
