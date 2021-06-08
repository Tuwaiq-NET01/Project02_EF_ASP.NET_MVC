using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeachMe.Models;

namespace TeachMe.Controllers
{
    public class CategoryController : Controller
    {
         List<CategoryModel> _Category = new List<CategoryModel>()
        {
            
         new CategoryModel { Category_ID = 1, Category_Name ="AI", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU",Category_Description=""},
         new CategoryModel { Category_ID = 2, Category_Name ="Cyber Security", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU",Category_Description=""},
         new CategoryModel { Category_ID = 3, Category_Name ="Programming", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU",Category_Description="" },
         new CategoryModel { Category_ID = 4, Category_Name ="Data Sience", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU",Category_Description="" },

        };

        public IActionResult Index()
        {
             

            ViewData["CategoryModels"] = _Category; // List NAME

            return View(_Category);
        }
    }
}
