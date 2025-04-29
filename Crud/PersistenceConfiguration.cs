using Crud.Core;
using Microsoft.EntityFrameworkCore;

namespace Crud
{
    public static class PersistenceConfiguration
    {
        public static void AddPersistenceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the DbContext with the connection string
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
