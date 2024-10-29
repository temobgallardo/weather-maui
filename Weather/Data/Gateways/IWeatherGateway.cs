using Weather.Data.Dto;

namespace Weather.Data.Gateways;

public interface IWeatherGateway
{
  Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string cityStateCodeOrCountryCode);
}