namespace WeatherMaui.Dependencies;

public static class ViewDependencies
{
  public static MauiAppBuilder RegisterViews(this MauiAppBuilder self)
  {
    // self.Services.Singleton<IWeatherRepository, WeatherRepository>();

    return self;
  }

}