using AirportSystems.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportSystems.Controllers
{

    public class AirportController : Controller
    {
        private readonly AppDbContext _db;
        public AirportController(AppDbContext context)
        {

            _db = context;
        }


        public ActionResult Index()

        {
            var Airports = _db.Airports.ToList();
            ViewBag.Airport = Airports;
            return View();
        }

     
    }
}
