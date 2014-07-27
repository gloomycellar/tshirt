using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tshirt.Core.Entities.Account
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]        
        public string Password { get; set; }

        public string Phone { get; set; }

        public virtual AddressDetails AddressDetails { get; set; }

        public virtual CreditCardDetail CardDetails { get; set; }
    }
}
