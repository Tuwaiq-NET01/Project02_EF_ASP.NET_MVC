using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Data;
using MovieApi.Models;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("Movies")]
    public class MoviesApiController : Controller
    {
        private readonly AppDbContext _db;
        public MoviesApiController(AppDbContext context)
        {
            this._db = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieModel>> GetMovie(int id)
        {
            return await _db.Movies.FindAsync(id);
        }

    }
}