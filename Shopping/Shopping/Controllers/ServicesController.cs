using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class ServicesController : Controller
    {
        /*private List<ServiceModel> items = new List<ServiceModel>()
            {
            new ServiceModel() { id = 1, name = "Maintenance / Parts Replacement", price = 200},
            new ServiceModel() { id = 2, name = "Software & Backup", price = 150},
            new ServiceModel() { id = 3, name = "Warranty Extension", price = 100},
            };*/
        public IActionResult Index()
        {


            /*ViewData["Items"] = items;*/
            return View();

        }
        public IActionResult Details(int? id)
        {
           /* ViewData["Items"] = items.Find(model => model.id == id);
            if (id == null)
            {
                return Content("لا يوجد منتج بهذا الرقم");
            }
            else
            {

            }*/

            return View();
        }
    }
}
