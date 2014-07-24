
using Newtonsoft.Json;
namespace tshirt.Core.Entities.Account
{
    public class CreditCardDetail : EntityBase
    {
        [JsonProperty("Year")]
        public int Year { get; set; }

        [JsonProperty("Month")]
        public int Month { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("Cvv")]
        public int Cvv { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
