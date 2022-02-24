using Microsoft.Extensions.DependencyInjection;
using AppServices.Brand;
using AppServices.Owner;
using AppServices.Vehicle;

namespace AppServices
{
    public static class ServiceConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            AddServicesBrand(services);
            AddServicesOwner(services);
            AddServicesVehicle(services);
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
        public static void AddServicesVehicle(this IServiceCollection services)
        {
            services.AddScoped<ICreateVehicle, CreateVehicle>();
            services.AddScoped<IUpdateVehicle, UpdateVehicle>();
            services.AddScoped<IGetAllVehicle, GetAllVehicle>();
            services.AddScoped<IGetByIdVehicle, GetByIdVehicle>();
        }
    }
}
