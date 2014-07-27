using Newtonsoft.Json;

namespace tshirt.Core.Entities.Account
{
    public class AddressDetails : EntityBase
    {
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }        
    }
}
