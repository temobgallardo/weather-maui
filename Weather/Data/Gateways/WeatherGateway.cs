using Weather.Data.Dto;

namespace Weather.Data.Gateways;

/// <summary>
/// For more info go to https://openweathermap.org/current#name
/// </summary>
public class WeatherGateway : IWeatherGateway
{
  // TODO: add to config file
  private const string BASE_URL = "https://samples.openweathermap.org/data/2.5/";
  private const string API_KEY = "15c08d55dca35af18244780fa1a0f047";
  // TODO: Create base http service class and inject base clase as Singleton
  private static readonly HttpClient sharedClient = new()
  {
    BaseAddress = new Uri(BASE_URL)
  };

  public async Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string cityStateCodeOrCountryCode) => await GetWeatherInternal(cityStateCodeOrCountryCode);

  // TODO: Log request
  private static async Task<WeatherResponseDto> GetWeather(string request)
  {
    using HttpResponseMessage responseMessage = await sharedClient.GetAsync($"weather?q={request}&appid={API_KEY}");

    responseMessage.EnsureSuccessStatusCode();

    var jsonResponse = await responseMessage.Content.ReadAsStringAsync();

    return WeatherResponseDto.FromJson(jsonResponse);
  }

  private static async Task<WeatherResponseDto> GetWeatherInternal(string request)
  {
    WeatherResponseDto result = new();
    try
    {
      result = await GetWeather(request);
    }
    catch (Exception ex)
    {
      // TODO: Log error
      Console.WriteLine(ex.Message);
    }

    return result;
  }
}