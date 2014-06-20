using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace tshirt.Core.Entities
{
    public abstract class Product : EntityBase
    {
        public Product()
        {
            Urls = new HashSet<UrlDetails>();
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prise")]
        public decimal Prise { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Availability Availability { get; set; }

        [JsonProperty("urls")]
        public virtual ICollection<UrlDetails> Urls { get; set; }
        
        [JsonProperty("mainLogo")]
        public virtual UrlDetails MainLogo { get; set; }
    }
}
