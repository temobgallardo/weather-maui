namespace WeatherMaui.Dependencies;

public static class ViewModelDependencies
{
  public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder self)
  {
    // self.Services.Singleton<IWeatherRepository, WeatherRepository>();

    return self;
  }

}