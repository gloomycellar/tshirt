using System.Data.Entity;
using tshirt.Core.Entities;
using tshirt.Core.Entities.ConcreteProducts;

namespace tshirt.Core.Repository
{
    public class ApplicationDbContext : DbContext, IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
