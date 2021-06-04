using furnitureStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using furnitureStore.Data;
using furnitureStore.Models;
namespace furnitureStore.Controllers
{
    public class FurnituresController : Controller
    {
        private readonly AppDbContext _db;
        public FurnituresController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Furnitures = _db.furnitures.ToList();
            ViewData["Furniture"] = Furnitures;
            return View();
        }
        public IActionResult Carpet()
        {
            List<Furniture> Furnitures = new List<Furniture>()
            {
                new Furniture {Id = 5 , Name="LORENA CANALS" ,Price = 1000 , Image = "https://www.amara.com/static/uploads/images-2/products/huge/173249/woolable-lakota-washable-rug-140x200cm-day-443275.jpg"},
                 new Furniture {Id = 6 , Name="ABYSS & HABIDECOR" ,Price = 1200 , Image = "https://www.amara.com/static/uploads/images-2/products/huge/153184/paros-bath-mat-800-305496.jpg"},
            };


            ViewData["Furniture"] = Furnitures;
            return View();
        }
    }
}
