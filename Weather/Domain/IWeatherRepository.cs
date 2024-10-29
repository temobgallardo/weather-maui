using Weather.Domain.Data;

namespace Weather.Domain;

public interface IWeatherRepository
{
  Task<WeatherModel> GetWeather(string request);
}