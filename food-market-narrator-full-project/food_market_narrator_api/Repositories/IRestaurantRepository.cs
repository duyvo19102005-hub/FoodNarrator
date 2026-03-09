using food_market_narrator_api.Models;

namespace food_market_narrator_api.Repositories;

public interface IRestaurantRepository
{
    Task<List<Restaurant>> GetAllAsync();
}