using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tshirt.Core.Entities.Product;

namespace tshirt.Api.ViewModels.Cart
{
    public class CartItemData
    {
        //[JsonProperty("product")]
        //public Product Product { get; set; }

        [JsonProperty("quontity")]
        public int Quontity { get; set; }
    }
}