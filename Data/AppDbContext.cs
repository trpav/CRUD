using freecodecamp.Models;
using Microsoft.EntityFrameworkCore;

namespace freecodecamp.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories{ get; set; }
    }
}
