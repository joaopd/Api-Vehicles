using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Services.Apis.Cep.GetCep;
using Services.Apis.Cep.GetCep.Services;

namespace Services
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApis(this IServiceCollection services, IConfiguration configuration)
        {

            services
                .AddRefitClient<IBrasilApi>()
                .ConfigureHttpClient(x => x.BaseAddress = new Uri(configuration["Apis:ApiBrasil:Url"]));

            services.AddSingleton<IApiBrasilService, ApiBrasilService>(x =>
                new ApiBrasilService(x.GetService<IBrasilApi>()));

            return services;
        }
    }
}
