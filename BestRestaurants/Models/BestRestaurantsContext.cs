using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
public class BestRestaurants : AddDbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restuarant>Restuarants { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options)
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}