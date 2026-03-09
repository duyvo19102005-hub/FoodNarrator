using FoodMarketNarrator.Services;

namespace FoodMarketNarrator;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>()
               .UseMauiMaps();

        builder.Services.AddSingleton(new HttpClient
        {
            BaseAddress = new Uri("http://10.0.2.2:5044/")
        });

        builder.Services.AddSingleton<ApiService>();
        builder.Services.AddSingleton<LocationService>();
        builder.Services.AddSingleton<DistanceService>();
        builder.Services.AddSingleton<AudioService>();

        return builder.Build();
    }
}