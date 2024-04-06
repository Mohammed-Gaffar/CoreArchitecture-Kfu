using Arch.EntityFrameworkCore.UnitOfWork;

namespace CoreArchitecture.Data
{
    public interface IBaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        void SetAuditableInfo(TEntity entity);
    }
}
