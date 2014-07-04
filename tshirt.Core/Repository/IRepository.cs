using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tshirt.Core.Entities;
using tshirt.Core.Entities.Product;

namespace tshirt.Core.Repository
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        void SaveOrUpdate(params TEntity[] entities);

        IQueryable<TEntity> Entities { get; }

        void Delete(params TEntity[] entities);
    }
}
