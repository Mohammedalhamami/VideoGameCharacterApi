using Microsoft.EntityFrameworkCore;
//using VideoGameCharacterApi.Models; // adjust namespace

namespace VideoGameCharacterApi.Data
{
    public class PgDbContext : DbContext
    {
        public PgDbContext(DbContextOptions<PgDbContext> options)
            : base(options)
        {
        }

        // Database tables
        //public DbSet<User> Users { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}
