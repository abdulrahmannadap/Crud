using Crud.Core;

namespace Crud.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IEmployeeRepo EmployeeRepo { get; }
        public UnitOfWork(ApplicationDbContext context, IEmployeeRepo employeeRepo)
        {
            _context = context;
            EmployeeRepo = employeeRepo;
        }

        //public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        //{
        //    return new Repository<TEntity>(_context);
        //}

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
