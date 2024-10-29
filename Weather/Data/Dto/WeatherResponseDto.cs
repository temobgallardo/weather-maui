using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weather.Data.Dto;


public partial class WeatherResponseDto
{
  [JsonProperty("coord")]
  public CoordDto? Coord { get; set; }

  [JsonProperty("weather")]
  public List<WeatherDto>? Weather { get; set; }

  [JsonProperty("base")]
  public string? Base { get; set; }

  [JsonProperty("main")]
  public MainDto? Main { get; set; }

  [JsonProperty("visibility")]
  public long Visibility { get; set; }

  [JsonProperty("wind")]
  public WindDto? Wind { get; set; }

  [JsonProperty("clouds")]
  public CloudsDto? Clouds { get; set; }

  [JsonProperty("dt")]
  public long Dt { get; set; }

  [JsonProperty("sys")]
  public SysDto? Sys { get; set; }

  [JsonProperty("timezone")]
  public long Timezone { get; set; }

  [JsonProperty("id")]
  public long Id { get; set; }

  [JsonProperty("name")]
  public string? Name { get; set; }

  [JsonProperty("cod")]
  public long Cod { get; set; }
}

public partial class CloudsDto
{
  [JsonProperty("all")]
  public long All { get; set; }
}

public partial class CoordDto
{
  [JsonProperty("lon")]
  public double Lon { get; set; }

  [JsonProperty("lat")]
  public double Lat { get; set; }
}

public partial class MainDto
{
  [JsonProperty("temp")]
  public double Temp { get; set; }

  [JsonProperty("feels_like")]
  public double FeelsLike { get; set; }

  [JsonProperty("temp_min")]
  public double TempMin { get; set; }

  [JsonProperty("temp_max")]
  public double TempMax { get; set; }

  [JsonProperty("pressure")]
  public long Pressure { get; set; }

  [JsonProperty("humidity")]
  public long Humidity { get; set; }

  [JsonProperty("sea_level")]
  public long SeaLevel { get; set; }

  [JsonProperty("grnd_level")]
  public long GrndLevel { get; set; }
}

public partial class SysDto
{
  [JsonProperty("type")]
  public long Type { get; set; }

  [JsonProperty("id")]
  public long Id { get; set; }

  [JsonProperty("country")]
  public string? Country { get; set; }

  [JsonProperty("sunrise")]
  public long Sunrise { get; set; }

  [JsonProperty("sunset")]
  public long Sunset { get; set; }
}

public partial class WeatherDto
{
  [JsonProperty("id")]
  public long Id { get; set; }

  [JsonProperty("main")]
  public string? Main { get; set; }

  [JsonProperty("description")]
  public string? Description { get; set; }

  [JsonProperty("icon")]
  public string? Icon { get; set; }
}

public partial class WindDto
{
  [JsonProperty("speed")]
  public double Speed { get; set; }

  [JsonProperty("deg")]
  public long Deg { get; set; }
}

public partial class WeatherResponseDto
{
  public static WeatherResponseDto FromJson(string json) => JsonConvert.DeserializeObject<WeatherResponseDto>(json, Converter.Settings);
}

public static class Serialize
{
  public static string ToJson(this WeatherResponseDto self) => JsonConvert.SerializeObject(self, Weather.Data.Dto.Converter.Settings);
}

internal static class Converter
{
  public static readonly JsonSerializerSettings Settings = new()
  {
    MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    DateParseHandling = DateParseHandling.None,
    Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
  };
}
