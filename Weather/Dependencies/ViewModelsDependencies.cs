using Weather.Data;
using Weather.Domain;

namespace Weather.Dependencies;

public static class ViewModelDependencies
{
  public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder self)
  {
    self.Services.AddSingleton<IWeatherRepository, WeatherRepository>();

    return self;
  }

}