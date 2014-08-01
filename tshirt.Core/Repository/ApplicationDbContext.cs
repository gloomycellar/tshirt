using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Threading.Tasks;
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

        public DbSet<Order> Orders { get; set; }

        public void Seed()
        {
            AccountRepository acc = new AccountRepository(this);

            Task.Run(async () => await acc.RegisterUser(new User
            {
                Email = "tim@tim.com",
                Password = "password",
                Phone = "0502535689",
                UserName = "tim@tim.com",
                FirstName = "My First Name",
                LastName = "My Last Name",
                AddressDetails = new AddressDetails { Address = "Address 1", City = "Kyiv", PostalCode = 99000 }
            })).Wait();

            //-------------------------------

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
