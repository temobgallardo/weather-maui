using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherMaui.Data.Dto;


public partial class WeatherResponseDto
{
  public string CityName { get; set; }

  public List<WeatherDto> Weather { get; set; }

  [JsonProperty("base")]
  public string Base { get; set; }

  [JsonProperty("main")]
  public MainDto Main { get; set; }

  [JsonProperty("visibility")]
  public long Visibility { get; set; }

  [JsonProperty("wind")]
  public Wind Wind { get; set; }

  [JsonProperty("clouds")]
  public CloudsDto Clouds { get; set; }

  [JsonProperty("dt")]
  public long Dt { get; set; }

  [JsonProperty("sys")]
  public SysDto Sys { get; set; }

  [JsonProperty("timezone")]
  public long Timezone { get; set; }

  [JsonProperty("id")]
  public long Id { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("cod")]
  public long Cod { get; set; }
}
