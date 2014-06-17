using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using tshirt.Core.Entities;
using tshirt.Core.Entities.ConcreteProducts;
using tshirt.Core.Repository;

namespace tshirt.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 0; i < 100; i++)
            {
                Tshirt tshirt = new Tshirt
                {
                    Name = "Test",
                    Prise = 100m,
                    Availability = Availability.OutOfStock,
                    Category = Category.Animals,
                    Description = "Some Description"
                };

                tshirt.Colors.Add(new ColorDetail { ColorType = Color.Red });
                tshirt.Colors.Add(new ColorDetail { ColorType = Color.White });

                tshirt.Urls.Add(new UrlDetails { ImageUrl = "Url 1" });
                tshirt.Urls.Add(new UrlDetails { ImageUrl = "Url 2" });
                tshirt.Urls.Add(new UrlDetails { ImageUrl = "Url 3" });

                tshirt.Sizes.Add(new SizeDetail { SizeType = Size.M });
                tshirt.Sizes.Add(new SizeDetail { SizeType = Size.L });
                tshirt.Sizes.Add(new SizeDetail { SizeType = Size.S });

                ApplicationDbContext context = new ApplicationDbContext();

                context.Set<Tshirt>().Add(tshirt);

                context.SaveChanges();
            }

        }
    }
}
