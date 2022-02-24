using Infraestructure.ApplicationDbContex;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class Cfg
    {
        public static void AddCfgDatabase(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(x =>
                   x.EnableSensitiveDataLogging()
                    .UseSqlServer(connectionString: Configuration.GetConnectionString("Context"), sqlServerOptionsAction: sqlOptions => sqlOptions.EnableRetryOnFailure())
               );
        }
    }
}
