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

        //for unique Style constraint in db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Style>()
                .HasIndex(s => new { s.StyleNumber, s.ColorId, s.SizeId })
                .IsUnique();
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Style> Styles { get; set; }
    }
}
