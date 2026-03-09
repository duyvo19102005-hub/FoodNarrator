namespace food_market_narrator_api.Models;

public class Restaurant
{
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Address { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}