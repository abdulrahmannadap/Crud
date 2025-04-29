using Crud.Core;
using Crud.Entities;

namespace Crud.Repositories
{
    public class EmployeeRepo : Repository<Employee>, IEmployeeRepo
    {
        public EmployeeRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
