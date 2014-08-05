using System;
using System.Collections.Generic;
using System.Linq;
using tshirt.Core.Entities.Account;
using tshirt.Core.Extensions;

namespace tshirt.Core.Entities.Product
{
    public class Order : EntityBase
    {
        public Order(Guid userId)
        {
            UserId = userId;
            OrderItems = new List<OrderItem>();
            PaymentType = PaymentType.CreditCard;
            OrderId = Guid.NewGuid();
        }

        public virtual Guid UserId { get; private set; }
        public virtual ICollection<OrderItem> OrderItems { get; private set; }
        public PaymentType PaymentType { get; set; }
        public Guid OrderId { get; private set; }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                OrderItems.ForEach(x => total += x.TotalPrice);
                return total;
            }
        }

        public void Add(Product product, int count = 1)
        {
            if (OrderItems.Any(x => x.Product == product))
            {
                OrderItems.Where(x => x.Product == product).First().Add(count);
            }
            else
            {
                OrderItems.Add(new OrderItem(product, count));
            }
        }

        public void Remove(Product product, int count = 1)
        {
            if (OrderItems.Any(x => x.Product == product))
            {
                OrderItem item = OrderItems.Where(x => x.Product == product).First();
                item.Remove(count);
                if (0 == item.Quontity)
                {
                    OrderItems.Remove(item);
                }
            }
        }
    }
}
