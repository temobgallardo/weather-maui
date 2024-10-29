﻿using Microsoft.Extensions.Logging;
using UraniumUI;

namespace Weather
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
      MauiAppBuilder builder = MauiApp.CreateBuilder();
      builder
        .UseMauiApp<App>()
        .UseUraniumUI()
        .UseUraniumUIMaterial()
        .ConfigureFonts(fonts =>
        {
          fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
          fonts.AddMaterialSymbolsFonts();
        });

#if DEBUG
      builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}