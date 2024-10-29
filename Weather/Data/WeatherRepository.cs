using Weather.Data.Gateways;
using Weather.Data.Transformers;
using Weather.Domain;
using Weather.Domain.Data;

namespace Weather.Data;

public class WeatherRepository(IWeatherGateway weatherRepository) : IWeatherRepository
{
  public async Task<WeatherModel> GetWeather(string request)
  {
    Dto.WeatherResponseDto response = await weatherRepository.GetWeatherByCityStateAndCountry(request);

    return WeatherResponseDtoTransformer.Transform(response);
  }
}