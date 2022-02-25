using AppServices.Brand;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Brand
{
    public class CreateTests : BrandTests
    {
        private ICreateBrand _service;
        private Mock<ICreateBrand> _serviceMock;

        [Fact(DisplayName = "Create_Is_ok")]
        public async Task Create_Is_Ok()
        {
            _serviceMock = new Mock<ICreateBrand>();
            _serviceMock.Setup(x => x.Execute(createBrandModel)).ReturnsAsync(Id);
            _service = _serviceMock.Object;

            var result = await _service.Execute(createBrandModel);
            Assert.NotNull(result);
            Assert.True(result == Id);
        }
    }
}
