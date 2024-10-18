using Microsoft.Extensions.Logging;
using UraniumUI;

namespace WeatherMaui;

String apikey = "15c08d55dca35af18244780fa1a0f047";

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
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
