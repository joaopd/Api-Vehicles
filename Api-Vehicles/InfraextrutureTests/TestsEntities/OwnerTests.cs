using Domain.Entities;
using Domain.ValueObject;
using Infraestructure.ApplicationDbContex;
using Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace InfraextrutureTests.TestsEntities
{
    public class OwnerTests : BaseTest, IClassFixture<DbTests>
    {
        private ServiceProvider _seviceProvide;

        public OwnerTests(DbTests dbTests)
        {
            _seviceProvide = dbTests.SeviceProvider;
        }

        [Fact(DisplayName = "CRUD Owner")]
        [Trait("CRUD", "Owner")]
        public async Task CRUD_Owner_Returns_OK()
        {
            using(var context = _seviceProvide.GetService<ApplicationDbContext>())
            {
                OwnerRepository _repository = new OwnerRepository(context);

                Address address = new Address("57305480", "AL",
                   "Arapiraca", "Baixão", "Praça Coronel José de Farias");                

                Owner _entity = new Owner(Faker.Name.FullName(),Domain.Enums.OwnerStatusEnum.Actived, address);

                _entity.SetDocument("93443766000121");
                _entity.SetEmail(Faker.Internet.Email());

                var _created = await _repository.Create(_entity);
                Assert.NotNull(_created);
                Assert.Equal(_entity.Name, _created.Name);
                Assert.Equal(_entity.Status, _created.Status);
                Assert.False(_created.Id == Guid.Empty);

                _created.SetName(Faker.Name.FullName());

                var _updated = await _repository.Update(_created);
                Assert.NotNull(_updated);
                Assert.Equal(_created.Name, _updated.Name);
                Assert.Equal(_created.Status, _updated.Status);

                var _getById = await _repository.GetById(_created.Id);
                Assert.NotNull(_getById);
                Assert.Equal(_updated.Name, _getById.Name);
                Assert.Equal(_updated.Status, _getById.Status);

                var _getAll = await _repository.GetList();
                Assert.NotNull(_getAll);
                Assert.True(_getAll.Count() > 0);
            }
        }
    }
}
