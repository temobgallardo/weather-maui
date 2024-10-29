using Weather.Data.Gateways;

namespace Weather.Dependencies;

public static class NetworkDependencies
{
  public static MauiAppBuilder RegisterNetwork(this MauiAppBuilder self)
  {
    self.Services.AddScoped<IWeatherGateway, WeatherGateway>();

    return self;
  }

}