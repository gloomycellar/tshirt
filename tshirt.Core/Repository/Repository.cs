﻿using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using tshirt.Core.Entities;
using tshirt.Core.Entities.Product;
using tshirt.Core.Extensions;

namespace tshirt.Core.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : EntityBase
    {
        private readonly IDbContext context;

        public Repository(IDbContext context)
        {
            this.context = context;
        }

        public async Task SaveOrUpdateAcync(params TEntity[] entities)
        {
            TEntity attachedEntity;
            IDbSet<TEntity> set = context.Set<TEntity>();

            foreach (TEntity entity in entities)
            {
                if (entity.IsNew)
                {
                    set.Add(entity);
                }
                else
                {
                    attachedEntity = set.Attach(entity);
                    context.Entry<TEntity>(attachedEntity).State = EntityState.Modified;
                }
            }

            await context.SaveChangesAsync();
        }

        public IQueryable<TEntity> Entities
        {
            get { return context.Set<TEntity>(); }
        }

        public async void DeleteAsync(params TEntity[] entities)
        {
            entities.ForEach(x => context.Set<TEntity>().Remove(x));
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
