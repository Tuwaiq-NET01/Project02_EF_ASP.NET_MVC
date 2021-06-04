using Microsoft.EntityFrameworkCore;
using PlayerReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerReview.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }



    }
}
