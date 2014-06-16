using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace tshirt.Core.Entities
{
    public class EntityBase
    {

        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get { return 0 == Id; } }
    }
}
