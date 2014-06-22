using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tshirt.Core.Entities
{
    public class ColorDetail : EntityBase
    {
        [JsonProperty("colorType")]
        public Color ColorType { get; set; }
    }
}
