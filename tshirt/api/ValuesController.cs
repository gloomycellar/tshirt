using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using tshirt.Core.Entities;

namespace tshirt.api
{
    public class ValuesController : ApiController
    {
        public Tshirt Get()
        {
            return new Tshirt
                {
                    Name = "test tshirt",
                    Category = Category.Animals,
                    Description = "test description",
                    ImageUrl = "url",
                    Prise = 10.00m
                };
        }
    }
}
