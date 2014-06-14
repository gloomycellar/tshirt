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
using tshirt.Core.Repository;

namespace tshirt.api
{
    public class ValuesController : ApiController
    {
        public Tshirt Get()
        {
            IRepository<Tshirt> repo = new Repository<Tshirt>(new ApplicationDbContext());
            return repo.Entities.FirstOrDefault();
        }
    }
}
