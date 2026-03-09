using Microsoft.EntityFrameworkCore;
using food_market_narrator_api.Models;

namespace food_market_narrator_api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Restaurant> Restaurants { get; set; }
}