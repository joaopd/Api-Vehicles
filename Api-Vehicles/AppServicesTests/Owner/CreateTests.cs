using AppServices.Owner;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Owner
{
    public class CreateTests : OwnerTests
    {
        private ICreateOwner _service;
        private Mock<ICreateOwner> _serviceMock;

        [Fact(DisplayName = "Create_Is_ok")]
        public async Task Create_Is_Ok()
        {
            _serviceMock = new Mock<ICreateOwner>();
            _serviceMock.Setup(x => x.Execute(createOwnerModel)).ReturnsAsync(Id);
            _service = _serviceMock.Object;

            var result = await _service.Execute(createOwnerModel);
            Assert.NotNull(result);
            Assert.True(result == Id);
        }
    }
}
