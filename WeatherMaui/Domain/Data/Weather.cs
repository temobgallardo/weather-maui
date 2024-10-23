namespace WeatherMaui.Domain.Data;

public class Weather
{
  public string City { get; set; }
  public string Country { get; set; }
  public long Visibility { get; set; }
  public long Timezone { get; set; }
  public string Name { get; set; }
  public double Temp { get; set; }
  public double FeelsLike { get; set; }
  public double TempMin { get; set; }
  public double TempMax { get; set; }
  public long Pressure { get; set; }
  public long Humidity { get; set; }
}
