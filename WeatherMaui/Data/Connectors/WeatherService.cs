using WeatherMaui.Data.Dto;

namespace WeatherMaui.Data.Connectors;

public interface WeatherService : IWeatherService
{
  public async Task<WeatherResponseDto> GetWeatherByCity(string city)
  {
    throw new NotImplementedException();
  }
  public async Task<WeatherResponseDto> GetWeatherByCityAndState(string city, string stateCode)
  {
    throw new NotImplementedException();
  }
  public async Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string city, string stateCode, string countryCode)
  {
    throw new NotImplementedException();
  }

}