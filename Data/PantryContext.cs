using Microsoft.EntityFrameworkCore;
using PantryApi.Models;

namespace PantryApi.Data
{
    public class PantryContext : DbContext
    {
        public PantryContext(DbContextOptions<PantryContext> options) : base(options) { }

        public DbSet<Item> Items => Set<Item>();
    }
}
