using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using tshirt.Core.Entities;
using tshirt.Core.Entities.Account;
using tshirt.Core.Entities.Product;
using tshirt.Core.Entities.Product.ConcreteProducts;

namespace tshirt.Core.Repository
{
    public class ApplicationDbContext : IdentityDbContext<User>, IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {            
        }

        public DbSet<Product> Products { get; set; }

        public void Seed()
        {
            //Tshirt tshirt = new Tshirt { Name = "UT WISI ENIM AD", Price = 17.25m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/1.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/2.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "KNOW EXACTLY TURNED", Price = 14.20m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/3.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "YOU THINK FAST", Price = 31.45m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/4.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "KNOW EXACTLY", Price = 22.30m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/5.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "UT WISI ENIM AD", Price = 40.25m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/6.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "YOU THINK WATER", Price = 10.45m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/7.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI", Price = 35.50m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "themes/images/ladies/8.jpg" };
            //Set<Tshirt>().Add(tshirt);

            //-----------------------

            //Tshirt tshirt = new Tshirt { Name = "UT WISI ENIM AD", Price = 17.25m };
            //tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Cat.jpg" };
            //Set<Tshirt>().Add(tshirt);

            Tshirt tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Cat_glasses.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/City.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/City_2.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/City_3.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/City_4.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Differernt.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Flowers.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam_2.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam_3.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam_4.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam_5.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam_7.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Glam_7.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Hold-on.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Home_made_pumkin_bread.jpg" };
            Set<Tshirt>().Add(tshirt);
            
            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/La_villa.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Network-expertise.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Owl_art.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Pioneer vintage.jpg" };
            Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Price = 32.50m };
            tshirt.MainLogo = new UrlDetails { ImageUrl = "store_content/T-shirt/Vintage.jpg" };
            Set<Tshirt>().Add(tshirt);

            SaveChanges();
        }
    }
}
