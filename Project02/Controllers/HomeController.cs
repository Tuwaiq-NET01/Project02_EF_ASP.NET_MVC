using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project01.Data;

namespace Project01.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbModel;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _dbModel = context;
        }

        string homeBar = "https://thermaltake.azureedge.net/pub/media/catalog/product/cache/e4fc6e308b66431a310dcd4dc0838059/l/2/l20m01.jpg";

        public IActionResult Index()
        {
            ViewData["homeBar"] = homeBar;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //User login 
        //[HttpPost]
        public IActionResult Login(CustomerModel customer)
        {
            using (_dbModel)
            {
                var userDetails = _dbModel.Customers.Where(info => info.Name == customer.Name && info.Password == customer.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    
                    return View("Login", customer);
                }
                else
                {
                    ViewData["userDetails"] = userDetails;
                    return View("userProfile");
                }
            }
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View("Login");
        }

        public IActionResult Create()
        {
            return View("Register");
        }

        //CRUD: Create User #1Bouns
        [HttpPost]
        public ActionResult Create(CustomerModel addCustomer)

        {
            try
            {
                using (_dbModel)
                {
                    _dbModel.Customers.Add(addCustomer);
                    _dbModel.SaveChanges();
                    return View("Index");
                }
            }
            catch
            {
                return View();
            }
            
        }
    }
}
