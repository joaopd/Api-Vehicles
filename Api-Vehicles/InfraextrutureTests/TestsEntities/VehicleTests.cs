using Domain.Entities;
using Domain.Enums;
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
    public class VehicleTests : BaseTest, IClassFixture<DbTests>
    {
        private ServiceProvider _seviceProvide;

        public VehicleTests(DbTests dbTests)
        {
            _seviceProvide = dbTests.SeviceProvider;
        }

        [Fact(DisplayName = "CRUD Vehicle")]
        [Trait("CRUD", "Vehicle")]
        public async Task CRUD_Vehicle_Returns_OK()
        {
            using (var context = _seviceProvide.GetService<ApplicationDbContext>())
            {
                BrandRepository _BrandRepository = new BrandRepository(context);
                OwnerRepository _OwnerRepository = new OwnerRepository(context);
                VehicleRepository _repository = new VehicleRepository(context);

                Random rnd = new Random();
                var random = rnd.Next(100000, 999999).ToString();
                var renavan = "00000" + random;

                Address address = new Address("57305480", "AL",
                   "Arapiraca", "Baixão", "Praça Coronel José de Farias");

                Owner _Ownerentity = new Owner(Faker.Name.FullName(), OwnerStatusEnum.Actived, address);

                _Ownerentity.SetDocument("93443766000121");
                _Ownerentity.SetEmail(Faker.Internet.Email());

                var _Ownercreated = await _OwnerRepository.Create(_Ownerentity);
                Assert.NotNull(_Ownercreated);

                Vehicle _entity = new Vehicle(renavan, Faker.Name.FullName(), "2022", "2022", random, VehicleStatusEnum.Available, 10);

                Brand _Brandentity = new Brand(Faker.Name.FullName(), BrandStatusEnum.Actived);

                var _Brandcreated = await _BrandRepository.Create(_Brandentity);
                Assert.NotNull(_Brandcreated);

                _entity.SetBrandId(_Brandcreated.Id);
                _entity.SetOwnerId(_Ownercreated.Id);

                var _created = await _repository.Create(_entity);
                Assert.NotNull(_created);
                Assert.Equal(_entity.Status, _created.Status);
                Assert.False(_created.Id == Guid.Empty);

                _created.SetStatus(VehicleStatusEnum.Sold);

                var _updated = await _repository.Update(_created);
                Assert.NotNull(_updated);
                Assert.Equal(_created.Status, _updated.Status);

                var _getById = await _repository.GetById(_created.Id);
                Assert.NotNull(_getById);
                Assert.Equal(_updated.Status, _getById.Status);

                var _getAll = await _repository.GetList();
                Assert.NotNull(_getAll);
                Assert.True(_getAll.Count() > 0);
            }
        }
    }
}
