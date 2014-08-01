using System.Collections.Generic;
using System.Linq;
using tshirt.Core.Entities.Account;
using tshirt.Core.Extensions;

namespace tshirt.Core.Entities.Product
{
    public class Order : EntityBase
    {
        public Order(User user)
        {
            User = user;
            CartItems = new List<OrderItem>();
            PaymentType = PaymentType.CreditCard;
        }

        public virtual User User { get; private set; }

        public virtual ICollection<OrderItem> CartItems { get; private set; }

        public PaymentType PaymentType { get; set; }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                CartItems.ForEach(x => total += x.TotalPrice);
                return total;
            }
        }

        public void Add(Product product, int count = 1)
        {
            if (CartItems.Any(x => x.Product == product))
            {
                CartItems.Where(x => x.Product == product).First().Add(count);
            }
            else
            {
                CartItems.Add(new OrderItem(product, count));
            }
        }

        public void Remove(Product product, int count = 1)
        {
            if (CartItems.Any(x => x.Product == product))
            {
                OrderItem item = CartItems.Where(x => x.Product == product).First();
                item.Remove(count);
                if (0 == item.Quontity)
                {
                    CartItems.Remove(item);
                }
            }
        }
    }
}
