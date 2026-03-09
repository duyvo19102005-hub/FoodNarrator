using food_market_narrator_api.Models;
using food_market_narrator_api.Repositories;

namespace food_market_narrator_api.Services;

public class RestaurantService : IRestaurantService
{
    private readonly IRestaurantRepository _repository;

    public RestaurantService(IRestaurantRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Restaurant>> GetRestaurantsAsync()
    {
        return await _repository.GetAllAsync();
    }
}