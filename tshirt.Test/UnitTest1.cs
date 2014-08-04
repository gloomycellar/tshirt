using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using tshirt.Core.Entities;
using tshirt.Core.Repository;
using System.Linq;
using System.Data.Entity;
using tshirt.Core.Entities.Product.ConcreteProducts;
using tshirt.Core.Entities.Product;
using tshirt.Core.Entities.Account;
using System.Threading.Tasks;
using System;

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

        [Ignore]
        [TestMethod]
        public void TestMethod2()
        {
            IRepository<Tshirt> repo = new Repository<Tshirt>(new ApplicationDbContext());

            var a = repo.Entities.ToArray();
        }

        [Ignore]
        [TestMethod]
        public void TestMethod3()
        {
            AccountRepository acc = new AccountRepository(new ApplicationDbContext());

            //string username = "tim@tim.com";
            string username = Guid.NewGuid().ToString().Replace("-", "");
            User user = new User
            {
                UserName = username,
                Password = "password",
                FirstName = "first",
                LastName = "last",
                AddressDetails = new AddressDetails { Address = "Address 1" }
            };

            //User user = new User
            //{
            //    Email = "tim@tim.com",
            //    Password = "password",
            //    Phone = "0502535689",
            //    UserName = "tim@tim.com",
            //    FirstName = "My First Name",
            //    LastName = "My Last Name",
            //    AddressDetails = new AddressDetails { Address = "Address 1", City = "Kyiv", PostalCode = 99000 }
            //};

            Task.Run(async () => await acc.RegisterUser(user))
                .ContinueWith(x => Assert.IsTrue(x.Result.Succeeded))
                .Wait();

            User result = null;


            AccountRepository acc1 = new AccountRepository(new ApplicationDbContext());
            Task.Run(async () => await acc1.FindUserByName(username))
                .ContinueWith(x => result = x.Result).Wait();

            Assert.IsNotNull(result.AddressDetails);
            //Assert.AreEqual(result.AddressDetails.Address, "Address 1");
        }

        [TestMethod]
        public void CanSaveOrder()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            AccountRepository accountRepo = new AccountRepository(context);
            IRepository<Order> orderRepo = new Repository<Order>(context);
            IRepository<Product> productRepo = new Repository<Product>(context);

            Product product = productRepo.Entities.Where(x => x.Id == 1).First();

            User user = Task.Run(async () => await accountRepo.FindUserByName("tim@tim.com")).Result;

            Order order = new Order(Guid.Parse(user.Id));

            order.Add(product, 10);

            Task t = Task.Run(async () => {

                try
                {
                    await orderRepo.SaveOrUpdateAcync(order);
                }
                catch (Exception ex)
                {
                    Assert.Fail(ex.Message);
                }
            
            });
        }
    }
}
