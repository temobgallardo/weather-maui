using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WeatherMaui.Data.Dto;


public partial class WeatherResponseDto
{
  public string CityName { get; set; }
  public long Visibility { get; set; }
  public WindDto Wind { get; set; }
  public CloudsDto Clouds { get; set; }
  public long Timezone { get; set; }
  public string Name { get; set; }
}
