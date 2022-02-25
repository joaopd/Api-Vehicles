using Domain.Entities;
using Infraestructure.ApplicationDbContex;
using Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace InfraextrutureTests.TestsEntities
{
    public class BrandTests : BaseTest, IClassFixture<DbTests>
    {
        private ServiceProvider _seviceProvide;

        public BrandTests(DbTests dbTests)
        {
            _seviceProvide = dbTests.SeviceProvider;
        }

        [Fact(DisplayName = "CRUD Brand")]
        [Trait("CRUD", "Brand")]
        public async Task CRUD_Brand_Returns_OK()
        {
            using (var context = _seviceProvide.GetService<ApplicationDbContext>())
            {
                BrandRepository _repository = new BrandRepository(context);
                Brand _entity = new Brand(Faker.Name.FullName(), Domain.Enums.BrandStatusEnum.Actived);

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
