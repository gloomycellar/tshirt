using Newtonsoft.Json;

namespace tshirt.Core.Entities.Product
{
    public class AddressDetail //: EntityBase
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postalCode")]
        public int PostalCode { get; set; }        
    }
}
