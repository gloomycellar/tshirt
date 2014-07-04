using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tshirt.Core.Entities;
using tshirt.Core.Entities.Product.ConcreteProducts;

namespace tshirt.Core.Repository
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Seed();

            base.Seed(context);
        }
    }
}
