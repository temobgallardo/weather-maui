using Weather.Data;
using Weather.Domain;

namespace Weather.Dependencies;

public static class ViewDependencies
{
  public static MauiAppBuilder RegisterViews(this MauiAppBuilder self)
  {
    self.Services.AddSingleton<IWeatherRepository, WeatherRepository>();

    return self;
  }

}