using WeatherMaui.Data;
using WeatherMaui.Domain;

namespace WeatherMaui.Dependencies;

public static class ServiceDependencies
{
  public static MauiAppBuilder RegisterServices(this MauiAppBuilder self)
  {
    self.Services.AddScoped<IWeatherRepository, WeatherRepository>();

    return self;
  }

}