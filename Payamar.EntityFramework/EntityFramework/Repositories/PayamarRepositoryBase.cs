using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Payamar.EntityFramework.Repositories
{
    public abstract class PayamarRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PayamarDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PayamarRepositoryBase(IDbContextProvider<PayamarDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PayamarRepositoryBase<TEntity> : PayamarRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PayamarRepositoryBase(IDbContextProvider<PayamarDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
