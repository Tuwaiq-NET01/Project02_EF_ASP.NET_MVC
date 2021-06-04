using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project01.Models;
using Project01.Data;

namespace Project01.Controllers
{
    public class Items : Controller
    {
        private readonly AppDbContext _db;

        public Items(AppDbContext context) {
            _db = context;
        }

        //List<ItemModel> itemsList = new List<ItemModel>() {
        //   new ItemModel {ID=1, Name="Mango", Price=2393, Quantity= 1, Image ="https://www.luluhypermarket.com/medias/1428514-01.jpg-1200Wx1200H?context=bWFzdGVyfGltYWdlc3wyODQ2OTd8aW1hZ2UvanBlZ3xpbWFnZXMvaDdiL2gxMC9oMDAvOTE5OTI2NjI5OTkzNC5qcGd8YWRhM2ZkODFiYjhmZDg3MzhmNzUwMzc1MmJlNTU0ZTQ4M2FhMTZiZDBjMDRlZThmYWZlMjUwZjIyNDQ2ZWNkYg", Description = "Fruits", Type="Fruit" },
        //   new ItemModel {ID=1, Name="Banana", Price=2393, Quantity= 1, Image ="http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Fruits", Type="Fruit" },
        //   new ItemModel {ID=1, Name="Banana", Price=2393, Quantity= 1, Image ="http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Fruits", Type="Fruit" },
        //   new ItemModel {ID=1, Name="Banana", Price=2393, Quantity= 1, Image ="http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Fruits", Type="Fruit" },
        //   new ItemModel {ID=1, Name="Banana", Price=2393, Quantity= 1, Image ="http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Fruits", Type="Fruit" },
        //   new ItemModel {ID=1, Name="Banana", Price=2393, Quantity= 1, Image ="http://cdn.shopify.com/s/files/1/2154/4937/products/banana_600x.jpg?v=1610541466", Description = "Fruits", Type="Fruit" }

        //};
        public IActionResult Shop()
        {
            var items = _db.Items.ToList();
            ViewData["Items"] = items;
            return View();
        }

        public IActionResult Details(int id)
        {
            var items = _db.Items.ToList();
            ItemModel item = items.Find(P => P.ID == id);
            if (item == null)
            {
                return Content("No item in this name");
            }
            else
            {
                ViewData["Items"] = item;
                return View();
            }
        }

        public IActionResult Cart(int id)
        {
            var items = _db.Items.ToList();
            ItemModel item = items.Find(P => P.ID == id);
            if (item == null)
            {
                return Content("No item in this name");
            }
            else
            {
                ViewData["Items"] = item;
                return View();
            }
        }

    }
}
