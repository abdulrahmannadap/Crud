using Crud.Core;
using Crud.Repositories;
using Crud.Services;

namespace Crud
{
    public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            // Register repository and unit of work interfaces with their implementations
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
