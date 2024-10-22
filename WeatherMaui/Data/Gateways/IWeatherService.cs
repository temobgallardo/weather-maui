using WeatherMaui.Data.Dto;

namespace WeatherMaui.Data.Connectors;

public interface IWeatherService
{
  Task<WeatherResponseDto> GetWeatherByCity(string city);
  Task<WeatherResponseDto> GetWeatherByCityAndState(string city, string stateCode);
  Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string city, string stateCode, string countryCode);
}