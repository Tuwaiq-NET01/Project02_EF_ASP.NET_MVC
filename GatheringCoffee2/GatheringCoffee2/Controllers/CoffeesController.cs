using GatheringCoffee2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee2.Controllers
{
    public class CoffeesController : Controller
    {

        private readonly AppDbContext _db;

        public CoffeesController(AppDbContext context)
        {
            _db = context;
        }
        //  /Coffees/
        public IActionResult Index()
        {
           /* var Coffees = _db.Coffee.ToList();
            ViewData["Coffees"] = Coffees;*/
            return View();
        }

        //  /Coffees/HotCoffee/
        public IActionResult HotCoffee()
        {
            var Coffees1 = _db.Coffee.Where(record => record.CoffeeCategoryId==1 ).ToList();
            ViewData["HotCoffeeModel"] = Coffees1;
            return View();
        }
        //  /Coffees/ColdCoffee/
        public IActionResult ColdCoffee()
        {
            var Coffees2 = _db.Coffee.Where(record => record.CoffeeCategoryId==2).ToList();
            ViewData["ColdCoffeeModel"] = Coffees2;
            return View();
        }
    }
}
