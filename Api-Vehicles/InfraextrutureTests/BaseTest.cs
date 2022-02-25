using Infraestructure.ApplicationDbContex;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace InfraextrutureTests
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
       
    }
    public class DbTests : IDisposable
    {
        private string databaseName = $"sqldb-vehicle-registrattion-Tests{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        public ServiceProvider SeviceProvider { get;private set; }

        public DbTests()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<ApplicationDbContext>(
                o => o.UseSqlServer($"Server=localhost;Database={databaseName};Trusted_Connection=True;"), 
                ServiceLifetime.Transient);

            SeviceProvider = serviceCollection.BuildServiceProvider();
            using(var context = SeviceProvider.GetService<ApplicationDbContext>())
            {
                context.Database.EnsureCreated();
            }
        }

        public void Dispose()
        {
            using (var context = SeviceProvider.GetService<ApplicationDbContext>())
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}