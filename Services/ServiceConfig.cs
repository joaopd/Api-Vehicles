using Domain.Interfaces;
using Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using Services.Brand.Create;

namespace Services
{
    public static class ServiceConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateBrand, CreateBrand>();
        }
    }
}
