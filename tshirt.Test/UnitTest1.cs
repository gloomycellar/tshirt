using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using tshirt.Core.Entities;
using tshirt.Core.Repository;
using System.Linq;
using System.Data.Entity;
using tshirt.Core.Entities.Product.ConcreteProducts;
using tshirt.Core.Entities.Product;

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
            context.Seed();
        }

        [TestMethod]
        public void TestMethod2()
        {
            IRepository<Tshirt> repo = new Repository<Tshirt>(new ApplicationDbContext());

            var a = repo.Entities.ToArray();
        }
    }
}
