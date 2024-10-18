using Microsoft.Extensions.Logging;
using UraniumUI;

namespace WeatherMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.UseUraniumUI()
			.UseUraniumUIMaterial() // 👈 Don't forget these two lines.
;

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
