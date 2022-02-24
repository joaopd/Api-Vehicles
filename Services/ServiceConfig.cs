using Domain.Interfaces;
using Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using Services.Brand;
using Services.Brand.Create;
using Services.Brand.Update;
using Services.Owner;

namespace Services
{
    public static class ServiceConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            AddServicesBrand(services);
            AddServicesOwner(services);
        }
        public static void AddServicesBrand(this IServiceCollection services)
        {
            services.AddScoped<ICreateBrand, CreateBrand>();
            services.AddScoped<IUpdateBrand, UpdateBrand>();
            services.AddScoped<IGetActivedBrand, GetActivedBrand>();
            services.AddScoped<IGetAllBrand, GetAllBrand>();
            services.AddScoped<IGetByIdBrand, GetByIdBrand>();
        }
        public static void AddServicesOwner(this IServiceCollection services)
        {
            services.AddScoped<ICreateOwner, CreateOwner>();
            services.AddScoped<IUpdateOwner, UpdateOwner>();
            services.AddScoped<IGetActivedOwner, GetActivedOwner>();
            services.AddScoped<IGetAllOwner, GetAllOwner>();
            services.AddScoped<IGetByIdOwner, GetByIdOwner>();
        }
    }
}
