using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tshirt.Core.Entities
{
    public class ColorDetail : EntityBase
    {
        [JsonProperty("colorType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Color ColorType { get; set; }
    }
}
