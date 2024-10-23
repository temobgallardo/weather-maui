using WeatherMaui.Data.Dto;
using WeatherMaui.Domain.Data;

namespace WeatherMaui.Data.Transformers;

public class WeatherResponseDtoTransformer
{
  public static Weather Transform(WeatherResponseDto from) => new()
  {
    City = from.Name,
    Country = from.Sys?.Country,
    FeelsLike = (double)from.Main?.FeelsLike,
    Humidity = (long)from.Main?.Humidity,
    Name = from.Name,
    Pressure = (long)from.Main?.Pressure,
    Temp = (double)from.Main?.Temp,
    TempMax = (double)from.Main?.TempMax,
    TempMin = (double)from.Main?.TempMin,
    Timezone = from.Timezone,
    Visibility = from.Visibility,
  };
}