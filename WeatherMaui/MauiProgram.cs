using Microsoft.Extensions.Logging;
using UraniumUI;
using WeatherMaui.Dependencies;

namespace WeatherMaui;

public static class MauiProgram
{
  public static MauiApp CreateMauiApp()
  {
    MauiAppBuilder builder = MauiApp.CreateBuilder();
    builder
    .UseMauiApp<App>()
    .UseUraniumUI()
    .UseUraniumUIMaterial()
    .CreateDependencyGraph()
    .ConfigureFonts(fonts =>
    {
      fonts.AddFont("OPENSANS-Regular.ttf", "OpenSansRegular");
      fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
      fonts.AddMaterialSymbolsFonts();
    });

#if DEBUG
    builder.Logging.AddDebug();
#endif

    return builder.Build();
  }
}
