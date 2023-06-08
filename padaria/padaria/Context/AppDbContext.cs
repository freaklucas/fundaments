using Microsoft.EntityFrameworkCore;
using padaria.Models;

namespace padaria.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Padaria> Padarias { get; set; }


    }
}
