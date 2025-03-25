using Microsoft.EntityFrameworkCore;
using StyleManagerApiZizzi.Models;

namespace StyleManagerApiZizzi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Style> Styles { get; set; }
    }
}
