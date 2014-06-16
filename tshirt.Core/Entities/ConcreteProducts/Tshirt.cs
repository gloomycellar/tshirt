using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tshirt.Core.Entities.ConcreteProducts
{
    public class Tshirt : Product
    {
        [JsonProperty("category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Category Category { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("sizes")]
        public string[] Sizes { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }
    }
}
