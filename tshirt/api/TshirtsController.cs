using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using tshirt.Core.Entities;
using tshirt.Core.Entities.ConcreteProducts;
using tshirt.Core.Repository;

namespace tshirt.api
{
    public class TshirtsController : ApiController
    {
        private readonly IRepository<Tshirt> repo;

        public TshirtsController(IRepository<Tshirt> repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Tshirt> Get()
        {
            //Tshirt[] t = new[] 
            //{ 
            //    new Tshirt
            //    {
            //        Name="SHIRT 1", Category = Category.Cities, Description = "DESCRIPTION 1",
            //        ImageUrl="URL 1", Prise= 10.00m
            //    },
            //    new Tshirt
            //    {
            //        Name="SHIRT 2", Category = Category.Cities, Description = "DESCRIPTION 2",
            //        ImageUrl="URL 2", Prise= 10.00m
            //    },
            //    new Tshirt
            //    {
            //        Name="SHIRT 3", Category = Category.Cities, Description = "DESCRIPTION 3",
            //        ImageUrl="URL 3", Prise= 10.00m
            //    },
            //    new Tshirt
            //    {
            //        Name="SHIRT 4", Category = Category.Cities, Description = "DESCRIPTION 4",
            //        ImageUrl="URL 4", Prise= 10.00m
            //    },
            //    new Tshirt
            //    {
            //        Name="SHIRT 5", Category = Category.Cities, Description = "DESCRIPTION 5",
            //        ImageUrl="URL 5", Prise= 10.00m
            //    },
            //};

           

            //repo.SaveOrUpdate(tshirt);



            return repo.Entities.ToArray();
        }

        public Tshirt Get([FromUri]int id) {
            return repo.Entities.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
