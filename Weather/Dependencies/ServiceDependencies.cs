using Weather.Data;
using Weather.Domain;

namespace Weather.Dependencies;

public static class ServiceDependencies
{
  public static MauiAppBuilder RegisterServices(this MauiAppBuilder self)
  {
    self.Services.AddScoped<IWeatherRepository, WeatherRepository>();

    return self;
  }

}