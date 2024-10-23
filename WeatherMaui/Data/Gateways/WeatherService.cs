using WeatherMaui.Data.Dto;

namespace WeatherMaui.Data.Gateways;

/// <summary>
/// For more info go to https://openweathermap.org/current#name
/// </summary>
public class WeatherService : IWeatherService
{
  // TODO: add to config file
  private const string BASE_URL = "https://samples.openweathermap.org/data/2.5/";
  private const string API_KEY = "15c08d55dca35af18244780fa1a0f047";
  // TODO: Create base http service class and inject base clase as Singleton
  private static HttpClient sharedClient = new()
  {
    BaseAddress = new Uri(BASE_URL)
  };

  public async Task<WeatherResponseDto> GetWeatherByCityStateAndCountry(string cityStateCodeOrCountryCode) => GetWeatherInternal(cityStateCodeOrCountryCode);

  // TODO: Log request
  private static async Task<WeatherResponseDto> GetWeather(string request)
  {
    using HttpResponseMessage responseMessage = await sharedClient.GetAsync($"weather?q={request}&appid={API_KEY}");

    responseMessage.EnsureSuccessStatusCode().WriteRequestToConsole();

    var jsonResponse = await responseMessage.Content.ReadAsStringAsync();

    return WeatherResponseDto.FromJson(jsonResponse);
  }

  private static Task<WeatherResponseDto> GetWeatherInternal(string request)
  {
    WeatherResponseDto result = new();
    try
    {
      result = GetWeather(request);
    }
    catch (Exception ex)
    {
      // TODO: Log error
      Console.WriteLine(ex.Message);
    }

    return result;
  }
}