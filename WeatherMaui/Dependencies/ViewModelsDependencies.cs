using WeatherMaui.Data;
using WeatherMaui.Domain;

namespace WeatherMaui.Dependencies;

public static class ViewModelDependencies
{
  public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder self)
  {
    self.Services.AddSingleton<IWeatherRepository, WeatherRepository>();

    return self;
  }

}