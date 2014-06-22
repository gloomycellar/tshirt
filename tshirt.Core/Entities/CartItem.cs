
namespace tshirt.Core.Entities
{
    public class CartItem : EntityBase
    {
        private Product product;
        private int count;

        public CartItem(Product product, int count = 1)
        {
            this.product = product;
            this.count = count;
        }

        public Product Product { get { return product; } }
        public int Count { get { return count; } }
        
        public decimal TotalPrice
        {
            get
            {
                return (count * product.Price);
            }
        }

        public void Add(int count = 1)
        {
            this.count += count;
        }

        public void Remove(int count = 1)
        {
            if (0 <= (count - count))
            {
                count = 0;
            }
            else
            {
                count -= count;
            }
        }
    }
}
