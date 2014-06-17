using System.Collections.Generic;
using System.Linq;
using tshirt.Core.Extensions;

namespace tshirt.Core.Entities
{
    public class Cart : EntityBase
    {
        private ICollection<CartItem> cartItems;
        private PaymentType paymentType;

        public Cart()
        {
            cartItems = new List<CartItem>();
            paymentType = Entities.PaymentType.CreditCard;
        }

        public virtual IEnumerable<CartItem> CartItems { get { return cartItems; } }

        public PaymentType PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                cartItems.ForEach(x => total += x.TotalPrice);
                return total;
            }
        }

        public void Add(Product product, int count = 1)
        {
            if (cartItems.Any(x => x.Product == product))
            {
                cartItems.Where(x => x.Product == product).First().Add(count);
            }
            else
            {
                cartItems.Add(new CartItem(product, count));
            }
        }

        public void Remove(Product product, int count = 1)
        {
            if (cartItems.Any(x => x.Product == product))
            {
                CartItem item = cartItems.Where(x => x.Product == product).First();
                item.Remove(count);
                if (0 == item.Count)
                {
                    cartItems.Remove(item);
                }
            }
        }
    }
}
