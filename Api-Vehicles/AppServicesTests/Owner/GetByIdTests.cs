using AppServices.Owner;
using AppServices.Owner.GetById.ViewModels;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AppServicesTests.Owner
{
    public class GetByIdTests : OwnerTests
    {
        private IGetByIdOwner _service;
        private Mock<IGetByIdOwner> _serviceMock;

        [Fact(DisplayName = "GetById_Is_ok")]
        public async Task GetById_Is_Ok()
        {
            _serviceMock = new Mock<IGetByIdOwner>();
            _serviceMock.Setup(x => x.Execute(Id)).ReturnsAsync(OwnerModel);
            _service = _serviceMock.Object;

            var result = await _service.Execute(Id);
            Assert.NotNull(result);
            Assert.True(result.Id == Id);
            Assert.Equal(Name, result.Name);

            _serviceMock = new Mock<IGetByIdOwner>();
            _serviceMock.Setup(x => x.Execute(It.IsAny<Guid>())).Returns(Task.FromResult((GetByIdOwnerViewModel)null));
            _service = _serviceMock.Object;

            var _record = await _service.Execute(Id);
            Assert.Null(_record);
        }
    }
}
