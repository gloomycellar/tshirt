using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace tshirt.Api.ViewModels.Auth
{
    public class RegisterData
    {
        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
