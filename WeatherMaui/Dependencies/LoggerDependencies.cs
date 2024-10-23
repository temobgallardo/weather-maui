using Microsoft.Extensions.Logging;

namespace WeatherMaui.Dependencies;

public static class NetwoLoggerDependenciesrkDependencies
{
  public static MauiAppBuilder RegisterLogging(this MauiAppBuilder self)
  {
    // TODO: Add logger
    // self.Services.AddTransient<ILoggingService, LoggingService>();

#if DEBUG
    self.Logging.AddDebug();
#endif
    return self;
  }

}