using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace tshirt.api
{
    public class ValuesController : ApiController
    {
        public string Get()
        {
            string a = "Hello Tim! from service";

            return a;
        }
    }
}
