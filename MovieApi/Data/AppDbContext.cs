using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<MoiveModel> Movies { get; set; }
        
        public DbSet<UserModel> Users { get; set; }
        
        public DbSet<GenreModel> Genres { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}