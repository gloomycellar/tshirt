using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tshirt.Core.Entities.Product
{
    public class ColorDetail : EntityBase
    {
        [JsonProperty("colorType")]
        public Color ColorType { get; set; }
    }
}
