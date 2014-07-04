using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tshirt.Core.Entities.Product
{
    public class UrlDetails : EntityBase
    {
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
