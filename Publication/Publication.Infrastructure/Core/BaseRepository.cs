
using Microsoft.EntityFrameworkCore;
using Publication.Domain.Repository;
using Publication.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace Publication.Infrastructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly PublicationContext dbContext;
        private DbSet<TEntity> entities;

        public BaseRepository(PublicationContext dbContext)
        {
            this.dbContext = dbContext;
            this.entities = this.dbContext.Set<TEntity>();
        }
        public virtual void Delete(TEntity entity)
        {
            this.entities.Remove(entity);   
        }

        public virtual List<TEntity> GetEntities()
        {
            return this.entities.ToList();
        }

        public virtual TEntity GetEntity(int id)
        {
            return this.entities.Find(id);
        }

        public virtual void Save(TEntity entity)
        {
            this.entities.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            this.entities.Update(entity);
        }
    }
}
