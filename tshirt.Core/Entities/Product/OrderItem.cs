
using Newtonsoft.Json;
namespace tshirt.Core.Entities.Product
{
    public class OrderItem : EntityBase
    {
        public OrderItem(Product product, int quontity = 1)
        {
            Product = product;
            Quontity = quontity;
        }

        public virtual Product Product { get; private set; }

        public int Quontity { get; private set; }

        public decimal TotalPrice { get { return (Quontity * Product.Price); } }

        public void Add(int count = 1)
        {
            this.Quontity += count;
        }

        public void Remove(int count = 1)
        {
            if (0 <= (Quontity - count))
            {
                Quontity = 0;
            }
            else
            {
                Quontity -= count;
            }
        }
    }
}
