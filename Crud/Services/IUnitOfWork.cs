using Crud.Core;

namespace Crud.Services
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task<int> CompleteAsync();
    }
}
