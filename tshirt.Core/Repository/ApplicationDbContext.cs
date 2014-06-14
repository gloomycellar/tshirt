using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tshirt.Core.Entities;

namespace tshirt.Core.Repository
{
    public class ApplicationDbContext : DbContext, IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Tshirt> Tshirts { get; set; }
    }
}
