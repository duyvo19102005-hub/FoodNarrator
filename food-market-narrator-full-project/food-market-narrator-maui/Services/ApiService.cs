using System.Net.Http.Json;
using FoodMarketNarrator.Models;

namespace FoodMarketNarrator.Services;

public class ApiService
{
    private readonly HttpClient _client;

    public ApiService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<POI>> GetRestaurants()
    {
        return await _client.GetFromJsonAsync<List<POI>>("api/restaurant");
    }
}