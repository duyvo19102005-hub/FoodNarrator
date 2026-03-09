using Microsoft.EntityFrameworkCore;
using food_market_narrator_api.Data;
using food_market_narrator_api.Models;

namespace food_market_narrator_api.Repositories;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly AppDbContext _context;

    public RestaurantRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Restaurant>> GetAllAsync()
    {
        return await _context.Restaurants.Where(r => r.IsActive).ToListAsync();
    }
}