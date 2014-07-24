using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using tshirt.Core.Entities.Account;

namespace tshirt.Api.ViewModels.Account
{
    public class UserData
    {
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phones")]
        public ICollection<string> Phones { get; set; }

        [JsonProperty("addressDetails")]
        public ICollection<AddressDetail> AddressDetails { get; set; }

        [JsonProperty("cardDetails")]
        public ICollection<CreditCardDetail> CardDetails { get; set; }
    }
}