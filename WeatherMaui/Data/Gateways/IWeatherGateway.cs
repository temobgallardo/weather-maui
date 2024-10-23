using WeatherMaui.Data.Dto;

namespace WeatherMaui.Data.Gateways;

public interface IWeatherGateway
{
  Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string cityStateCodeOrCountryCode);
}