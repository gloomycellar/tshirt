using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tshirt.Core.Entities
{
    public class Product : EntityBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prise")]
        public decimal Prise { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Availability Availability { get; set; }
    }
}
