using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using tshirt.Core.Entities;
using tshirt.Core.Entities.ConcreteProducts;
using tshirt.Core.Repository;
using System.Linq;

namespace tshirt.Test
{
    [TestClass]
    public class UnitTest1
    {
        [Ignore]
        [TestMethod]
        public void TestMethod1()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            Tshirt tshirt = new Tshirt { Name = "UT WISI ENIM AD", Prise = 17.25m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/1.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI TATION", Prise = 32.50m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/2.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "KNOW EXACTLY TURNED", Prise = 14.20m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/3.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "YOU THINK FAST", Prise = 31.45m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/4.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "KNOW EXACTLY", Prise = 22.30m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/5.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "UT WISI ENIM AD", Prise = 40.25m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/6.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "YOU THINK WATER", Prise = 10.45m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/7.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            tshirt = new Tshirt { Name = "QUIS NOSTRUD EXERCI", Prise = 35.50m };
            tshirt.Urls.Add(new UrlDetails { ImageUrl = "themes/images/ladies/8.jpg" });
            context.Set<Tshirt>().Add(tshirt);

            context.SaveChanges();

        }

        [TestMethod]
        public void TestMethod2()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var a = context.Set<Tshirt>().ToArray();

            Assert.AreNotEqual(0, context.Set<Tshirt>().Count());
        
        }
    }
}
