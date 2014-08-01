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

namespace tshirt.Api.services
{
    [Authorize]
    public class OrderController : ApiController
    {
        private IRepository<Order> orderRepository;

        public OrderController(IRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        //[Authorize]
        //public IHttpActionResult Get()
        //{
        //    return Ok(Order.CreateOrders());
        //}

        [Authorize]
        public IHttpActionResult Post(IEnumerable<CartItemData> items)
        {
            string userName = ClaimsPrincipal.Current.FindFirst("sub").Value;

            //Order order = new Order(UserHelper.CurrentUser);
            //items.ForEach(x => order.Add(x.Product, x.Quontity));

            //await orderRepository.SaveOrUpdateAcync(order);

            return Ok();
        }
    }

    //public class Order
    //{
    //    public int OrderID { get; set; }
    //    public string CustomerName { get; set; }
    //    public string ShipperCity { get; set; }
    //    public Boolean IsShipped { get; set; }

    //    public static List<Order> CreateOrders()
    //    {
    //        List<Order> OrderList = new List<Order> 
    //        {
    //            new Order {OrderID = 10248, CustomerName = "Taiseer Joudeh", ShipperCity = "Amman", IsShipped = true },
    //            new Order {OrderID = 10249, CustomerName = "Ahmad Hasan", ShipperCity = "Dubai", IsShipped = false},
    //            new Order {OrderID = 10250,CustomerName = "Tamer Yaser", ShipperCity = "Jeddah", IsShipped = false },
    //            new Order {OrderID = 10251,CustomerName = "Lina Majed", ShipperCity = "Abu Dhabi", IsShipped = false},
    //            new Order {OrderID = 10252,CustomerName = "Yasmeen Rami", ShipperCity = "Kuwait", IsShipped = true}
    //        };

    //        return OrderList;
    //    }
    //}
}