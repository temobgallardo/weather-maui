using WeatherMaui.Data.Dto;

namespace WeatherMaui.Data.Gateways;

public interface IWeatherService
{
  Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string cityStateCodeOrCountryCode);
}