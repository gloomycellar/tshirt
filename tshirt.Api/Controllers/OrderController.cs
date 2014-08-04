using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using tshirt.Api.ViewModels.Cart;
using tshirt.Core.Entities.Account;
using tshirt.Core.Entities.Product;
using tshirt.Core.Repository;
using tshirt.Core.Extensions;
using tshirt.Api.Helper;
using System.Linq;
using System;

namespace tshirt.Api.services
{
    [Authorize]
    public class OrderController : ApiController
    {
        private IRepository<Order> orderRepo;
        private IRepository<Product> productRepo;

        //public OrderController(IRepository<Order> orderRepo, IRepository<Product> productRepo)
        public OrderController()
        {
            //this.orderRepo = orderRepo;
            //this.productRepo = productRepo;
            ApplicationDbContext context2 = new ApplicationDbContext();
            orderRepo = new Repository<Order>(context2);
            productRepo = new Repository<Product>(context2);
        }

        [Authorize]
        public async Task<IHttpActionResult> Post(IEnumerable<CartItemData> items)
        {
            try
            {
                IEnumerable<int> ids = items.Select(x => x.ProductId);
                IEnumerable<Product> products = productRepo.Entities.Where(x => ids.Contains(x.Id));

                Order order = new Order(Guid.Parse(UserHelper.CurrentUser.Id));

                items.ForEach(x => order.Add(products.Where(p => p.Id == x.ProductId).First(), x.Quontity));
                await orderRepo.SaveOrUpdateAcync(order);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }           
        }
    }
}