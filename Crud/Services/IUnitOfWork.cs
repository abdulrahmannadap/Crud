using Crud.Core;

namespace Crud.Services
{
    public interface IUnitOfWork
    {
        //IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IEmployeeRepo EmployeeRepo { get; }
        Task<int> CompleteAsync();
    }
}
