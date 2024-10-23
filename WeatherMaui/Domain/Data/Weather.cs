namespace WeatherMaui.Domain.Data;

public record class Weather
{
  public string City { get; init; }
  public string Country { get; init; }
  public double FeelsLike { get; init; }
  public long Humidity { get; init; }
  public string Name { get; init; }
  public long Pressure { get; init; }
  public double Temp { get; init; }
  public double TempMin { get; init; }
  public double TempMax { get; init; }
  public long Timezone { get; init; }
  public long Visibility { get; init; }
}
