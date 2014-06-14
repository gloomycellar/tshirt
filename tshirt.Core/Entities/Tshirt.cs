using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace tshirt.Core.Entities
{
    public class Tshirt : EntityBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Category Category { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("prise")]
        public decimal Prise { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
