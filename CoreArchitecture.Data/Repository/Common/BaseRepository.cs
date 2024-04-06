using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreArchitecture.Data
{
    public abstract class BaseRepository<TEntity, TDbContext> : Repository<TEntity>, IBaseRepository<TEntity>
        where TEntity : class, IBaseEntity
        where TDbContext : DbContext
    {
        protected BaseRepository(TDbContext dbContext) : base(dbContext)
        {
        }

        public void SetAuditableInfo(TEntity entity)
        {
            if (entity is BaseEntity<int> auditableEntity)
            {
                if (auditableEntity.Id == 0)
                {
                    auditableEntity.CreationDate = DateTime.Now;
                    _dbContext.Entry(auditableEntity).Property(o => o.LastUpdatedDate).IsModified = false;
                }
                else
                {
                    auditableEntity.LastUpdatedDate = DateTime.Now;
                    _dbContext.Entry(auditableEntity).Property(o => o.CreationDate).IsModified = false;
                }

            }
        }
    }
}
