using WeatherMaui.Domain.Data;

namespace WeatherMaui.Domain;

public interface IWeatherRepository
{
  Task<Weather> GetWeather(string request);
}