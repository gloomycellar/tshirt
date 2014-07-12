using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using tshirt.Core.Entities.Product;
using tshirt.Core.Repository;

namespace tshirt.Api.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IRepository<Product> repo;

        public ProductsController(IRepository<Product> repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Product> Get()
        {
            return repo.Entities.ToArray();
        }

        public Product Get([FromUri]int id)
        {
            return repo.Entities.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
