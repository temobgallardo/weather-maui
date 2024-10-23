using WeatherMaui.Data.Gateways;
using WeatherMaui.Data.Transformers;
using WeatherMaui.Domain;
using WeatherMaui.Domain.Data;

namespace WeatherMaui.Data;

public class WeatherRepository(IWeatherGateway weatherRepository) : IWeatherRepository
{
  public async Task<Weather> GetWeather(string request)
  {
    var response = await weatherRepository.GetWeatherByCityStateAndCountry(request);

    return WeatherResponseDtoTransformer.Transform(response);
  }
}