using food_market_narrator_api.Models;

namespace food_market_narrator_api.Services;

public interface IRestaurantService
{
    Task<List<Restaurant>> GetRestaurantsAsync();
}