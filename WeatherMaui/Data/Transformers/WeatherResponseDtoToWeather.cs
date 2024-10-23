using WeatherMaui.Data.Dto;
using WeatherMaui.Domain.Data;

namespace WeatherMaui.Data.Transformers;

public class WeatherResponseDtoTransformer
{
  public static Weather Transform(WeatherResponseDto from) => new()
  {
    City = from.Name,
    Country = from.Sys.Country,
    FeelsLike = from.Main.FeelsLike,
    Humidity = from.Main.Humidity,
    Pressure = from.Main.Pressure,
    Temp = from.Main.Temp,
    TempMax = from.Main.TempMax,
    TempMin = from.Main.TempMin,
    // TODO: Fill rest of properties
  };
}