using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using animeik.Data;
using animeik.Models;
using Microsoft.AspNetCore.Mvc;

namespace animeik.Controllers
{
    public class AnimeController : Controller
    {
        private readonly AppDbContext _db;
        public AnimeController(AppDbContext context)
        {
            _db = context;
        }
        // GET
        public IActionResult Index(int id)
        {
            
            // LINQ
            ViewData["list"] = _db.Animes.ToList();
            return View();
        }
        
        
        // LINQ
        public IActionResult Details(int id)
        {
            ViewData["anime"] =_db.Animes.FirstOrDefault(a => a.id == id);
            return View();
        }

        public IActionResult Search(string animeName)
        {
            var aa = _db.Animes.Where(a => a.title.Contains(animeName)).ToList();
            ViewData["list"] = aa;
            return View("Index");
        }
        //
        //
        // public JsonObj getaListfromAPI(string url)
        // {
        //     var client = new HttpClient();
        //     client.DefaultRequestHeaders.Add("x-rapidapi-key", "f628437b3cmsh2fa811b8eb8b3dep14e7d2jsnd1d1125259c8");
        //     client.DefaultRequestHeaders.Add("x-rapidapi-host", "jikan1.p.rapidapi.com");
        //     var RequestUri = new Uri(url);
        //     var response = client.GetAsync(RequestUri);
        //     response.Wait();
        //     var result = response.Result.Content.ReadAsStringAsync();
        //     JsonObj v = JsonSerializer.Deserialize<JsonObj>(result.Result);
        //     return v;
        // }
    }
}

