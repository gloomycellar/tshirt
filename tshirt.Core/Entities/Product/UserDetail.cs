using Newtonsoft.Json;
using System.Collections.Generic;

namespace tshirt.Core.Entities.Product
{
    public class UserDetail : EntityBase
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phones")]
        public ICollection<string> Phones { get; set; }

        //[JsonProperty("addressDetails")]
        //public ICollection<AddressDetail> AddressDetails { get; set; }

        //[JsonProperty("cardDetails")]
        //public ICollection<CreditCardDetail> CardDetails { get; set; }
    }
}
