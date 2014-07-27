using Newtonsoft.Json;

namespace tshirt.Core.Entities.Account
{
    public class AddressDetailsData
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postalCode")]
        public int PostalCode { get; set; }        
    }
}
