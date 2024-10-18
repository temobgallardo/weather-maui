using WeatherMaui.Data.Dto;

namespace WeatherMaui.Domain;

public interface IWeatherRepository
{
  Task<WeatherDto> GetWeather(string request);
}