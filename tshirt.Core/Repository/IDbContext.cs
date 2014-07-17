using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace tshirt.Core.Repository
{
    public interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
           where TEntity : class;

        Task<int> SaveChangesAsync();
    }
}
