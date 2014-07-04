using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using tshirt.Core.Entities;
using tshirt.Core.Entities.ConcreteProducts;

namespace tshirt.Core.Repository
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>, IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {            
        }

        public DbSet<Product> Products { get; set; }

        public void Seed()
        {
            Tshirt tshirt = new Tshirt { Name = "UT WISI ENIM AD", Price = 17.25m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/1.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/2.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "KNOW EXACTLY TURNED", Price = 14.20m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/3.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "YOU THINK FAST", Price = 31.45m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/4.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "KNOW EXACTLY", Price = 22.30m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/5.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "UT WISI ENIM AD", Price = 40.25m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/6.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "YOU THINK WATER", Price = 10.45m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/7.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI", Price = 35.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/8.jpg" };
            Set<Tshirt>().Add(tshirt);

            SaveChanges();
        }
    }
}
