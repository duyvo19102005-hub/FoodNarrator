using Microsoft.AspNetCore.Mvc;
using food_market_narrator_api.Services;

namespace food_market_narrator_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _service;

    public RestaurantController(IRestaurantService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var restaurants = await _service.GetRestaurantsAsync();
        return Ok(restaurants);
    }
}