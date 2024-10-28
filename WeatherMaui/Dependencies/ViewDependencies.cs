using WeatherMaui.Data;
using WeatherMaui.Domain;

namespace WeatherMaui.Dependencies;

public static class ViewDependencies
{
  public static MauiAppBuilder RegisterViews(this MauiAppBuilder self)
  {
    self.Services.AddSingleton<IWeatherRepository, WeatherRepository>();

    return self;
  }

}