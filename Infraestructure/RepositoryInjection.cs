using Domain.Interfaces;
using Domain.Interfaces.BaseInterface;
using Domain.UoW;
using Infraestructure.Repository;
using Infraestructure.Repository.BaseRepository;
using Infraestructure.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class RepositoryInjection
    {
        public static void DependencyInjectionConfig(IServiceCollection service)
        {
            DependencyInjectionConfigBaseRepository(service);
            DependencyInjectionConfigBrand(service);
            DependencyInjectionConfigUnitOfWork(service);
            DependencyInjectionConfigOwner(service);
            DependencyInjectionConfigVehicle(service);

        }

        public static void DependencyInjectionConfigBaseRepository(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
        public static void DependencyInjectionConfigUnitOfWork(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        public static void DependencyInjectionConfigBrand(IServiceCollection services)
        {
            services.AddScoped<IBrandRepository, BrandRepository>();
        }
        public static void DependencyInjectionConfigOwner(IServiceCollection services)
        {
            services.AddScoped<IOwnerRepository, OwnerRepository>();
        }
        public static void DependencyInjectionConfigVehicle(IServiceCollection services)
        {
            services.AddScoped<IVehicleRepository, VehicleRepository>();
        }

    }
}
