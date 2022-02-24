using Infraestructure.ApplicationDbContex;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ApiVehiclesTests.Ultils
{
    public class FakeContext
    {
        public abstract class BaseTeste
        {
            public BaseTeste()
            {

            }
        }

        public class DbTeste : IDisposable
        {

            private string dataBaseName = $"dbApiTest3 {Guid.NewGuid().ToString().Replace("-", string.Empty)}";
            public ServiceProvider ServiceProvider { get; private set; }

            public DbTeste()
            {
                var serviceCollection = new ServiceCollection();
                serviceCollection.AddDbContext<ApplicationDbContext>(o =>
                  o.UseSqlServer($"Server=localhost;Database={dataBaseName};Trusted_Connection=True;"),
                    ServiceLifetime.Transient
                );

                ServiceProvider = serviceCollection.BuildServiceProvider();
                using (var context = ServiceProvider.GetService<ApplicationDbContext>())
                {
                    context.Database.EnsureCreated();
                }
            }

            public void Dispose()
            {
                using (var context = ServiceProvider.GetService<ApplicationDbContext>())
                {
                    context.Database.EnsureDeleted();
                }
            }
        }
    }
}
