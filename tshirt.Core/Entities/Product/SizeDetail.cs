using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tshirt.Core.Entities.Product
{
    public class SizeDetail : EntityBase
    {
        [JsonProperty("sizeType")]
        public Size SizeType { get; set; }
    }
}
