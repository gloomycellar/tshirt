using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Product>> Get()
        {
            return await Task.Run(() => repo.Entities.ToArray());
        }

        public async Task<Product> Get([FromUri]int id)
        {
            return await Task.Run(() => repo.Entities.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
