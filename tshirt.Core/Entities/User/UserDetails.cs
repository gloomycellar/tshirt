using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tshirt.Core.Entities.User
{
    public class UserDetails : EntityBase
    {
        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
