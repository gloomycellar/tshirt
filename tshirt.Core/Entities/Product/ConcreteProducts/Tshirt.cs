using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace tshirt.Core.Entities.Product.ConcreteProducts
{    
    public class Tshirt : Product
    {
        public Tshirt()
        {
            Sizes = new HashSet<SizeDetail>();
            Colors = new HashSet<ColorDetail>();
        }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("sizes")]
        public virtual ICollection<SizeDetail> Sizes { get; set; }

        [JsonProperty("colors")]
        public virtual ICollection<ColorDetail> Colors { get; set; }
    }
}
