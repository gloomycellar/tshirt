using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tshirt.Core.Entities;
using tshirt.Core.Entities.Product;

namespace tshirt.Core.Repository
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        Task SaveOrUpdateAcync(params TEntity[] entities);

        IQueryable<TEntity> Entities { get; }

        void DeleteAsync(params TEntity[] entities);
    }
}
