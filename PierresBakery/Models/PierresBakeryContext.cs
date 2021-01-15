using Microsoft.EntityFrameworkCore;

namespace PierresBakery.Models
{
  public class PierresBakeryContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; } 
    public DbSet<Flavor> Flavors { get; set; }

    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public PierresBakeryContext(DbContextOptions options) : base(options) { } 
  }
}