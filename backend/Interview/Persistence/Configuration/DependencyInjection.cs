using Aplication.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;

namespace Persistence.Configuration
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddSqlite<AppDbContext>(connectionString, options => options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));                    
            services.AddScoped<IAppDbContext, AppDbContext>();
        }
    }
}
